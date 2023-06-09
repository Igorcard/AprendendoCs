using System;
using System.Collections.Generic;

namespace Banco
{
    public class Cliente
    {
        public string Nome {get; set;}
        public string Documento {get; set;}
        public List<Cartao> Cartoes{get; set;}
        public Conta Conta{get; set;}
        public void Depositar(double valor)
        {
            Conta.Depositar(valor);
        }
        public void Sacar(double valor)
        {
            Conta.Sacar(valor);
        }
        public void Tranferir(double valor, Conta destino)
        {
            Conta.Transferir(valor, destino);
        }
        public void imprimir_extrato()
        {
            Console.WriteLine("Nome Cliente: {0}", Nome);
            Console.WriteLine("Documento Cliente: {0}", Documento);
            Conta.imprimir_extrato();
        }
    }
    

}