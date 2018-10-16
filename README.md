# Todo-ddd-netcore
A project using netcore 2.1 and Domain Drive Design concepts

![Alt text](image-archteture.png?raw=true "Archtecture")

## Database
The application is using Docker Mysql Database configured(user and password) in docker-compose.xym. 
Is required to run this database docker and docker compose.
To run just go to the project root folder and run the follow command.

> docker-compose up

#Migrations
### Create
> dotnet ef migrations add InitialCreate --startup-project ../Todo.UI.Web/

### Update
> dotnet ef database update InitialCreate --startup-project ../Todo.UI.Web/

