using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio_12_08
{
    public class Clientes
    {
        List<Clientes> listaClientes = new List<Clientes>();
        public string Nombre {  get; set; }
        public string Correo {  get; set; }
        public int NumeroTelefono {  get; set; }

        public Clientes(string nombre, string correo, int numeroTelefono)
        {
            Nombre = nombre;
            Correo = correo;
            NumeroTelefono = numeroTelefono;
        }    
        public void IngresarClienteRegular()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del cliente: "); string nombre = Console.ReadLine();
            Console.WriteLine("");

            Clientes buscarRepetidos = listaClientes.Find(a => a.Nombre == nombre);

            if(buscarRepetidos == null)
            {
                Console.Write("Ingrese el correo del cliente: "); string correo = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Ingrese el número de teléfono del cliente: "); int numeroTelefono = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                listaClientes.Add(new Clientes(nombre, correo, numeroTelefono));

                Console.WriteLine("Cliente registrado correctamente.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El cliente que trata de ingresar ya existe");
                Console.ReadKey();
            }
        }

        public void MostrarClientesRegulares()
        {
            Console.Clear();
            foreach(Clientes clientela in listaClientes)
            {
                Console.Clear();
                Console.WriteLine("=================================================================");
                Console.WriteLine("CLIENTE REGULAR");
                Console.WriteLine("");
                Console.WriteLine("Nombre del cliente: " + clientela.Nombre);
                Console.WriteLine("");
                Console.WriteLine("Correo del cliente: " + clientela.Correo);
                Console.WriteLine("");
                Console.WriteLine("Número de teléfono del ciente: " + clientela.NumeroTelefono);
                Console.WriteLine("=================================================================\n");
                Console.Write("Presione cualquier tecla para pasar al siguiente cliente.");
                Console.ReadKey();
            }
        }

    }
    public class ClientesVIP : Clientes
    {
        List<ClientesVIP> listaClientesVip = new List<ClientesVIP>();
        public double Descuento;

        public ClientesVIP(string nombre, string correo, int numeroTelefono, double descuento) : base(nombre, correo, numeroTelefono)
        {
            Descuento = 0.20;
        }
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("--------------MENU DEL RESTAURANTE--------------");
            Console.WriteLine("1. Ingresar cliente");
            Console.WriteLine("2. Realizar reserva");
            Console.WriteLine("3. Mostrar detalles de clientes o reservas");
            Console.WriteLine("4. Buscar cliente o reserva");
            Console.WriteLine("5. Salir del menú");
            Console.WriteLine("=====================================================");
            Console.Write("Seleccione alguna opción: ");
        }

        public void MenuClientes()
        {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("--------------MENU DE CLIENTES--------------");
            Console.WriteLine("1. Cliente Regular");
            Console.WriteLine("2. Cliente VIP");
            Console.WriteLine("3. Salir del menú");
            Console.WriteLine("=====================================================");
            Console.Write("Seleccione el tipo de cliente: ");
        }

        public void IngresarCLienteVip()
        {
            Console.Clear();
            Console.Write("Ingrese el nombre del cliente: "); string nombre = Console.ReadLine();
            Console.WriteLine("");

            Clientes buscarRepetidos = listaClientesVip.Find(a => a.Nombre == nombre);

            if (buscarRepetidos == null)
            {
                Console.Write("Ingrese el correo del cliente: "); string correo = Console.ReadLine();
                Console.WriteLine("");
                Console.Write("Ingrese el número de teléfono del cliente: "); int numeroTelefono = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                listaClientesVip.Add(new ClientesVIP(nombre, correo, numeroTelefono, 0.2));

                Console.WriteLine("Cliente registrado correctamente.");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("El cliente que trata de ingresar ya existe");
                Console.ReadKey();
            }
        }
        public void MenuMostrar()
        {
            Console.Clear();
            Console.WriteLine("=====================================================");
            Console.WriteLine("--------------MENU DE MUESTRA DE DATOS--------------");
            Console.WriteLine("1. Mostrar Clientes");
            Console.WriteLine("2. Mostrar reservas");
            Console.WriteLine("3. Salir del menú");
            Console.WriteLine("=====================================================");
            Console.Write("Seleccione el dato que desea mostrar: ");
        }
        public void MostrarClientesVip()
        {
            Console.Clear();
            foreach (Clientes clientelaVip in listaClientesVip)
            {
                Console.Clear();
                Console.WriteLine("=================================================================");
                Console.WriteLine("CLIENTE VIP");
                Console.WriteLine("");
                Console.WriteLine("Nombre del cliente: " + clientelaVip.Nombre);
                Console.WriteLine("");
                Console.WriteLine("Correo del cliente: " + clientelaVip.Correo);
                Console.WriteLine("");
                Console.WriteLine("Número de teléfono del ciente: " + clientelaVip.NumeroTelefono);
                Console.WriteLine("");
                Console.WriteLine("Descuento VIP de cliente: 20%");
                Console.WriteLine("=================================================================\n");
                Console.Write("Presione cualquier tecla para pasar al siguiente cliente.");
                Console.ReadKey();
            }
        }
    }
}
