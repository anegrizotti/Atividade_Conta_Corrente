using System;

namespace Atividade_Conta_Corrente.ConsoleApp
{
    public class Conta_Corrente
    {
        public int numero;
        public double saldo;
        public bool ehEspecial;
        public double limite;
        public int posExtrato;

        public Movimentacao[] movimentacoesRealizadas;

        public void Sacar(double valorSaque)
        {

            if(valorSaque > saldo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo insuficiente!");
                Console.ResetColor();
                Console.WriteLine();
            } else
            {
                Movimentacao movimentacao = new Movimentacao();
                movimentacao.valor = valorSaque;
                movimentacao.debitoOuCredito = "Débito";
                movimentacao.data = DateTime.Now;
                movimentacoesRealizadas[posExtrato] = movimentacao;
                saldo = saldo - valorSaque;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Saque efetuado!");
                Console.ResetColor();
                Console.WriteLine();
                posExtrato++;

            }
        }

        public void Depositar(double valorDeposito)
        {
            Movimentacao movimentacao = new Movimentacao();
            movimentacao.valor = valorDeposito;
            movimentacao.debitoOuCredito = "Débito";
            movimentacao.data = DateTime.Now;
            movimentacoesRealizadas[posExtrato] = movimentacao;
            saldo = saldo + valorDeposito;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Deposito efetuado!");
            Console.ResetColor();
            Console.WriteLine();
            posExtrato++;
        }

        public double EmitirSaldo()
        {
            return saldo;
        }

        public void Transferir(int conta, double valorTransferencia)
        {
            if (valorTransferencia > saldo)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo insuficiente!");
                Console.ResetColor();
                Console.WriteLine();
            } else
            {
                Movimentacao movimentacao = new Movimentacao();
                movimentacao.valor = valorTransferencia;
                movimentacao.debitoOuCredito = "Débito";
                movimentacao.data = DateTime.Now;
                movimentacoesRealizadas[posExtrato] = movimentacao;
                saldo = saldo - valorTransferencia;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Transferencia realizada para conta " +conta+"!");
                Console.ResetColor();
                Console.WriteLine();
                posExtrato++;
            }
        }

        public void EmitirExtrato()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Movimentações realizadas: ");
            Console.ResetColor();

            for (int i = 0; i < movimentacoesRealizadas.Length; i++)
            {
                if (movimentacoesRealizadas[i] == null)
                {
                    continue;
                } else
                {
                    Console.WriteLine("Valor movimentado: " + movimentacoesRealizadas[i].valor);
                    Console.WriteLine("Tipo movimentado: " + movimentacoesRealizadas[i].debitoOuCredito);
                    Console.WriteLine("Data da movimentação: " + movimentacoesRealizadas[i].data);
;                }

                Console.WriteLine();
            }

        }

    }


}
