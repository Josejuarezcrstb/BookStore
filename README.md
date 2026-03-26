# CardStore

Proyecto ASP.NET Core MVC simple para tienda de cartas.

## Estructura

- `CardStore/` - proyecto principal
- `CardStore/Controllers/` - controladores MVC
- `CardStore/Views/` - vistas
- `CardStore/wwwroot/` - assets estáticos (CSS/JS)
- `CardStore/App_Data/users.json` - datos de usuarios de ejemplo

## Requisitos

- .NET 10 SDK
- Visual Studio 2022/2023, Rider, o VS Code con C# extension

## Cómo ejecutar

Desde la carpeta del proyecto:

```bash
cd CardStore
dotnet run
```

Abrir en el navegador: `https://localhost:5001` (o las URLs que aparezcan en consola)

## Ignorar en git

Se incluye `.gitignore` para no subir `bin/`, `obj/`, files de IDE, logs, etc.

## Notas

- El proyecto ya tiene datos de prueba en `App_Data/users.json`.
- Para cambios en frontend, editar `wwwroot/css/site.css` y `wwwroot/js/store.js`.
