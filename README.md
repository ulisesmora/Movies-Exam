# Movies Exam
## Installation

Requirements

You must have the next tools

```sh
Docker
Visual Studio 2022 windows
Asp Net 6
```



## Development

Open solution Project in visual studio 2022

First Step:
We need to create a configure the databse in docker container 
```sh
docker-compose build
```

Second Step:

```sh
docker-compose up
```

Third Step:

```sh
Access to container database from dbeaver or microsoft sql server managment with the next access sql authentication 
user: sa
password: Password$
```

Four Step:

```sh
Run Migrations - Open "Consola de administrador de paquetes" and run the next commands 
 - Add-Migration InitialSql -Project Movies-Exam -StartupProject Movies-exam
 - Update-Database -Project Movies-Exam -StartupProject Movies-Exam
```
Five Step:

```sh
Stop docker containers and change datbase name in appsettings.json
 -   "DBConnection": "Server=MoviesDB;Initial Catalog=VisualContent;User Id=sa;Password=Password$;Trusted_Connection=False; TrustServerCertificate=True;MultipleActiveResultSets=true;"

```


Final Step:

```sh
- docker-compose build
- docker-compose up 
export postman collection inside folder Postmancollection
```
