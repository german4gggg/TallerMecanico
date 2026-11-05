using System;
using System.Collections.Generic;

namespace TallerMecanico
{
    
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }
        public int Anio { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            List<Vehiculo> listaVehiculos = new List<Vehiculo>();
            bool continuar = true;

            // Bucle principal del menú
            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("=== TALLER MECÁNICO - GESTIÓN DE VEHÍCULOS ===");
                Console.WriteLine("1. Registrar nuevo vehículo");
                Console.WriteLine("2. Mostrar todos los vehículos y cantidad total");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Vehiculo v = new Vehiculo();

                        Console.Write("Ingrese la Placa: ");
                        v.Placa = Console.ReadLine();

                        Console.Write("Ingrese la Marca: ");
                        v.Marca = Console.ReadLine();

                        Console.Write("Ingrese el Año: ");
                        if (int.TryParse(Console.ReadLine(), out int anio))
                        {
                            v.Anio = anio;
                            listaVehiculos.Add(v); // Guardar en la lista
                            Console.WriteLine("\n¡Vehículo registrado con éxito!");
                        }
                        else
                        {
                            Console.WriteLine("\nAño inválido. Intente nuevamente.");
                        }

                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "2":
                        Console.WriteLine("\n--- LISTA DE VEHÍCULOS EN EL TALLER ---");

                        // Condicional para verificar si hay registros
                        if (listaVehiculos.Count == 0)
                        {
                            Console.WriteLine("No hay vehículos registrados todavía.");
                        }
                        else
                        {
                            // Bucle foreach para mostrar cada vehículo
                            foreach (var vehiculo in listaVehiculos)
                            {
                                Console.WriteLine($"* Placa: {vehiculo.Placa} | Marca: {vehiculo.Marca} | Año: {vehiculo.Anio}");
                            }

                            // Mostrar la cantidad total de vehículos
                            Console.WriteLine($"\nCantidad total de vehículos: {listaVehiculos.Count}");
                        }

                        Console.WriteLine("\nPresione cualquier tecla para continuar...");
                        Console.ReadKey();
                        break;

                    case "3":
                        continuar = false;
                        Console.WriteLine("\nSaliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("\nOpción no válida. Presione una tecla para intentar de nuevo.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}