using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_admin
{
    class Program
    {
        static void Main(string[] args)
        {

            string login, pasword;
            string usuario = "sysadmin";
            string contrasena = "admin3.0";
            string pregunta;



            for (int k = 0; k < 3; k++)
            {
                Console.WriteLine("Digite su usuario");
                login = Console.ReadLine();

                Console.WriteLine("Digite su contraseña");
                pasword = Console.ReadLine();

                if ((login == usuario) && (pasword == contrasena))
                {

                    Console.WriteLine("Bienvenido, usted es el administrador");
                    break;



                }
                else

                {


                    Console.WriteLine("Datos incorrectos");


                }


            }

            Console.WriteLine("¿ Desea cambiar su contrasena ? si/no");
            pregunta = Console.ReadLine();

            if (pregunta == "si")

            {

                Console.WriteLine("Digite nueva contrasena");
                contrasena = Console.ReadLine();


                for (int i = 0; i < 3; i++)
                {

                    Console.WriteLine("Digite su usuario");
                    login = Console.ReadLine();

                    Console.WriteLine("Digite su contrasena");
                    pasword = Console.ReadLine();


                    if ((login == usuario) && (pasword == contrasena))
                    {

                        Console.WriteLine("Bienvenido");
                        break;


                    }
                    else
                    {
                        Console.WriteLine("Datos incorrectos");
                    }
                    Console.ReadLine();

                }




            }
            else
            {

            }

            Console.ReadLine();



        }
    }
}
