class Program
{
    public static void Main()
    {
        try
        {

            int accion = 0;
            List<Mensaje> mensagesGuardados = new List<Mensaje>();
            do
            {
                Console.WriteLine("\n\nMenu\n");
                Console.WriteLine("1.- Dar de ALTA un mensaje");
                Console.WriteLine("2.- LISTAR los mensajes");
                Console.WriteLine("0.- SALIR");
                Console.Write("\n\nEscoge opción (1,2,0) > ");
                string? resposta = Console.ReadLine() ?? "";
                if (!int.TryParse(resposta, out accion) || accion < 0 || accion > 2)
                {
                    Console.WriteLine("La opción ha de ser 1, 2 o 0");
                    continue;
                }
                if (accion == 0)
                    break;

                switch (accion)
                {
                    case 1:
                        Console.Write("\n\nInserta el mensaje > ");
                        string? rMensaje = Console.ReadLine() ?? "";
                        if (rMensaje != null)
                        {
                            rMensaje = rMensaje.Trim();
                            if (rMensaje.Length >= 5 && rMensaje.Length <= 500)
                            {
                                mensagesGuardados.Add(new Mensaje(mensagesGuardados.Count + 1, rMensaje, new AnalisisMensaje()));
                            }
                            else
                            {
                                Console.WriteLine("El largo del mensaje debe estar entre 5 y 500 caracteres");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Se ha producido un error al insertar el mensaje");
                        }
                        break;
                    case 2:
                        if(mensagesGuardados.Count >0)
                        {
                            foreach (var m in mensagesGuardados)
                            {
                                Console.WriteLine($"Id: {m.Id}, Texto: {m.Texto}");
                            }
                        }
                        else
                        {
                            Console.WriteLine("No hay mensajes guardados");
                        }                

                        break;
                }

            } while (true);
        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }
}

