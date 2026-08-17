using System.Diagnostics;

const string nombreComercio = "KIOSCO EL RECREO";

const decimal DESCUENTO_MAYOR = 0.10m;
const decimal DESCUENTO_MENOR = 0.05m;
const decimal DESCUENTO_EFECTIVO = 0.10m;
const decimal RECARGO_CREDITO = 0.15m;

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

decimal descuento = 0;
if (total > 50000)
{
    descuento = total * DESCUENTO_MAYOR;
    Console.WriteLine($"Se aplicó un descuento del 10%: ${descuento}");

}
else if (total > 20000 && total <= 50000)
{
    descuento = total * DESCUENTO_MENOR;
    Console.WriteLine($"Se aplicó un descuento del 5%: ${descuento}");
}
else
{
    Console.WriteLine("No se aplicó descuento.");
}

decimal totalFinal = total - descuento;

int medioPago;
decimal recargo = 0;
decimal descuentoEfectivo = 0;

do
{
    Console.WriteLine("Medio de pago:");
    Console.WriteLine("1. Efectivo");
    Console.WriteLine("2. Débito");
    Console.WriteLine("3. Crédito");
    Console.Write("Opción: ");

    medioPago = int.Parse(Console.ReadLine());

    if (medioPago < 1 || medioPago > 3)
    {
        Console.WriteLine("Opción invalida. Intente nuevamente.");
    }
}
while (medioPago < 1 || medioPago > 3);

switch (medioPago)
{
    case 1:
        descuentoEfectivo = totalFinal * DESCUENTO_EFECTIVO;
        totalFinal -= descuentoEfectivo;
        Console.WriteLine($"Se aplicó un descuento del 10% por pago en efectivo: ${descuentoEfectivo}");
        break;
    case 2:
        Console.WriteLine("No se aplicó recargo ni descuento por pago con débito.");
        break;
    case 3:
        recargo = totalFinal * RECARGO_CREDITO;
        totalFinal += recargo;
        Console.WriteLine($"Se aplicó un recargo del 15% por pago con crédito: ${recargo}");
        break;
}

Console.WriteLine($"Subtotal: ${total}");
Console.WriteLine($"Descuento: ${descuento}");
Console.WriteLine($"Total final: ${totalFinal}");

Console.ReadLine();


