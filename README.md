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
dotnet add sln Dominio
dotnet add sln Persistencia
dotnet add sln Aplicacion
dotnet add sln DinoApi
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