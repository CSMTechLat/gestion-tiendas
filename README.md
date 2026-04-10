🛒 GestiónVentas - Punto de Venta para Abarrotes
GestiónVentas es una aplicación de escritorio moderna desarrollada con .NET MAUI, diseñada para optimizar la operación de negocios de abarrotes. Permite un control total sobre el inventario, ventas multicanal (mayoreo/menudeo) y una gestión robusta de usuarios basada en roles.

🚀 Características Principales
📦 Gestión de Inventario
Control de Stock: Registro de entradas y salidas de mercancía en tiempo real.

Catálogo Flexible: Organización por marcas, categorías y unidades de medida.

Precios Dinámicos: Cambio rápido de precios y gestión de catálogos para actualización masiva.

💰 Ventas y Logística
Modos de Venta: Soporte para venta al mayoreo y menudeo.

Comprobantes: Generación de notas de venta e impresión de tickets.

Logística: Módulo integrado para el seguimiento y movimiento de mercancías.

🔐 Seguridad y Multiusuarios
Acceso Controlado: Sistema de login seguro.

RBAC (Role-Based Access Control): Control de acceso basado en roles (Admin, Gerente, Cajero, Almacenista).

Permisos Granulares: Restricción de acciones específicas (Crear, Leer, Actualizar, Borrar) por módulo.

🛠️ Stack Tecnológico
Frontend: .NET MAUI (Desktop App).

Lenguaje: C# 12 / .NET 8.

Base de Datos: PostgreSQL.

ORM: Entity Framework Core / Dapper (opcional).

Reportes: Generación de reportes PDF/Excel para auditorías.

🗄️ Estructura de la Base de Datos
El sistema utiliza una arquitectura relacional en PostgreSQL para garantizar la integridad de los datos.

Seguridad y Usuarios
Usuarios: Gestión de credenciales y estado de cuenta.

Roles: Definición de perfiles (Admin, Gerente, Cajero, Almacenista).

Permisos: Matriz de acceso que cubre:

Usuarios: CRUD completo.

Ventas: Crear, leer y cancelar.

Inventarios: Reportes y gestión de stock.

Productos/Precios: Control de catálogo y actualizaciones.

Promociones: Gestión de ofertas especiales.

Catálogo de Productos
Productos: Información técnica (barcode, nombre, contenido).

Relaciones: Clasificación por Marca, Categoría y Unidad de Medida.

⚙️ Configuración del Proyecto
Requisitos Previos
Visual Studio 2022 con la carga de trabajo de .NET MAUI.

Instancia de PostgreSQL (v14 o superior).

Instalación
Clonar el repositorio:

Bash
git clone https://github.com/CSMTechLat/gestion-tiendas.git
Configurar la base de datos:

Ejecuta el script SQL incluido en /database/script.sql para crear las tablas y roles iniciales.

Configurar Connection String:

Actualiza el archivo appsettings.json o tu clase de configuración con tus credenciales de PostgreSQL.

Ejecutar:

Abre el archivo .slnx o .sln en Visual Studio y presiona F5.

📊 Módulo de Reportes
El sistema genera estadísticas detalladas para la toma de decisiones:

Ventas diarias/mensuales.

Productos más vendidos.

Auditoría de cambios de precios.

Niveles de stock crítico (reorden).

Desarrollado por [Tu Nombre/Organización] - 2026

Punto d venta para abarrotes.
- Aplicación de Escritorio.
- C#,
- POSTGRES SQL
- multiusuarios.
- maui.
- 


-Venta de mayoreo y menudeo.
-Registro de entrada y salida de productos.
-Notas de venta.
-Control de inventarios.
-Catálogos de precios.
-Cambio de precios de productos.
-Logística.
-Reportes.
-Impresión de tickets.


````
BD:

--Usuarios--
-usuario
-contraseña
-fk_rol
-activo


--Roles--
-id
-nombre_rol

{
 -Admin
 -Gerente
 -Cajero
 -Almacenista
 -
}


--PermisosRoles--
-fk_rol
-fk_permiso


--Permisos--
-id
-nombrePermiso


{
 User:
 Create
 Read
 Update
 Delete

 Sell:
 Create
 Read
 Cancel

 Reports/Inventarios:
 Create 
 Read
 Delete

 Productos:
 créate
 read
 update
 delete

 Precios:
 update
 
 Promociones:
 créate
 read
 update

}

--Productos--
-id
-barcode
-nombre_producto -> CocaCola 600ml
-fk_marca ->CocaCola
-fk_categoria ->Refresco
-fk_unidad ->Lt
-contenido ->5
-


````
