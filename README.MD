# Employement Assessment

Appointment management system for a clinic.

## Development 

### Prerequisites

Make sure you have the following installed before getting started:

- [.NET SDK](https://dotnet.microsoft.com/download) (version 6.0 or higher)
- [MySQL](https://www.mysql.com/) (version 8.0 or higher)
- [Git](https://git-scm.com/)

<hr>

### To clone this repository:

- <code> Git clone https://github.com/carobte/riwi-assesment </code>

<hr>

### To restore dependencies

Restore NuGet packages:

- <code> dotnet restore </code>

<hr>

### .env file

Make sure you add the environment variables locally in the .env file:

DB_HOST =  </br>
DB_PORT =  </br>
DB_DATABASE = </br>
DB_USERNAME = </br>
DB_PASSWORD = </br>
</br>
JWT_KEY = </br> 
JWT_ISSUER = </br>
JWT_AUDIENCE = </br>
JWT_EXPIREMINUTES = </br>

<hr>

### To run the project in dev mode

- <code> dotnet run </code>

Note: Remember to add the /swagger to your localhost so you can see the available endpoints or use the welcome page to be redirected.

<hr>