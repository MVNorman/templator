# Install PostgreSQL (14.5)
https://www.enterprisedb.com/downloads/postgres-postgresql-downloads

# How to run app using docker

1. Build image: docker build -t apiWithPostgreSQL-image .

2. Run image: docker run -d -p 8080:80 --name apiWithPostgreSQL apiWithPostgreSQL-image

3. Start using on http://localhost:8080/