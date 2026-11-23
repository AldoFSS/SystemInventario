
# Historial de versiones

## v1.0.0 - Primera liberación

- Primera versión funcional del Sistema de Inventario.
- Implementación de la clase Producto.
- Registro de código, nombre, precio y existencia.
- Visualización de información del producto.
- Implementación de siete pruebas automatizadas con xUnit.
- Generación de ejecutable para Windows x64.
- Publicación exitosa mediante GitHub Actions.

## v1.0.1 - Liberación fallida

- Se introdujo intencionalmente un error en MostrarInformacion().
- El sistema mostró "Producto desconocido".
- Las pruebas CP03, CP06 y CP07 detectaron el problema.
- Resultado: 4 pruebas correctas y 3 fallidas.
- GitHub Actions detuvo el proceso de liberación.
- La versión no se publicó como Release.

## v1.0.2 - Versión corregida

- Corrección del método MostrarInformacion().
- Recuperación de la visualización correcta del nombre.
- Validación satisfactoria de las siete pruebas.
- Integración de la corrección mediante Pull Request #2.
- Generación automática del paquete de distribución.
- Publicación exitosa de la versión corregida.
