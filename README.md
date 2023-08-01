## Nueva Estructura NetCore

---

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

