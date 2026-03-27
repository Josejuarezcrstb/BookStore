# CONTRIBUTING

Gracias por tu interés en contribuir a este proyecto.

## 1. Cómo empezar

1. Haz un fork del repositorio.
2. Clona tu fork:
    - `git clone https://github.com/tuUsuario/repositorio.git`
3. Crea una rama nueva:
    - `git checkout -b feat/nombre-descriptivo`
4. Asegúrate de estar en la rama `main` actualizada y de rebases/merge desde upstream:

- `git fetch upstream`
- `git checkout main`
- `git merge upstream/main`

## 2. Código y estilo

- Usa el mismo estilo que el resto del proyecto.
- Alinea indentación, nombres descriptivos, y comentarios claros.
- Para JavaScript/TypeScript: respeta ESLint/Prettier si existe.
- Para otros lenguajes: aplica convenciones del repo.

## 3. Problemas (Issues)

- Abre un issue antes de implementar cambios grandes.
- Describe:
  - Qué falla o qué mejora quieres.
  - Pasos para reproducir.
  - Resultado esperado y actual.
  - Entorno (OS, versión, etc. si aplica).

## 4. Pull requests

- Crea PR contra `main`.
- Título claro + descripción.
- Vincula el issue con `Fixes #n`.
- Incluye pruebas o evidencia de funcionamiento.
- Revisa antes de solicitar revisión:
  - `git status`
  - `git diff --staged`
  - `npm test` / `pytest` / test de la stack.

## 5. Pruebas

- Ejecuta la suite de tests localmente.
- Agrega tests para nuevas funcionalidades o correcciones.
- Asegura que regresen todos en verde.

## 6. Comunicación

- Usa el canal de issues/PRs del repositorio.
- Sé respetuoso y constructivo.
- Mantén el texto en español o inglés según preferencia del equipo.

## 7. Licencia

- Al contribuir aceptas que tu código se integra bajo la misma licencia del proyecto (mirar `LICENSE`).

---
Cualquier duda, escribe en un issue antes de avanzar.