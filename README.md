Trabajo Práctico 4 Consumo de API REST con Blazor Hybrid

I.T.E.S Santa Rosa
Programación 3 Aplicaciones Móviles
Alumno: Montes Valentin

Aplicación que se desarrolló utilizando .NET MAUI Blazor Hybrid integrando una interfaz de usuario web dentro de un contenedor nativo. 

A continuación detallo páginas creadas y servicios consumidos.

Páginas Creadas:
-Home.razor
Ruta de acceso: "/"
Descripción: Pantalla de inicio y bienvenida que presenta el trabajo y unos botones de navegación hacia el panel de gestión.


-Productos.razor
Ruta de acceso: "/productos"
Este es el componente principal, que muestra una tabla interactiva con el catálogo de productos y un formulario para altas y modificaciones, el mismo implementa parches de estado local para simular acciones que la API no persiste.

ENPOINTS CONSUMIDOS

GET https://dummyjson.com/products?limit=8  Se ejecuta al inicializar la página para cargar la lista de productos.

POST https://dummyjson.com/products/add  Se ejecuta desde el formulario al guardar un producto nuevo (Id = 0).

PUT https://dummyjson.com/products/{id}  Se ejecuta desde el formulario al actualizar un producto existente.

DELETE https://dummyjson.com/products/{id}  Se ejecuta al presionar el botón de "Eliminar" en la tabla.


-NotFound.razor
interfaz que maneja errores 404

-Menú de Navegación (NavMenu.razor)
Este componente lateral permite la navegación entre "/" y "/productos"
