# 🛒 GestiónVentas - Punto de Venta para Abarrotes

**GestiónVentas** es una aplicación de escritorio robusta y escalable diseñada para la administración integral de tiendas de abarrotes. Construida con **.NET MAUI** y **PostgreSQL**, ofrece una experiencia multiusuario con control granular de permisos.

---

## 🚀 Características Principales

* **Ventas Versátiles:** Soporte para venta al **mayoreo y menudeo**.
* **Gestión de Inventarios:** Control estricto de entradas, salidas y existencias.
* **Facturación Local:** Generación de notas de venta e impresión de tickets físicos.
* **Catálogo Dinámico:** Gestión de productos por marcas, categorías y unidades de medida.
* **Logística y Reportes:** Módulos de seguimiento de mercancía y reportes detallados para la toma de decisiones.
* **Seguridad:** Sistema de autenticación y autorización basado en roles (RBAC).

---

## 🛠️ Stack Tecnológico

* **Interfaz:** .NET MAUI (Desktop)
* **Lenguaje:** C#
* **Base de Datos:** PostgreSQL
* **Arquitectura:** Multiusuario con control de acceso por roles.

---

## 🗄️ Diseño de Base de Datos (Esquema)

### 🔐 Seguridad y Acceso
El sistema utiliza una estructura de permisos jerárquica:

| Tabla | Campos Clave |
| :--- | :--- |
| **Usuarios** | `usuario`, `contraseña`, `fk_rol`, `activo` |
| **Roles** | `Admin`, `Gerente`, `Cajero`, `Almacenista` |
| **Permisos** | CRUD de Usuarios, Ventas, Reportes, Productos, Precios y Promociones. |

### 📦 Catálogo de Productos
Estructura relacional para la gestión de mercancía:
* **Productos:** `id`, `barcode`, `nombre_producto`, `contenido`.
* **Relaciones:** Vincualción con `fk_marca`, `fk_categoria` y `fk_unidad`.

---

## 🔑 Matriz de Permisos

El sistema permite configurar acciones específicas por rol:

* **Ventas:** Crear, Leer, Cancelar.
* **Inventarios:** Reportes, Creación y Eliminación.
* **Productos:** Gestión completa (CRUD).
* **Precios:** Actualización y control de catálogos.
* **Promociones:** Gestión de ofertas temporales.

---

## ⚙️ Instalación y Configuración

1.  **Clonar repositorio:**
    ```bash
    git clone [https://github.com/CSMTechLat/gestion-tiendas.git](https://github.com/CSMTechLat/gestion-tiendas.git)
    ```
2.  **Base de Datos:** * Asegúrate de tener **PostgreSQL** instalado.
    * Crea la base de datos y ejecuta los scripts de migración.
3.  **Configuración de Visual Studio:**
    * Abrir el archivo `.slnx`.
    * Restaurar paquetes NuGet.
    * Configurar la cadena de conexión en el archivo de configuración correspondiente.

---
 desarrollado por **CSMTechLat** - 2026


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

--Stock--
-id
-fk_producto
-stock
-stockMin
-stockMax

--Categorias--
-id
-nombre_categoria

--promociones--
-id
-nombre_promocion
-fk_producto
-descuento
-cantidad_min
-fecha_cad

--Ventas--
-id
-fecha
-monto_total
-total_productos
-fk_usuario


--Venta_detalle--
-fk_venta
-fk_producto
-cantidad
-precio


````
