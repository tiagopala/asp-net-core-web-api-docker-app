## Premissas

Já ter a network 'library-network' criada. Ela será utilizada por ambos os containers (API e BD).

# Criando uma imagem docker a partir do dockerfile

A partir do diretório ```\AspNetCoreWebApiDockerApp\bd\```

Executar o comando ```docker build -f bd.mysql.dockerfile -t tiagopala/mysql-db-library-app .``` para buildar a imagem.

Executar o comando ```docker run -d --name librarydb -p "3306:3306" -v "$(pwd)\database-volume:/var/lib/mysql" --network library-network tiagopala/mysql-db-library-app```

Ele irá subir a imagem expondo a porta 3306 à ser utilizada pela aplicação e já criar um volume dentro do diretório ```\database-volume``` para persistência de dados.

Obs: No meu caso, eu estou criando o meu volume em cima da pasta ```\database-volume``` dentro do meu diretório atual. É possível alterar para o desejado.