# Verificador CEP

Este projeto é uma aplicação Windows Forms desenvolvida em C# com o objetivo de verificar e validar CEPs, salvando os dados em uma planilha Excel. A aplicação utiliza a biblioteca **NPOI** para manipulação de arquivos Excel, garantindo compatibilidade com outras plataformas.

## Funcionalidades
- Verificação de CEPs a partir de uma base de dados.
- Geração e salvamento de uma planilha Excel contendo informações de endereço, incluindo nome, CEP, endereço, complemento, bairro, cidade e estado.
- O arquivo Excel gerado é compatível com plataformas de upload.

## Tecnologias Utilizadas
- **.NET 8**
- **Windows Forms**
- **NPOI**: Biblioteca utilizada para manipulação de arquivos Excel.
- **SQL Server**: Para armazenamento de dados.
  
## Como Usar
1. Insira o nome e os dados de endereço (CEP, logradouro, número, complemento, etc.).
2. Clique no botão "Gerar Excel" para gerar o arquivo com os dados inseridos.
3. O arquivo será salvo automaticamente na área de trabalho.

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
```

  






   
   
