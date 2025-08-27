# MauiClimaDemo

Pipeline de **pruebas automáticas con GitHub Actions**.

Este proyecto implementa un flujo de integración continua (CI) que incluye:

1. **Clonación del repositorio**
2. **Ejecución de pruebas automatizadas** (unitarias)
3. **Generación de reportes de resultados y cobertura**
4. **Notificaciones** (opcional por Slack o email)

---

## 🛠️ Diseño del pipeline

![Diagrama del pipeline](docs/images/pipeline.png)


---

## 🖼️ Evidencias del pipeline

### ✅ Ejecución exitosa del workflow
![Run Exitoso](docs/images/run_exitoso.png)

### 🧪 Resultados de pruebas
![Resultados de Tests](docs/images/test_results.png)

### 📦 Reporte de cobertura / artifact
![Coverage Artifact](docs/images/coverage_artifact.png)

> Los archivos de reporte se publican como artifact del job (`test-and-coverage-reports`).
> Revisa la pestaña **Actions** → run más reciente → **Artifacts**.

