using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_12_08
{
    public class Reservas
    {
        public int NumeroReserva { get; set; }
        public int Fecha { get; set; }
        public int Hora { get; set; }

        public Reservas(int numeroReserva, int fecha, int hora)
        {
            NumeroReserva = numeroReserva;
            Fecha = fecha;
            Hora = hora;
        }
    }
    public class Platos : Reservas
    {
        public List<Reservas> listaReservas = new List<Reservas>();
        public List<Platos> listaPlatos = new List<Platos>();
        public string NombrePlato { get; set; }
        public double PrecioPlato { get; set; }
        public double Total { get; set; }

        public Platos(int numeroReserva, int fecha, int hora, string nombrePlato, double precioPlato, double total) : base(numeroReserva, fecha, hora)
        {
            NombrePlato = nombrePlato;
            PrecioPlato = precioPlato;
            Total = total;
        }
        public void HacerReserva()
        {
            Console.Clear();
            Console.Write("Ingrese el número de la reserva: "); int numeroReserva = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Reservas buscarRepetidos = listaReservas.Find(a => a.NumeroReserva == numeroReserva);

            if (buscarRepetidos == null)
            {
                Console.Write("Ingrese la fecha de la reserva: "); int fecha = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Ingrese la hora de la reserva: "); int hora = int.Parse(Console.ReadLine());
                Console.WriteLine("");

                listaReservas.Add(new Reservas(numeroReserva, fecha, hora));

                Console.Write("Ingrese la cantidad de platos que desea: "); int cantidadPlatos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
                for (int i = 1; i <= cantidadPlatos; i++)
                {
                    Console.Clear();
                    Console.WriteLine($"PLATO NÚMERO {i}");
                    Console.Write("Ingrese el nombre del plato: "); string nombrePlato = Console.ReadLine();
                    Console.WriteLine("");
                    Console.Write("Ingrese el precio del plato: "); double precioPlato = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("");

                    double total = Total + precioPlato;

                    listaPlatos.Add(new Platos(numeroReserva, fecha, hora, nombrePlato, precioPlato, total));

                    Console.WriteLine("Plato registrado.");
                    Console.ReadKey();
                }

                Console.WriteLine("La reserva se ha realizado con éxito.");
            }
            else
            {
                Console.WriteLine("El número de reserva ingresado ya existe.");
                Console.ReadKey();
            }
        }

        public void MostrarReservas()
        {
            foreach (Reservas reservaciones in listaReservas)
            {
                Console.Clear();
                Console.WriteLine("===================================================\n");
                Console.WriteLine("Número de la reserva: " + reservaciones.NumeroReserva);
                Console.WriteLine("");
                Console.WriteLine("Fecha de la reserva: " + reservaciones.Fecha);
                Console.WriteLine("");
                Console.WriteLine("Hora de la reserva: " + reservaciones.Hora);
                Console.WriteLine("");
                Console.WriteLine("===================================================");
                Console.WriteLine("----------------LISTA DE PLATOS----------------");
                foreach (Platos platillos in listaPlatos)
                {
                    Console.WriteLine(platillos.NombrePlato + "........... " + platillos.PrecioPlato);
                    Console.WriteLine("");
                }
                Console.WriteLine("Total reserva: ");
                Console.WriteLine("===================================================\n");
                Console.WriteLine("Presione cualquier tecla para pasar a la siguiente reserva.");
                Console.ReadKey();
            }
        }

        public void BuscarReservas()
        {
            Console.Clear();
            Console.Write("Ingrese el número de la reserva: "); int numeroReservaBuscar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Platos buscarReservas = listaPlatos.Find(a => a.NumeroReserva == numeroReservaBuscar);

            if (buscarReservas == null )
            {
                    Console.WriteLine("Número de la reserva: " + buscarReservas.NumeroReserva);
                    Console.WriteLine("");
                    Console.WriteLine("Fecha de la reserva: " + buscarReservas.Fecha);
                    Console.WriteLine("");
                    Console.WriteLine("Hora de la reserva: " + buscarReservas.Hora);
                    Console.WriteLine("");
                    Console.WriteLine("===================================================");
                    Console.WriteLine("----------------LISTA DE PLATOS----------------");
                    foreach (Platos platillos in listaPlatos)
                    {
                        Console.WriteLine(buscarReservas.NombrePlato + "........... " + buscarReservas.PrecioPlato);
                        Console.WriteLine("");
                    }
                    Console.WriteLine("===================================================\n");
                    Console.WriteLine("Presione cualquier tecla para pasar a la siguiente reserva.");
                    Console.ReadKey();
            }
        }
    }
} 