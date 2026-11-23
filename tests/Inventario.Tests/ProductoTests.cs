
using System;
using System.Globalization;
using System.IO;
using Xunit;

public class ProductoTests
{
    // Captura la salida del método MostrarInformacion().
    private static string ObtenerInformacion(Producto producto)
    {
        using var salida = new StringWriter();
        TextWriter salidaOriginal = Console.Out;

        try
        {
            Console.SetOut(salida);
            producto.MostrarInformacion();
        }
        finally
        {
            Console.SetOut(salidaOriginal);
        }

        return salida.ToString();
    }

    [Fact]
    public void CP01_CrearProducto()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        Assert.NotNull(producto);
    }

    [Fact]
    public void CP02_VerificarCodigo()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        string informacion = ObtenerInformacion(producto);

        Assert.Contains("Código: P001", informacion);
    }

    [Fact]
    public void CP03_VerificarNombre()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        string informacion = ObtenerInformacion(producto);

        Assert.Contains("Nombre: Teclado", informacion);
    }

    [Fact]
    public void CP04_VerificarPrecio()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        string informacion = ObtenerInformacion(producto);

        // La salida utiliza formato de moneda.
        string precioEsperado = 350m.ToString("C", CultureInfo.CurrentCulture);

        Assert.Contains($"Precio: {precioEsperado}", informacion);
    }

    [Fact]
    public void CP05_VerificarExistencia()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        string informacion = ObtenerInformacion(producto);

        Assert.Contains("Cantidad en inventario: 10", informacion);
    }

    [Fact]
    public void CP06_MostrarInformacionCompleta()
    {
        var producto = new Producto("P001", "Teclado", 350m, 10);

        string informacion = ObtenerInformacion(producto);
        string precioEsperado = 350m.ToString("C", CultureInfo.CurrentCulture);

        Assert.Contains("Código: P001", informacion);
        Assert.Contains("Nombre: Teclado", informacion);
        Assert.Contains($"Precio: {precioEsperado}", informacion);
        Assert.Contains("Cantidad en inventario: 10", informacion);
    }

    [Fact]
    public void CP07_CrearSegundoProducto()
    {
        var primero = new Producto("P001", "Teclado", 350m, 10);
        var segundo = new Producto("P002", "Mouse", 180m, 5);

        string informacionPrimero = ObtenerInformacion(primero);
        string informacionSegundo = ObtenerInformacion(segundo);

        Assert.Contains("Código: P001", informacionPrimero);
        Assert.Contains("Nombre: Teclado", informacionPrimero);

        Assert.Contains("Código: P002", informacionSegundo);
        Assert.Contains("Nombre: Mouse", informacionSegundo);
        Assert.Contains("Cantidad en inventario: 5", informacionSegundo);

        string precioEsperado = 180m.ToString("C", CultureInfo.CurrentCulture);
        Assert.Contains($"Precio: {precioEsperado}", informacionSegundo);

        Assert.DoesNotContain("Código: P001", informacionSegundo);
    }
}
