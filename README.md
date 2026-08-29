# DeployX

## Proyecto

**TeamGitPractice** es una API Web ASP.NET Core creada para practicar un flujo colaborativo con Git, GitHub y Visual Studio Community 2026. El proyecto usa controladores para separar el trabajo de cada integrante.

## Integrantes

| Integrante | Nombre completo | Usuario GitHub | Rama personal |
| --- | --- | --- | --- |
| 1 | Tomas Gonzalez Zapata | [@tomasgonzalez0](https://github.com/tomasgonzalez0) | `tomas-gonzalez` |
| 2 | Daniel Felipe Marin Marin | [@dazzml](https://github.com/dazzml) | `daniel-marin` |
| 3 | Carolina Arango Escobar | [@caro-a21](https://github.com/caro-a21) | `carolina-arango` |
| 4 | Carla Juliana Giraldo Camacho | [@carlagiraldo09](https://github.com/carlagiraldo09) | `carla-giraldo` |
| 5 | Samuel Cristobal Cuello Duque | [@samuelcuello05](https://github.com/samuelcuello05) | `samuel-cuello` |

## Ejecutar la API

```powershell
dotnet run --project TeamGitPractice.csproj
```

La API base queda preparada para recibir controladores en la fase 4.

## Endpoints planificados

| Responsable | Controlador | Endpoint principal | Segundo endpoint |
| --- | --- | --- | --- |
| Tomas Gonzalez Zapata | `StatusController` | `GET /api/status` | `GET /api/status/team` |
| Daniel Felipe Marin Marin | `MembersController` | `GET /api/members` | `GET /api/members/count` |
| Carolina Arango Escobar | `VersionController` | `GET /api/version` | `GET /api/version/platform` |
| Carla Juliana Giraldo Camacho | `HealthController` | `GET /api/health` | `GET /api/health/time` |
| Samuel Cristobal Cuello Duque | `InfoController` | `GET /api/info` | `GET /api/info/tools` |

## Inicio de la fase 3

Cada integrante debe actualizar `main` y crear su rama personal con el nombre registrado en la tabla anterior. No se deben realizar commits directos en `main` después del commit inicial.
