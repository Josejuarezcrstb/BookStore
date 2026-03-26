# CardStore

[![License: MIT](https://img.shields.io/badge/license-MIT-blue.svg)](LICENSE)
[![Status](https://img.shields.io/badge/status-experimental-orange.svg)](#)
[![.NET](https://img.shields.io/badge/.NET-10-green.svg)](#)

Aplicación ASP.NET Core MVC de ejemplo para una tienda de cartas coleccionables, con autenticación simplificada y carrito de órdenes.

## Índice

- [Características](#caracter%C3%ADsticas)
- [Estructura](#estructura)
- [Requisitos](#requisitos)
- [Instalación y ejecución](#instalaci%C3%B3n-y-ejecuci%C3%B3n)
- [Uso](#uso)
- [Pruebas](#pruebas)
- [Contribuir](#contribuir)
- [Licencia](#licencia)
- [Comparación con otros repositorios](#comparaci%C3%B3n-con-otros-repositorios)

## Características

- ASP.NET Core MVC con Razor Views
- CRUD básico de productos/tienda (frontend + backend)
- Usuarios de ejemplo en `App_Data/users.json`
- Soporte de estáticos en `wwwroot` (CSS/JS)
- Home, Store, Profile, Privacy

## Estructura

- `CardStore/` - proyecto principal
  - `Controllers/` - controladores MVC
  - `Models/` - modelos de datos
  - `Views/` - vistas Razor
  - `wwwroot/` - activos estáticos (CSS/JS/lib)
  - `App_Data/users.json` - datos de prueba de usuarios

## Requisitos

- .NET 10 SDK
- Visual Studio 2022/2023, Rider o Visual Studio Code con C# extension

## Instalación y ejecución

1. Clona el repositorio:

```bash
git clone <URL_DEL_REPO>
cd demo/CardStore
```

2. Restaura y ejecuta:

```bash
dotnet restore
dotnet run
```

3. Abre en el navegador las URLs devueltas (por ejemplo `https://localhost:5001`).

## Uso

- `Home` - página principal
- `Store` - catálogo de cartas
- `Profile` - datos de usuario (mock)
- `Privacy` - política de privacidad

Front-end: `wwwroot/css/site.css`, `wwwroot/js/store.js`.

## Pruebas

No hay tests automatizados incluidos en este commit. Recomendado:

- `xunit` o `NUnit` para pruebas unitarias.
- `Playwright` o `Selenium` para pruebas end-to-end.

## Contribuir

1. Haz fork de este repo
2. Crea una rama `feature/<nombre>`
3. Haz commit y push
4. Abre PR con descripción y screenshots

## Licencia

MIT (si no hay un archivo `LICENSE`, crea el archivo y pon MIT). Reemplaza según tu licencia preferida.

## Comparación con otros repositorios

Cuando compares con otros proyectos, revisa:

- actividad de commits y issues recientes
- cobertura de documentacion (README, CONTRIBUTING, CODE_OF_CONDUCT)
- CI/CD configurado (`.github/workflows`)
- pruebas automatizadas (`tests`, `*.csproj` con `dotnet test`)
- dependencia actualizada (`global.json`, `nuget`) 
- arquitectura (`Controllers`, `Models`, `Views`, `wwwroot`)

### Indicadores generales

- `stars`, `forks`, `watchers`
- tiempo de respuesta de PR e issues
- issues abiertos y cierre rápido
- reputación de mantenedor

### Cómo ejecutar una comparativa rápida

```bash
gh repo view <owner>/<repo> --json name,description,stars,forks,watchers,updatedAt
```

> Consejo: crea un documento `comparison.md` con métricas cronometradas para cada repo analizado.

