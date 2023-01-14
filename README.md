# Desafio-Grupo-Voalle
Esse repositório contém a resolução do desafio proposto pelo grupo voalle da implementação de um desenho de diamante a partir de uma letra.

# Configuração
É necessário a configuração dentro do arquivo <strong>Consts</strong>
com os seguintes valores na raiz do projeto <strong>ConsoleDiamond</strong>

```
email=seu_email
password=sua_senha
```
Com estas informações, a classe que cuida do envio de e-mail estará alimentada com as informações necessárias para o envio do e-mail via smtp hotmail.

# Execução
Para a execução da aplicação, utilize os seguintes comandos:
```
$ cd src
$ dotnet restore
$ cd ConsoleDiamond
$ dotnet run
```

Para a execução dos testes unitários da aplicação, utilize os seguintes comandos
```
$ cd src
$ dotnet restore
$ cd ConsoleDiamond.Test
$ dotnet test
```
# Funcionalidades Adcionais:

## E-mail
A aplicação também permite que, após a geração do diamante, o mesmo seja enviado por e-mail, com a Classe Consts configurada e a resposta positiva do usuário, após inserir o e-mail destino, a aplicação mostra uma mensagem de enviado com sucesso e faz o envio via smtp.

Observação: A aplicação está configurada para que o e-mail remetente seja hotmail.

## PDF
A aplicação também permite que, após a geração do diamante, o mesmo seja gerado como PDF, recebendo uma reposta afirmativa do usuário, o PDF será criado na pasta /src/ConsoleDiamond/PDFs.

## Criador
Denilson Santuchi