# Criando uma imagem docker a partir do dockerfile

A partir do diretório ```\AspNetCoreWebApiDockerApp\tests\```

Executar o comando ```docker build -f bd.mysql.dockerfile -t tiagopala/mysql-db-library-app .``` para buildar a imagem.

Executar o comando ```docker run -d --name mysql-library-app -p "3307:3306" -v "$(pwd)\database-volume:/var/lib/mysql" tiagopala/mysql-db-library-app```

Ele irá subir a imagem expondo a porta 3307 à ser utilizada pela aplicação e já criar um volume dentro do diretório ```\database-volume``` para persistência de dados.