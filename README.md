# Projeto AspNetCoreWebApiDockerApp

Projeto criado com o objetivo de praticar conceitos referentes ao docker, containers e imagens.

### **Escopo**

Este projeto contém uma API simples para consulta de livros, e a imagem (docker) que deverá ser utilizada para comunicação com a tabela books na nossa base de dados mysql.

### **API**

Descrição: API simples a qual possui apenas um CRUD de livros a serem persistidos no bando de dados via container.

![Endpoints](images/Endpoints.png)

### **BD**

No diretório de ```bd\```

Está presente o dockerfile criado para configuração da base de dados utilizada pelo nosso projeto. ```tests\bd.mysql.dockerfile```

Para mais informações: [Library Database](bd/).

### **Src**

No diretório ```src/AspNetCoreWebApiDockerApp/AspNetCoreWebApiDockerApp.Api```

#### Building Project

```dotnet build```

#### Running Project

```dotnet run```

#### Publish Project

```dotnet publish -c Release -r win10-x64 --self-contained```

Obs: Para utilizar as variáveis de ambiente de Release, devemos ter o arquivo ```appsettings.Production.json``` já criado. ("Release = Production")