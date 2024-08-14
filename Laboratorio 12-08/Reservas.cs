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
        List<Reservas> listaReservas = new List<Reservas>();
        public int NumeroReserva {  get; set; }
        public DateOnly Fecha { get; set; }
        public DateTime Hora { get; set; }

        public Reservas(int numeroReserva, DateOnly fecha, DateTime hora)
        {
            NumeroReserva = numeroReserva;
            Fecha = fecha;
            Hora = hora;
        }

        public void HacerReserva()
        {
            Console.Clear();
            Console.Write("Ingrese el número de la reserva: "); int numeroReserva = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Reservas buscarRepetidos = listaReservas.Find(a => a.NumeroReserva == numeroReserva);

            if (buscarRepetidos == null)
            {
                Console.Write("Ingrese la fecha de la reserva: "); DateOnly fecha = DateOnly.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.Write("Ingrese la hora de la reserva: "); DateTime hora = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("Se ha hecho la reserva correctamente.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("El número de reserva ingresado ya existe.");
                Console.ReadKey();
            }
        }
    }
}
