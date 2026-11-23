public class Producto
{
    private readonly string codigo;
    private readonly string nombre;
    private readonly decimal precio;
    private readonly int cantidad;

    public Producto(string codigo, string nombre, decimal precio, int cantidad)
    {
        this.codigo = codigo;
        this.nombre = nombre;
        this.precio = precio;
        this.cantidad = cantidad;
    }

    public void MostrarInformacion()
    {
        Console.WriteLine($"Código: {codigo}");
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Precio: {precio:C}");
        Console.WriteLine($"Cantidad en inventario: {cantidad}");
    }
}
