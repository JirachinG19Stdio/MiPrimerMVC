# MiPrimerMVC

Proyecto de práctica en ASP.NET Core MVC. Implementa un CRUD parcial (listar, crear y eliminar) sobre una entidad `Producto`, con validación de datos en cliente y servidor, y protección contra ataques CSRF mediante AntiForgeryToken.

## Requisitos previos

- [.NET SDK](https://dotnet.microsoft.com/download) (versión 8.0 o superior)
- Un editor de código, por ejemplo [Visual Studio Code](https://code.visualstudio.com/) con la extensión C# Dev Kit

## Instrucciones de ejecución

1. Clonar el repositorio:
```bash
   git clone https://github.com/JirachinG19Stdio/MiPrimerMVC.git
```

2. Entrar a la carpeta del proyecto:
```bash
   cd MiPrimerMVC
```

3. Restaurar dependencias:
```bash
   dotnet restore
```

4. Ejecutar el proyecto:
```bash
   dotnet run
```

5. Abrir el navegador en la URL que indique la terminal (por ejemplo `http://localhost:5031`) y navegar a: /Producto/Index

## Funcionalidades

- **Index**: muestra la lista de productos registrados en una tabla.
- **Create**: formulario para registrar un nuevo producto, con validación de datos en cliente (jQuery Validation) y servidor (Data Annotations + ModelState).
- **Delete**: elimina un producto existente, solicitando confirmación previa mediante una vista intermedia y protegiendo la operación con AntiForgeryToken.

## Estructura del proyecto
MiPrimerMVC/

├── Controllers/

│   └── ProductoController.cs

├── Models/

│   └── Producto.cs

├── Views/

│   └── Producto/

│       ├── Index.cshtml

│       ├── Create.cshtml

│       └── Delete.cshtml

└── README.md

## Rama de la práctica

Los cambios correspondientes a esta tarea (acción Delete, validaciones y CSRF) se encuentran en la rama:
feature/practica-aspnet
