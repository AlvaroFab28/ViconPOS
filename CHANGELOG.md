# Changelog
Todos los cambios notables de este proyecto serán documentados en este archivo.

El formato está basado en [Keep a Changelog](https://keepachangelog.com/en/1.0.0/).

## [No Publicado]
### Agregado
-

### Cambiado
-

### Corregido
-
## [0.1.0] - 2025-07-13
### Agregado
- **Estructura del proyecto**
  - Diseño de arquitectura MVP + Repository + Inyección de Dependencias
  - Estructura de carpetas organizada por capas y responsabilidades
  - Core/ - preparado para modelos y contratos de interfaces
  - Infrastructure/ - preparado para repositorios y servicios de datos
  - Modules/ - preparado para presentación por funcionalidades
 
- **Base de datos SQLite**
  - Base de datos SQLite creada y configurada
  - Tabla de usuarios implementada
  - Tabla de roles implementada
  - Preparada para sistema de autenticación
 
- **Configuración inicial**
  - appsettings.json con estructura base
  - Program.cs preparado para inyección de dependencias
 
- **Módulos preparados (estructura)**
  - Carpetas de Login/ con subcarpetas View/ y Presenter/
  - Estructura base para: Inventario, POS, Recetas, Compras, Finanzas, Dashboard
  - Fundación lista para implementación de funcionalidades

### Notas técnicas
- Solo estructura de carpetas y base de datos en esta versión
- Preparado para implementar patrones MVP, Repository y DI
- SQLite como motor de base de datos elegido
- Próximas versiones incluirán implementación de clases y funcionalidades