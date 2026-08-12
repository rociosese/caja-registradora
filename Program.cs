using System.Diagnostics;

const string nombreComercio = "KIOSCO EL RECREO";

Console.WriteLine($"=== {nombreComercio} ===");

decimal total = 0;
int cantidadProductos = 0;

Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta. ");

int opcion;
do {
    Console.WriteLine("¿Qué desea hacer?");
    Console.WriteLine("1. Cargar producto");
    Console.WriteLine("2. Cerrar la venta");
    Console.Write("Opción: ");
    opcion = int.Parse(Console.ReadLine());

switch (opcion)
    {  case 1:
            Console.Write("Nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.Write("Precio del producto: $");
            decimal precioProducto = decimal.Parse(Console.ReadLine());

            total = total + precioProducto;
            cantidadProductos = cantidadProductos + 1;

            Console.WriteLine($"Producto cargado: {nombreProducto} - Precio ${precioProducto}");
            break;

        case 2:
            Console.WriteLine($"Cantidad de productos: {cantidadProductos}");
            Console.WriteLine($"Total de la venta: ${total}");
            break;

        default:
            Console.WriteLine("Opción invalida");
            break;
    }
}
while (opcion != 2);


Console.ReadLine();

