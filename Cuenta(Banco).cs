using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Cuenta
    {
        private int nroCuenta;
        private string nombreUsuario;
        private int tipoCuenta;
        private DateTime fechaApertura;
        private double saldo;

        public Cuenta()
        {

        }
        public static void Presentacion1 ()
        {
            System.Console.WriteLine("Dindi");
        }

        public Cuenta(int nroCuenta, string nombreUsuario, int tipoCuenta, DateTime fechaApertura, double saldo)
        {
            this.nroCuenta = nroCuenta;
            this.nombreUsuario = nombreUsuario;
            this.tipoCuenta = tipoCuenta;
            this.fechaApertura = fechaApertura;
            this.saldo = saldo;
        }

        public int NroCuenta { get => nroCuenta; set => nroCuenta = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public int TipoCuenta { get => tipoCuenta; set => tipoCuenta = value; }
        public DateTime FechaApertura { get => fechaApertura; set => fechaApertura = value; }
        public double Saldo { get => saldo; set => saldo = value; }

        public void AgregarUsuario()
        {
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("        **AGREGAR USUARIO**        ");
            Console.Write("\tNumero de cuenta: ");
            NroCuenta = int.Parse(Console.ReadLine());

            Console.Write("\tNombres: ");
            NombreUsuario = Console.ReadLine();

            Console.Write("\tTipo de cuenta:  1.Ahorros     2.Corriente ");
            TipoCuenta = int.Parse(Console.ReadLine());

            FechaApertura = DateTime.Now;
            Console.Write($"\tFecha de apertura: {FechaApertura}\n");

            Console.Write("\tSaldo: $0\n");
            Console.WriteLine("-------------------------------------");
        }

        public void Imprimirusuario()
        {
            Console.WriteLine("_______________");
            Console.WriteLine("         **DATOS DEL USUARIO**         ");
            Console.WriteLine($"\tNumero de cuenta: {NroCuenta}");
            Console.WriteLine($"\tNombre: {NombreUsuario}");
            Console.WriteLine($"\tTipo de cuenta: {TipoCuenta}");
            Console.WriteLine($"\tFecha de apertura: {FechaApertura}");
            Console.WriteLine($"\tSaldo: {Saldo}");
            Console.WriteLine("_______________\n");


        }   

        public double Retirar(double valorRetiro)
        {

            if (valorRetiro >= saldo)
            {
                Console.WriteLine("\tERROR");
            }
            else
            {
                saldo = saldo - valorRetiro;

                Console.WriteLine($"\tTu nuevo saldo es: {saldo}");
            }
            return saldo;
        }
        public double Consignar(double valorConsigna)
        {
            if (valorConsigna < 0)
            {
                Console.WriteLine("ERROR");
            }
            else
            {
                saldo = saldo + valorConsigna;
                Console.WriteLine($"\tTu nuevo saldo es: {saldo}");
            }
            return saldo;
        }
        public double Consulta()
        {
            Console.WriteLine($"\t Tu saldo es: {saldo}");
            return saldo;
        }

        public void Recibo()
        {
            Console.WriteLine("_______________");
            Console.WriteLine("         **RECIBO**         ");
            Console.WriteLine($"\tNumero de cuenta: {NroCuenta}");
            Console.WriteLine($"\tNombre: {NombreUsuario}");
            Console.WriteLine($"\tTipo de cuenta: {TipoCuenta}");
            Console.WriteLine($"\tSaldo: {Saldo}");
            Console.WriteLine("_______________\n");
        }
    }
}

