namespace VerificadorCepWF
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            try
            {
                ApplicationConfiguration.Initialize();
                Application.Run(new Form1());
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro: {ex.Message}", "Erro de Inicializa��o", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}