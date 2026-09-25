Nombre del Proyecto: Empresa

Descripción del proyecto: API REST desarrollada en VisualBasic .NET con ASP.NET Core,Entity Framework Core y SQL Server, 
aplicando una arquitectura en capas (Controller -> Service -> Repository) para el primer parcial de Programación Orientada por Eventos Avanzada.

Tecnologías Utilizadas:
* Visual Basic .NET
* ASP.NET Core Web API
* Entity Framework Core
* SQL Server
* Visual Studio
* PostMan

Descripción de EndPoints:
* GET /api/clientes - Retorna la lista de todos los clientes registrados.
* GET /api/clientes/{id} - Consulta un cliente específico por su ID.
* HttpPost /api/clientes - Registra un nuevo cliente en el sistema.
* HttpPut /api/clientes/{id} - Modifica los datos de un cliente existente.
* HttpDelete /api/clientes/{id}- Elimina un cliente de la base de datos.

Instrucciones necesarias para ejecutar el proyecto:
Clonar el repositorio.
Ejecutar el script SQL incluido en tu SQL Server para crear la base de datos EmpresaDB.
Configurar la cadena de conexión en el archivo appsettings.json.
Abrir la solución Empresa.sln en Visual Studio y ejecutar el proyecto.
