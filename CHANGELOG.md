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

## [0.3.0] - 2024-07-31
### Agregado
- **Menú principal completamente funcional**
  - Sidebar animado con timer para transiciones suaves
  - Módulos de navegación: Dashboard, Punto de Venta, Inventario, Compras, Finanzas, Configuración
  - Iconos FontAwesome.Sharp para interfaz moderna
  - Diseño responsivo que se adapta al tamaño de ventana
 
- **Sistema de perfil de usuario integrado**
  - Foto de perfil circular en esquina superior derecha
  - Nombre y rol del usuario mostrados desde caché de autenticación

 
- **Sistema de logout funcional**
  - Botón de cerrar sesión en menú principal
  - Retorno automático al login con campos limpiados
  - Limpieza correcta de caché de usuario activo
 
- **Branding corporativo**
  - Logo del negocio integrado en parte superior del sidebar
  - Identidad visual consistente en toda la aplicación
 
- **Preparación para módulos**
  - Estructura preparada para UserControls en paneles
  - Sistema de navegación entre módulos implementado
  - Base sólida para próxima implementación de POS

### Cambiado
- **Interfaz de login modernizada**
  - Diseño actualizado con colores modernos
  - Iconos decorativos agregados
  - Apariencia más profesional y atractiva
  - Mejor experiencia de usuario

### Dependencias agregadas
- RealTaiizor - Para componentes UI avanzados
- FontAwesome.Sharp - Para iconografía moderna
- BCrypt.Net-Next - Para seguridad de contraseñas (ya implementado)
- System.Data.SQLite - Para base de datos (ya implementado)

### Implementado técnicamente
- **UI/UX**: Sidebar animado, diseño responsivo, branding integrado
- **Navegación**: Sistema de módulos con botones funcionales
- **Integración**: Datos de usuario desde sistema de autenticación
- **Preparación**: UserControls listos para implementación en paneles

### Próximos pasos
- Implementación completa del módulo POS con UserControls
- Desarrollo de funcionalidades específicas por módulo
- Sistema de permisos por rol

## [0.2.0] - 2024-07-16
### Agregado
- **Sistema de autenticación completo**
  - Login funcional implementado con patrón MVP
  - LoginForm.cs con interfaz gráfica completa
  - ILoginView.cs como contrato de la vista
  - LoginPresenter.cs manejando toda la lógica de autenticación
 
- **Seguridad implementada**
  - Encriptación de contraseñas con BCrypt
  - BCryptPasswordHasher.cs implementando IPasswordHasher
  - Validación segura de credenciales
 
- **Sistema de inicialización automática**
  - DatabaseSeeder.cs para datos iniciales
  - Creación automática de usuario administrador
  - Verificación y sembrado automático en primera ejecución
 
- **Servicios implementados**
  - AuthService.cs con caché de usuario activo
  - PasswordHasher con algoritmo BCrypt
  - Gestión completa de sesiones de usuario
 
- **Repositorios funcionando**
  - UsuarioRepository.cs completamente implementado
  - BaseRepository.cs con helpers CRUD operativos
  - SQLiteConnectionFactory.cs manejando conexiones
 
- **Modelos de dominio**
  - UsuarioModel.cs con todas las propiedades necesarias
  - RolModel.cs para sistema de permisos
  - Entidades completamente funcionales
 
- **Preparación para siguientes módulos**
  - MainMenuForm.cs estructurado (pendiente de MVP)
  - Carpetas de Inventory/ preparadas para implementación
  - Estructura base para POS, Recetas, Compras, Dashboard

### Cambiado
- Estructura de carpetas refinada y organizada
- Program.cs con inyección de dependencias completamente configurada
- appsettings.json actualizado con configuraciones de seguridad
- **Gestión mejorada de base de datos**: Ahora trabaja con DB única en directorio raíz

### Corregido
- **Bug crítico de duplicación de base de datos**
  - Eliminado problema de creación de copias en carpeta bin/
  - Sistema ahora trabaja consistentemente con CrisCoreDB.db en directorio principal
  - Corregida duplicación de usuario administrador en compilaciones múltiples
  - Gestión unificada de datos sin inconsistencias entre copias

### Implementado técnicamente
- **Patrones aplicados**: MVP, Repository, Dependency Injection
- **Seguridad**: Hashing BCrypt, validación robusta
- **Arquitectura**: Separación clara de responsabilidades
- **Base de datos**: SQLite completamente integrado y optimizado
- **UI**: WinForms con diseño profesional

### Próximos pasos
- Implementación del menú principal con MVP
- Desarrollo de módulos de Inventario y POS
- Sistema completo de roles y permisos

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