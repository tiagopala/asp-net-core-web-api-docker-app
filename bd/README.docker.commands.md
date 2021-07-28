# Subindo e conectando a base de dados via docker

Baixar a última versão da imagem do mysql.

```docker pull mysql/mysql-server```

Subir o container de mysql.

```docker run --name "mysql-webapp" -p "3307:3306" -v "$(pwd):/var/lib/mysql" -e MYSQL_ROOT_HOST=% -e MYSQL_ROOT_PASSWORD=webappdocker -e MYSQL_DATABASE=librarydb -d mysql/mysql-server```

Opcional:

Caso necessário podemos liberar as permissões para a senha que acabamos de criar, por meio dos comandos abaixo.

- Precisamos entrar dentro do container, por meio do comando: ```docker exec -it mysql-webapp mysql -uroot -pwebappdocker```.

```ALTER USER 'root'@'localhost' IDENTIFIED BY 'webappdocker';```

```ALTER USER 'root'@'localhost' IDENTIFIED WITH mysql_native_password BY 'webappdocker';```

```ALTER USER 'root'@'%' IDENTIFIED WITH mysql_native_password BY 'webappdocker';```
