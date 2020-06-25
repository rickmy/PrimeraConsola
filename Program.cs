using System;

namespace ConsolaApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //condicion para a mostrar lo que se encuentra dentro del array

            if (args.Length>0)
            {
                Console.WriteLine("Bienvenido Inge Tenga un buen dia :D");
            }


            //variables usadas para recojer datos del usuario
            string nombres;
            string apellidos;
            string correo;
            int clave;

            //metodo para poder validar que se ingrese un valor
            bool validarDatos(string datos)
            {
                if (datos != null )
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine("---------------------------Bienvenido a la ventana de Registro-------------------------------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine(" ");
            Console.WriteLine("Por favor ingrese todos los siguientes datos solicitados:");
            Console.WriteLine(" ");
            Console.Write("Ingresa tus Nombres: ");
            nombres = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Ingresa tus Apellidos: ");
            apellidos = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Escriba su mail: ");
            correo = Console.ReadLine();
            Console.WriteLine(" ");
            Console.Write("Ingrese su contraseña: ");
            Console.ForegroundColor = ConsoleColor.Black;
            clave = Console.Read();
            Console.WriteLine(" ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Presione cualquier tecla para registrase");
            Console.ReadKey();
            if (validarDatos(nombres)== true && validarDatos(apellidos)
                && validarDatos(correo)==true)
            {
                Console.WriteLine("Se registro correctamente");
                Console.ReadKey();
            } else
            {
                Console.WriteLine("Los datos ingresados no son correcto vuelva intentar mas tarde");
                Console.ReadKey();
            }
        }
    }
}
