const string nombreComercio = "KIOSCO EL RECREO";

Console.WriteLine($"=== {nombreComercio} ===");
Console.Write("Nombre del cajero: ");
string nombreCajero = Console.ReadLine();

Console.WriteLine($"Bienvenida, {nombreCajero}. Caja abierta. ");

Console.Write("Nombre del producto: ");
string nombreProducto = Console.ReadLine();

Console.Write("Precio del producto: $");
decimal precioProducto = decimal.Parse(Console.ReadLine());

Console.WriteLine($"Producto cargado: {nombreProducto} - Precio ${precioProducto}");

Console.ReadLine();

