# Database-First con Entity Framework Core y MySQL 💾

En este tutorial, aprenderemos como importar los datos de una base de datos MySQL ya creada y utilizarlos usando Entity Framework Core. Esto se conoce como *Database-First*.

## Programas Necesarios 💻
Primero, tenemos que descargar e instalar los siguientes programas:
> Este paso solo es necesario si no queremos usar MySQL Workbench y el servicio oficial de MySQL, respectivamente.

- **[SQLYog Community 🐬](https://github.com/webyog/sqlyog-community/wiki/Downloads) :**  *"Es una potente herramienta de interfaz gráfica para gestionar servidores y bases de datos MySQL y MariaDB en entornos físicos, virtuales y en la nube."*	<sup><a id="fnp1" href="#fn1">1</a></sup>

- **[AMPPS](https://ampps.com/downloads) :**	*"Es un stack de software fácil de instalar de Apache, MySQL, PHP, Perl, Python y el auto-instalador Softaculous, que se puede utilizar en desktops y servidores de oficina."*	<sup><a id="fnp2" href="#fn2">2</a></sup>

El siguiente gif detalla como configurar los programas para este tutorial. Es muy simple, de hecho!
<br><br>
<img src="https://i.ibb.co/9V4Krg0/ezgifcom-gif-maker.gif?raw=true" />


## Descargando la Base de Datos 📚
Usaremos la base de datos de Northwind, disponible en <a href="https://github.com/dalers/mywind">este repositorio de GitHub</a>, y descargaremos los archivos `northwind-data.sql`, `northwind.sql` y `northwind-erd.pdf`.

Aquí está el diagrama Entidad Relación de la misma, [encontrado en el repositorio](https://github.com/dalers/mywind/raw/master/northwind-erd.png).
<br><br>
![northwind-erd.png](https://github.com/dalers/mywind/raw/master/northwind-erd.png)

## Construyendo la Base de Datos 👷‍♂️📄

Arrastramos el archivo `northwind.sql` a la ventana de SQLYog y lo ejecutamos presionando las teclas `Ctrl + F9` o dándole click al botón `Execute All Queries`. Esto creará la Base de Datos en el mismo. Repetimos estos pasos con el archivo `northwind-data.sql`, para poblar las tablas de los datos que estaremos usando.


## Creando el Proyecto 📁
Abrimos el Command Prompt o Powershell y navegamos (o creamos) el directorio en que vamos a crear nuestro proyecto.

Verificamos que `dotnet ef` este instalado ejecutando este comando:
```bash
dotnet tool install --global dotnet-ef
```
<br>
Si lo tenemos instalado, nos dirá que ya lo está y, si no, nos lo instalará.

Ahora, creamos un nuevo proyecto utilizando el template de Blazor Server
```bash
dotnet new blazorserver -o "Tarea_5"
```
<br>
Y entramos al directorio del proyecto utilizando el comando <code>cd</code>:

```bash
cd Tarea_5
```

<br>
Una vez creado el proyecto, instalamos las dependencias que necesitará con los siguientes comandos. Es muy importante instalar específicamente las versiones detalladas en los mismos.

```bash
dotnet add package Microsoft.EntityFrameworkCore.Relational -v 3.1.12
dotnet add package Microsoft.EntityFrameworkCore.SqlServer -v 3.1.12
dotnet add package Microsoft.EntityFrameworkCore.Tools -v 3.1.12
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design -v 5.0.2
dotnet add package Pomelo.EntityFrameworkCore.MySql -v 3.2.4
```

## Creando los Modelos a partir de la Base de Datos 📋
Para hacer esto, usaremos este comando. Este puede variar dependiendo algunos factores, tales como el gestor de base de datos que estemos usando.
```bash
dotnet ef dbcontext scaffold "server=localhost;uid=root;pwd=mysql;database=northwind" Pomelo.EntityFrameworkCore.MySql --output-dir Models --force
```
Podemos confirmar la creación de los modelos accediendo a la carpeta Models, tal como se ve en la imagen.

![Models](https://i.ibb.co/cDGXLN8/image.png)

A partir de aquí, ya se pueden hacer consultas utilizando otra herramienta muy útil, [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/).

Por ejemplo, esta es una consulta para cargar todos los empleados en una tabla usando Blazor.

![VSCode_Consulta](https://i.ibb.co/cgCVZRr/image.png)
<br><br>
Y aquí está el resultado.


![Resultado](https://i.ibb.co/5YxR6Wh/image.png)

Adjunto a este tutorial, se encuentra el código fuente de la aplicación. Si desea, puede hacerle "fork" al repositorio y probarlo.


<br >

## Notas

<sub><a id="fn1" href="#fnp1">1:</a> Extracto traducido del Readme del [repositorio oficial de SQLYog Community Edition](https://github.com/webyog/sqlyog-community).</sub>

<sub><a id="fn2" href="#fnp2">2:</a>	Extracto traducido de la [página oficial de AMPPS](https://ampps.com).</sub>

<!--stackedit_data:
eyJwcm9wZXJ0aWVzIjoiZXh0ZW5zaW9uczpcbiAgcHJlc2V0Oi
Bjb21tb25tYXJrXG4iLCJoaXN0b3J5IjpbMTg1NjQxMjI0Nywt
MTkyNjM0Nzg2LC0xOTM0MzQzNTczLC0xMzIxNTc0NzMwLC0xMz
UwMjkxNjMsMTIwMDI3NDQwOSwxMjA1NzU5MjM5LDIwNzE4MzE1
NzYsLTEwNDg2NzIzMTYsLTEyNDI1NDgzOTRdfQ==
-->