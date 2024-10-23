# Verificador CEP - Mercado Livre Flex
Este projeto é uma solução desenvolvida para auxiliar Sellers do Mercado Livre na checagem de atendimento do serviço: Mercado Envios Flex na cidade de São Paulo.
A aplicação verifica se certa região é atendedida ou não pelo Flex, com base no CEP inserido.

## Funcionalidades
- Verificação de CEPs a partir de uma base de dados.
- Geração e salvamento de uma planilha Excel contendo informações de endereço, incluindo nome, CEP, endereço, complemento, bairro, cidade e estado.
- O arquivo Excel gerado é compatível com plataforma TRACKen. Empresa parceira do Mercado Livre. Com esse arquivo o usurio pode gerar uma etiqueta de envio na platforma e fazer envios por conta própria.

## Tecnologias Utilizadas
- **Linguagem C-Sharp**
- **.NET 8**
- **Windows Forms**
- **NPOI**: Biblioteca utilizada para manipulação de arquivos Excel.
- **Banco de dados - SQL Server**: Para armazenamento de dados.
- **Integração com API - Viacep**
  
## Como Usar
1. Insira o CEP e clique em pesquisar - Caso atenda, alguns campos seram preenchidos de forma automatica, devido a integração com a API do Via CEP: logradouro, bairro, Cidade E UF. 
Os demais campos são prenchidos de forma manual: Nome, CPF, numero, complemento e contato.
3. Clique no botão "Gerar Excel" para gerar uma planilha para criação da etiqueta e também salvar os dados em um banco de dados.
4. O arquivo será salvo automaticamente na área de trabalho.

## Observações importantes:
- **Banco de Dados: O projeto utiliza um banco de dados SQL Server. É necessário ajustar a conexão e as tabelas de acordo com a estrutura do seu banco.**
- **Dependências: Certifique-se de baixar todas as dependências e pacotes necessários, como a .NET 8.**

## Instalação
1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/VerificadorCEP.git
2. Instale as dependências
   ```bash
   dotnet restore 
3. Biuld o projeto: Para verificar se seu projeto está correto e que não está faltando nada.
   ```bash
   dotnet builld
4. Execute o projeto
   ```bash
    dotnet run
