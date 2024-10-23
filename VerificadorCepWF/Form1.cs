
using System.Diagnostics;
using System.Globalization;
using CsvHelper;
using Newtonsoft.Json;
using NPOI.XSSF.UserModel;
using Color = System.Drawing.Color;
using Microsoft.Data.SqlClient;
using System.Data;

namespace VerificadorCepWF
{
    public partial class Form1 : Form
    {
        List<string> ceps = new List<string>();
        private string conectarBd = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=DB_Flex;Data Source=USUARIO-PC\\MSSQLSERVER1;TrustServerCertificate=True;";


        public Form1()
        {
            InitializeComponent();
            CarregarCeps();
        }
        private void lerDados()
        {
            using (SqlConnection connection = new SqlConnection(conectarBd))
            {
                String query = "SELECT * FROM tb_flex WHERE id_cpf=@id_cpf";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Adiciona o parâmetro CPF
                    command.Parameters.Add("@id_cpf", SqlDbType.Char).Value = txtPesquisaCpf.Text;

                    try
                    {
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.HasRows)
                        {
                            reader.Read();
                            txtName.Text = reader["nome"].ToString();
                            txtCpf.Text = reader["id_cpf"].ToString();
                            txtLogradouro.Text = reader["logradouro"].ToString();
                            txtNumber.Text = reader["numero"].ToString();
                            txtBairro.Text = reader["bairro"].ToString();
                            txtCidade.Text = reader["cidade"].ToString();
                            txtUf.Text = reader["uf"].ToString();
                            txtComplemento.Text = reader["complemento"].ToString();
                            txtContato.Text = reader["contato"].ToString();
                            txtCep.Text = reader["cep"].ToString();
                        }
                        else
                        {
                            throw new Exception("Cpf não cadastrado");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void InserirDados(string nome, string id_cpf, string logradouro, string numero, string bairro, string cidade, string uf, string complemento, string contato, string cep)
        {
            if (VerificarCpfExistente(id_cpf)) return;
           
            using (SqlConnection connection = new SqlConnection(conectarBd))
            {
                string query = "INSERT INTO tb_flex (nome, id_cpf, logradouro, numero, bairro, cidade, uf, complemento, contato, cep) VALUES (@nome, @id_cpf, @logradouro, @numero, @bairro, @cidade, @uf, @complemento, @contato, @cep)";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nome", nome);
                    command.Parameters.AddWithValue("@id_cpf", id_cpf);
                    command.Parameters.AddWithValue("@logradouro", logradouro);
                    command.Parameters.AddWithValue("@numero", numero);
                    command.Parameters.AddWithValue("@bairro", bairro);
                    command.Parameters.AddWithValue("@cidade", cidade);
                    command.Parameters.AddWithValue("@uf", uf);
                    command.Parameters.AddWithValue("@complemento", complemento);
                    command.Parameters.AddWithValue("@contato", contato);
                    command.Parameters.AddWithValue("@cep", cep);

                    try
                    {
                        connection.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("Dados inseridos com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao inserir dados: {ex.Message}");
                    }
                }
            }
        }
       
        
        private bool VerificarCpfExistente(string id_cpf)
        {
            using (SqlConnection connection = new SqlConnection(conectarBd))
            {
                string query = "SELECT COUNT(*) FROM tb_flex WHERE id_cpf = @id_cpf";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_cpf", id_cpf);
                    connection.Open();
                    int count = (int)command.ExecuteScalar();
                    return count > 0; // Retorna true se o CPF existir
                }
            }
        }


        private void conectar()
        {

            using (SqlConnection connection = new SqlConnection(conectarBd))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Conexão bem-sucedida!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro na conexão: {ex.Message}");
                }
            }

        }


        private void CarregarCeps()
        {
            // Caminho local para o arquivo CSV 
            //string caminhoArquivoCsv = "C:\\dev\\VerificadorCepWF\\CsvCeps.csv";
            string caminhoArquivoCsv2 = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "CsvCeps.csv");


            // Inicializa a lista de CEPs


            // Ler o arquivo CSV e adicionar os CEPs à lista
            using (var reader = new StreamReader(caminhoArquivoCsv2))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Read(); // Ignorar a primeira linha se tiver cabeçalho
                while (csv.Read())
                {
                    ceps.Add(csv.GetField<string>(0) ?? string.Empty);
                }
            }
        }

        private async void btnVerificarCep_Click(object sender, EventArgs e)
        {
            string cepDigitado = txtCep.Text.Trim();
            cepDigitado = txtCep.Text.Replace(".", "");


            if (string.IsNullOrWhiteSpace(cepDigitado))
            {
                MessageBox.Show("Por favor, insira um CEP válido.");
                return;
            }
            else if (ceps.Contains(cepDigitado))
            {
                var resultado = await ConsultarViaCep(cepDigitado);

                lblResultado.Text = "ATENDEMOS";
                lblResultado.ForeColor = Color.Green;

                if (resultado != null)
                {
                    txtLogradouro.Text = resultado.Logradouro;
                    txtBairro.Text = resultado.Bairro;
                    txtCidade.Text = resultado.Localidade;
                    txtUf.Text = resultado.Uf;
                }

            }
            else if (cepDigitado.Length != 8)
            {
                MessageBox.Show("Cep incorreto ou quantidade insuficiente");
            }
            else
            {
                MessageBox.Show("Não atendemos nessa região", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static async Task<ViaCepResposta?> ConsultarViaCep(string cep)
        {
            using HttpClient client = new HttpClient();
            try
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                var response = await client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<ViaCepResposta>(response);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao consultar o CEP: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGerarExcel_Click(object sender, EventArgs e)
        {

            //string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), $"{txtName.Text}.xlsx");
            //ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Definir a licença para uso não comercial
            //using (var package = new ExcelPackage())
            //using (var workbook = new XLWorkbook())

            var workbook = new XSSFWorkbook();
            var sheet = workbook.CreateSheet("VerificadorCEP");


            Random random = new Random();
            int idEnvio = random.Next(10000000, 99999999);
            int idVenda = idEnvio;


            var headerRow = sheet.CreateRow(0);
            headerRow.CreateCell(0).SetCellValue("Nome");
            headerRow.CreateCell(1).SetCellValue("CEP");
            headerRow.CreateCell(2).SetCellValue("Endereco");
            headerRow.CreateCell(3).SetCellValue("Complemento");
            headerRow.CreateCell(4).SetCellValue("Bairro");
            headerRow.CreateCell(5).SetCellValue("Cidade");
            headerRow.CreateCell(6).SetCellValue("Estado");
            headerRow.CreateCell(7).SetCellValue("ID ENVIO");
            headerRow.CreateCell(8).SetCellValue("ID VENDA");

            var dataRow = sheet.CreateRow(1);
            dataRow.CreateCell(0).SetCellValue(txtName.Text);
            dataRow.CreateCell(1).SetCellValue(txtCep.Text);
            dataRow.CreateCell(2).SetCellValue($"{txtLogradouro.Text}, {txtNumber.Text}");

            if (string.IsNullOrWhiteSpace(txtComplemento.Text))
            {
                dataRow.CreateCell(3).SetCellValue("");
            }
            else
            {
                dataRow.CreateCell(3).SetCellValue($"{txtComplemento.Text}, {txtContato.Text}");
            }
            dataRow.CreateCell(4).SetCellValue(txtBairro.Text);
            dataRow.CreateCell(5).SetCellValue(txtCidade.Text);
            dataRow.CreateCell(6).SetCellValue(txtUf.Text);
            dataRow.CreateCell(7).SetCellValue(idEnvio);
            dataRow.CreateCell(8).SetCellValue(idVenda);

            string caminhoArquivo = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), $"{txtName.Text}.xlsx");
            using (var fileData = new FileStream(caminhoArquivo, FileMode.Create, FileAccess.Write))
            {
                workbook.Write(fileData);
            }
            MessageBox.Show("Arquivo salvo em sua area de trabalho", "Planilha criada e salva com sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            InserirDados(txtName.Text, txtCpf.Text, txtLogradouro.Text, txtNumber.Text, txtBairro.Text, txtCidade.Text, txtUf.Text, txtComplemento.Text, txtContato.Text, txtCep.Text);
            LimparForms();
        }

        private void txtCep_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas Numeros");
            }

        }

        private void txtCpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas Numeros");
            }
        }

        private void txtContato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Digite apenas Numeros");
            }
        }

        private void lblUf_Click(object sender, EventArgs e)
        {

        }
        public void LimparForms()
        {
            txtCep.Text = "";
            txtName.Text = "";
            txtNumber.Text = "";
            txtCpf.Text = "";
            txtLogradouro.Text = "";
            txtUf.Text = "";
            txtContato.Text = "";
            txtComplemento.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            lblResultado.Text = "";
            txtPesquisaCpf.Text="";
        }

        private void btnKangu_Click(object sender, EventArgs e)
        {
            string url = "https://portal.kangu.com.br/user/auth?message=bmpsc0hwNzNaQlZFemx1R3QvUE9WaFE5eHVVQy9DUUJCSzdreU9iVDMxRXdvdERxRU84eUtGU3k=&success=/seller/dashboard";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtCep_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFlex_Click(object sender, EventArgs e)
        {
            string url = "https://tracken.app.br/login.php";
            Process.Start(new ProcessStartInfo
            {
                FileName = url,
                UseShellExecute = true
            });

        }

        private void btnPesquisaCpf_Click(object sender, EventArgs e)
        {
            lerDados();
        }
    }
}
