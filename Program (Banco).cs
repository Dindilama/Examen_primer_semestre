using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            double valorConsigna, valorRetiro;
            int opcion = 0;

            

            Cuenta usuario1 = new Cuenta();
            usuario1.presentacion1();
            usuario1.AgregarUsuario();
            usuario1.Imprimirusuario();


            while (opcion != 6)
            {
                Console.WriteLine("Desea \n3.Retirar \n4.Consignar \n5.Consultar su saldo \n6.desea finalizar la operacion\n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 3:
                        Console.Write("Cuanto va a retirar?: ");
                        valorRetiro = double.Parse(Console.ReadLine());

                        usuario1.Retirar(valorRetiro);
                        break;

                    case 4:
                        Console.WriteLine("Cuanta va a consignar?: ");
                        valorConsigna = double.Parse(Console.ReadLine());

                        usuario1.Consignar(valorConsigna);
                        break;

                    case 5:
                        usuario1.Consulta();
                        break;
                    case 6:
                        Console.WriteLine("Desea finalizar?");
                        break;
                }

                usuario1.Recibo();
            }
           

            Console.WriteLine("\nPresione la tecla Enter para finalizar...");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}

