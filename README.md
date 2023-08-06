## Nueva Estructura NetCore

### Estructura del proyecto:

- Dominio : Se crean tablas que representan la DB.
- Persistencia : Instancia Context DB.
- Aplicacion : Se crea la inyeccion de dependencias para la comunicacion con el webApi.
- webApi: Se crean las clases encargadas de recibir peticiones de los clientes.

---

### Creacion del Proyecto

Generar la solucion principal:
```
dotnet new sln
```
El proyecto de solucion se creara con el mismo nombre del directorio.

Crearemos los proyectos de Libreria Dominio, Persistencia, Aplicacion y el proyecto webApi DinoApi:
```
dotnet new classlib -o Dominio 
dotnet new classlib -o Persistencia
dotnet new classlib -o Aplicacion
dotnet new webapi -o DinoApi
```

Agregamos los proyectos a la solucion principal:
```
dotnet sln add Dominio
dotnet sln add Persistencia
dotnet sln add Aplicacion
dotnet sln add DinoApi
```

Establecemos dependencias entre nuestros proyectos:

- Aplicacion -> Dominio, Persistencia.
- DinoApi -> Aplicacion.
- Persistencia -> Dominio

Para establecer la dependencia debemos ubicarnos en el proyecto al que le estableceremos la referencia y ejecutaremos el siguiente comando:

```
dotnet add reference ../NombreProyecto/
```

--- 

Lo que haremos sera instalar los siguientes paquetes:

- Microsoft.EntityFrameworkCore -> Dominio, DinoApi, Persistencia
- MediatR.Extensions.Microsoft.DependencyInjection -> Dominio
- AutoMapper.Extensions.Microsoft.DependencyInjection -> Dominio
- FluentValidation.AspNetCore -> Dominio
- itext7.pdfhtml -> Dominio
- Pomelo.EntityFrameworkCore.Tools -> Persistencia
- Dapper -> Persistencia
- Microsoft.EntityFrameworkCore.Design -> DinoApi
- Newtonsoft_Json -> DinoApi
- Microsoft.AspNetCore.Authentication.JwtBearer -> DinoApi

Podemos hacer las instalaciones desde la extencion de VsCode NugetGallery o desde la pagina web del mismo.

---

Dentro de la carpeta dominio crearemos todas y cada una de las entidades junto con sus relaciones. 

En la carpeta Persistencia crearemos un directiorio llamado Data en donde almacenaremos todas las Configuraciones de nuestras entidades. Las clases de configuracion heredaran de IEntityTypeConfiguration<>.

---

El siguiente paso va a se crear nuesta clase de context, esta clase la crearemos en Persistencia, le nombre de esta sera el nombre del proyecto seguido de la clase context: NombreProyectoContext

En la clase de Context agregaremos los DbSet de cada una de las entidades
```
public DbSet<Clase> Clases { get; set; }
```

Agregaremos el metodo para la carga automatica de las configuraciones:
```
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
}
```

Luego agregaremos el contexto dentro de nuestro Program y le pasamos nuestro Conection String:

```
builder.Services.AddDbContext<NewEstructureContext>(options => {
    string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
});
```

Crearemos nuestra Connection String dentro de appsettings.Development.json:
```
"ConnectionStrings": {
"DefaultConnection" : "server=localhost; user=root; password=''; database=nombredb"
}
```

---

Ahora crearemos nuestra migracion ejecutando el siguiente comando:
```
dotnet ef migrations add InitialCreate --project ./Persistencia/ --startup-project ./DinoApi/ --output-dir ./Data/Migrations
```

Ahora para crear nuestra base de datos ejecutaremos el siguiente comando:
```
dotnet ef database update --project ./Persistencia/ --startup-project ./DinoApi/
```

---

Crearemos nuestra BaseApiController dentro de DinoApi/Controllers nos ayudara a definir el enrutamiento, esta clase heredara del ControllerBase y al mismo tiempo cada Controlador de nuestras entidades heredara de BaseApiController.

Dentro de Aplicacion crearemos una carpeta por cada entidad de nuestro proyecto, dentro de cada carperta crearemos una clase llamada Consultas, en donde definiremos todas y cada una de las consultas de haremos a nuestra DB.

En DinoApi/Controllers empezaremos a crear los controladores para nuestras entidades, en donde definiremos todos y cada uno de los metodos que necesitemos.

Como estamos trabajando con MediatR es importante agregar este servicio a nuestro proyecto, para eso nos dirigimos a nuestro Program y copiaremos la siguiente linea de codigo:
```
builder.Services.AddMediatR(typeof(Consultas.Manejador).Assembly);
```











