using System;
using System.Linq;
using ViajecitosSAClienteConsola.CondorService;

namespace ViajecitosSAClienteConsola
{
    class Program
    {
        static CondorServiceSoapClient client = new CondorServiceSoapClient();
        static int usuarioId = 1; // Puedes pedir esto luego del login

        static void Main(string[] args)
        {
            Console.Title = "Viajecitos SA - Cliente Consola";
            MostrarMenu();
        }

        static void MostrarMenu()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("✈️  Bienvenido a Viajecitos SA");
                Console.WriteLine("1. Iniciar sesión");
                Console.WriteLine("2. Listar vuelos");
                Console.WriteLine("3. Buscar vuelos");
                Console.WriteLine("4. Comprar vuelo");
                Console.WriteLine("5. Ver factura");
                Console.WriteLine("6. Salir");
                Console.Write("Seleccione una opción: ");

                var opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Login();
                        break;
                    case "2":
                        ListarVuelosConFiltros();
                        break;
                    case "3":
                        BuscarVuelos();
                        break;
                    case "4":
                        ComprarVuelo();
                        break;
                    case "5":
                        VerFactura();
                        break;
                    case "6":
                        return;
                    default:
                        Console.WriteLine("Opción inválida. Presione una tecla para continuar.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        static void Login()
        {
            Console.Clear();
            Console.WriteLine("=== INICIAR SESIÓN ===");
            Console.Write("Usuario: ");
            var username = Console.ReadLine();
            Console.Write("Contraseña: ");
            var password = Console.ReadLine();

            var resultado = client.Login(username, password);
            Console.WriteLine("\n" + resultado);
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void ListarVuelosConFiltros()
        {
            Console.Clear();
            Console.WriteLine("=== LISTAR VUELOS CON FILTROS ===");
            Console.WriteLine("Seleccione el tipo de filtro:");
            Console.WriteLine("1. Ciudad de origen");
            Console.WriteLine("2. Ciudad de destino");
            Console.Write("Opción: ");
            var opcionFiltro = Console.ReadLine();

            string tipoFiltro = "";
            string valorFiltro = "";

            switch (opcionFiltro)
            {
                case "1":
                    tipoFiltro = "origen";
                    Console.Write("Ingrese la ciudad de origen (ej. UIO): ");
                    valorFiltro = Console.ReadLine().ToUpper();
                    break;

                case "2":
                    tipoFiltro = "destino";
                    Console.Write("Ingrese la ciudad de destino (ej. GYE): ");
                    valorFiltro = Console.ReadLine().ToUpper();
                    break;

                default:
                    Console.WriteLine("❌ Opción inválida.");
                    Console.WriteLine("Presione una tecla para continuar...");
                    Console.ReadKey();
                    return;
            }

            // Llama al método correcto del servicio
            Vuelo[] vuelos = client.ObtenerVuelosPorFiltro(tipoFiltro, valorFiltro);

            if (vuelos == null || vuelos.Length == 0)
            {
                Console.WriteLine("\n❌ No se encontraron vuelos.");
            }
            else
            {
                Console.WriteLine($"\n🛫 Se encontraron {vuelos.Length} vuelo(s):");
                foreach (var vuelo in vuelos)
                {
                    Console.WriteLine($"ID: {vuelo.Id} | {vuelo.CiudadOrigen} -> {vuelo.CiudadDestino} | Hora: {vuelo.HoraSalida} | Valor: ${vuelo.Valor}");
                }
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void BuscarVuelos()
        {
            Console.Clear();
            Console.WriteLine("=== BUSCAR VUELOS ===");
            Console.Write("Ciudad Origen (ej. UIO): ");
            var origen = Console.ReadLine().ToUpper();
            Console.Write("Ciudad Destino (ej. GYE): ");
            var destino = Console.ReadLine().ToUpper();
            Console.Write("Fecha de viaje (yyyy-mm-dd): ");
            var fecha = Console.ReadLine(); // no se usa en la búsqueda actual

            var vuelos = client.ObtenerVuelos(origen, destino);

            if (vuelos == null || vuelos.Length == 0)
            {
                Console.WriteLine("\n❌ Vuelo no disponible");
            }
            else
            {
                var vueloMayor = vuelos.OrderByDescending(v => v.Valor).First();
                Console.WriteLine("\n🛫 Vuelo más caro disponible:");
                Console.WriteLine($"ID: {vueloMayor.Id}");
                Console.WriteLine($"De: {vueloMayor.CiudadOrigen} a {vueloMayor.CiudadDestino}");
                Console.WriteLine($"Hora de salida: {vueloMayor.HoraSalida}");
                Console.WriteLine($"Precio: ${vueloMayor.Valor}");
            }

            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

        static void ComprarVuelo()
        {
            Console.Clear();
            Console.WriteLine("=== COMPRAR VUELO ===");

            Console.Write("Ingrese el ID del vuelo que desea comprar: ");
            if (!int.TryParse(Console.ReadLine(), out int vueloId))
            {
                Console.WriteLine("ID de vuelo inválido.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                return;
            }

            Console.Write("Ingrese la cantidad de boletos a comprar: ");
            if (!int.TryParse(Console.ReadLine(), out int cantidad) || cantidad <= 0)
            {
                Console.WriteLine("Cantidad inválida.");
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
                return;
            }

            // Llamamos al servicio SOAP con la nueva firma que acepta cantidad
            string resultado = client.ComprarVueloConCantidad(vueloId, usuarioId, cantidad);

            Console.WriteLine("\n" + resultado);
            Console.WriteLine("Presione una tecla para continuar...");
            Console.ReadKey();
        }

        static void VerFactura()
        {
            Console.Clear();
            Console.WriteLine("=== VER FACTURA POR ID ===");
            Console.Write("Ingrese el ID de la factura: ");
            if (int.TryParse(Console.ReadLine(), out int facturaId))
            {
                Factura factura = client.ObtenerFacturaPorId(facturaId);
                if (factura != null)
                {
                    Console.WriteLine("\n--- Detalles de la Factura ---");
                    Console.WriteLine($"ID Factura: {factura.Id}");
                    Console.WriteLine($"Usuario: {factura.NombreUsuario} (ID: {factura.UsuarioId})");
                    Console.WriteLine($"Edad: {factura.EdadUsuario}");
                    Console.WriteLine($"Nacionalidad: {factura.NacionalidadUsuario}");
                    Console.WriteLine($"Ciudad Origen: {factura.CiudadOrigen}");
                    Console.WriteLine($"Ciudad Destino: {factura.CiudadDestino}");
                    Console.WriteLine($"Hora Salida: {factura.HoraSalida}");
                    Console.WriteLine($"Cantidad de boletos: {factura.Cantidad}");
                    Console.WriteLine($"Precio Unitario: ${factura.PrecioUnitario:F2}");
                    Console.WriteLine($"Precio Total: ${factura.PrecioTotal:F2}");
                    Console.WriteLine($"Fecha Emisión: {factura.FechaEmision}");
                }
                else
                {
                    Console.WriteLine("Factura no encontrada.");
                }
            }
            else
            {
                Console.WriteLine("ID inválido.");
            }
            Console.WriteLine("\nPresione una tecla para continuar...");
            Console.ReadKey();
        }

    }
}
