FROM mysql/mysql-server:latest
LABEL maintainer="Tiago Pala"
ENV MYSQL_ROOT_HOST=%
ENV MYSQL_ROOT_PASSWORD=webappdocker
ENV MYSQL_DATABASE=librarydb
COPY library.context.sql /docker-entrypoint-initdb.d/init.sql
VOLUME [ "/var/lib/mysql" ]
EXPOSE 3306