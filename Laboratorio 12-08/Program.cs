using Laboratorio_12_08;

Clientes clientes = new Clientes(null, null, 0);
ClientesVIP clientesVip = new ClientesVIP(null, null, 0, 0.2);
bool menuPrincipal = true;

while (menuPrincipal)
{
    try
    {
        bool menuClientes = true;
        bool menuMostrar = true;
        clientesVip.MenuPrincipal(); int opcionMenuPrincipal = Convert.ToInt32(Console.ReadLine());

        switch (opcionMenuPrincipal)
        {
            case 1:
                while (menuClientes)
                {
                    try
                    {
                        clientesVip.MenuClientes(); int opcionClientes = Convert.ToInt32(Console.ReadLine());
                        switch (opcionClientes)
                        {
                            case 1:
                                clientes.IngresarClienteRegular();
                            break;

                            case 2:
                                clientesVip.IngresarCLienteVip();
                            break;

                            case 3:
                                menuClientes = false;
                            break;

                            default:
                                Console.WriteLine("");
                                Console.WriteLine($"La opción {opcionClientes} no está dentro del menú");
                                Console.ReadKey();
                            break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Error de formato.");
                        Console.ReadKey();
                    }
                }
            break;

            case 2:

            break;

            case 3:
                while (menuMostrar)
                {
                    try
                    {
                        clientesVip.MenuMostrar(); int opcionMenuMostrar = Convert.ToInt32(Console.ReadLine());
                        switch (opcionMenuMostrar)
                        {
                            case 1:
                                clientes.MostrarClientesRegulares();
                                clientesVip.MostrarClientesVip();
                            break;

                            case 2:
                                break;

                            case 3:
                                menuMostrar = false;
                            break;

                            default:
                                Console.WriteLine("");
                                Console.WriteLine($"La opción {opcionMenuPrincipal} no está dentro del menú");
                                Console.ReadKey();
                            break;
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Error de formato.");
                        Console.ReadKey();
                    }
                }
            break;

            case 4:
                clientesVip.BuscarCLiente();
            break;

            case 5:
                menuPrincipal = false;
                Console.WriteLine("");
                Console.WriteLine("Vuelva pronto.");
                Console.ReadKey();
            break;

            default:
                Console.WriteLine("");
                Console.WriteLine($"La opción {opcionMenuPrincipal} no está dentro del menú");
                Console.ReadKey();
            break;


        }
    }
    catch(FormatException ex)
    {
        Console.WriteLine("");
        Console.WriteLine("Error de formato.");
        Console.ReadKey();
    }
}