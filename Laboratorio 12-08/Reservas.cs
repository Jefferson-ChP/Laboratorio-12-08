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
        public int NumeroReserva {  get; set; }
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
        public List<Reservas> listaPlatos = new List<Reservas>();
        public string NombrePlato {  get; set; }
        public double PrecioPlato {  get; set; }

        public Platos(int numeroReserva, int fecha, int hora, string nombrePlato, double precioPlato) : base(numeroReserva, fecha, hora)
        {
            NombrePlato = nombrePlato;
            PrecioPlato = precioPlato;
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

                listaReservas.Add(new Platos(numeroReserva, fecha, hora, null, 0));

                Console.Write("Ingrese la cantidad de platos que desea: "); int cantidadPlatos = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("El número de reserva ingresado ya existe.");
                Console.ReadKey();
            }
        }
    }
}
