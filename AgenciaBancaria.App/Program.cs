using AgenciaBancaria.Dominio;
using System;

namespace AgenciaBancaria.App
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Endereco endereco = new Endereco("Rua test", "2223344545", "Bangu", "RJ");
                Cliente cliente = new Cliente("Lucas", "2222", "885", endereco);

                ContaCorrente conta = new ContaCorrente(cliente, 100);

                Console.WriteLine("Conta " + conta.Situacao+": " + conta.NumConta + " - " + conta.DigitoVerificador);

                string senha = "abc123";
                conta.Abrir(senha);
                Console.WriteLine("Conta " + conta.Situacao + ": " + conta.NumConta + " - " + conta.DigitoVerificador);

               
                conta.Sacar(10, senha);

                Console.WriteLine("Saldo: "+ conta.Saldo);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            
        }
    }
}
