# Calculadora de Préstamos en C#

Calculadora de préstamos en C# (aplicación de consola) que calcula la cuota mensual de un préstamo usando el capital, la tasa anual y el plazo en meses. Pensada para prácticas y como ejemplo de validación de entradas y cálculo financiero.

---

## Contenido del proyecto

1. **Calcular cuota mensual**: Permite ingresar capital, tasa anual (%) y meses; devuelve la cuota mensual.
2. **Validación de entrada**: Comprueba que los valores sean numéricos.
3. **Salida formateada**: Muestra resultados con formato numérico legible.
4. **Código sencillo**: Facilita la comprensión y reutilización.

---

## Archivos incluidos

- `CalculadoraPrestamos.csproj`: Archivo de proyecto (.NET 9).
- `Program.cs`: Código fuente de la aplicación de consola.

---

## Compilación y ejecución

Este proyecto usa .NET 9. Para compilar y ejecutar localmente:

1. Asegúrate de tener instalado el SDK de .NET 9.
2. Desde la carpeta del proyecto, compila:

   ```bash
   dotnet build
   ```

## 3. Ejecuta la aplicación:

   ```bash
   dotnet run --project CalculadoraPrestamos.csproj
   ```

O, si prefieres crear el ejecutable:

   ```bash
   dotnet publish -c Release -r win-x64 --self-contained false -o ./publish
   ```

y luego ejecuta el binario resultante `./publish/CalculadoraPrestamos o .\publish\CalculadoraPrestamos.exe`.

---

## Ejemplo de uso

Al ejecutar la aplicación se solicita:

Introduce el capital:  → (ej. 15000).

Introduce la tasa anual (%):  → (ej. 7.5).

Introduce el número de meses:  → (ej. 60).


La salida mostrará capital, tasa, meses y cuota mensual formateados.


---

## Autor

**Alan Aquino**, estudiante de Ingeniería en Informática.


---

## Licencia

Este proyecto se distribuye bajo la licencia MIT. Consulta el archivo LICENSE para más detalles.
