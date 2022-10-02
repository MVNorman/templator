docker build -t apiWithPostgreSQL-image .

docker run -d -p 8080:80 --name apiWithPostgreSQL apiWithPostgreSQL-image