using System;

namespace Atividade_Conta_Corrente.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Conta 1:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
            Conta_Corrente conta_corrente_01 = new Conta_Corrente();

            conta_corrente_01.numero = 10101010;
            conta_corrente_01.saldo = 1000;
            conta_corrente_01.ehEspecial = true;
            conta_corrente_01.limite = 5000;
            conta_corrente_01.posExtrato = 0;
            conta_corrente_01.movimentacoesRealizadas = new Movimentacao[4];

            conta_corrente_01.Sacar(100);
            conta_corrente_01.Depositar(50);
            conta_corrente_01.Transferir(9383838, 50);
            Console.WriteLine("Saldo da conta: " + conta_corrente_01.EmitirSaldo());
            Console.WriteLine();
            conta_corrente_01.EmitirExtrato();

            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Conta 2:");
            Console.WriteLine("--------------------------------------------------------------");
            Console.ResetColor();
            Conta_Corrente conta_corrente_02 = new Conta_Corrente();

            conta_corrente_02.numero = 10101010;
            conta_corrente_02.saldo = 1000;
            conta_corrente_02.ehEspecial = true;
            conta_corrente_02.limite = 5000;
            conta_corrente_02.posExtrato = 0;
            conta_corrente_02.movimentacoesRealizadas = new Movimentacao[4];

            conta_corrente_02.Sacar(100);
            conta_corrente_02.Sacar(50);
            conta_corrente_02.Transferir(9383838, 50);
            Console.WriteLine("Saldo da conta: " + conta_corrente_01.EmitirSaldo());
            Console.WriteLine();
            conta_corrente_02.EmitirExtrato();

        }
    }

}
