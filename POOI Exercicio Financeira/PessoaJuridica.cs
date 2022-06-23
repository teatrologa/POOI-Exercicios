﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOI_Exercicio_Financeira
{
    internal class PessoaJuridica : Contrato
    {
        public string CNPJ { get; set; }

        public string InscricaoEstadual { get; set; }
       

        public override void PrintarContrato()
        {
            base.PrintarContrato();

            Console.WriteLine("Dados do Constratante");
            Console.WriteLine("---------------------");
            Console.WriteLine("Nome: " + Contratante);
            Console.WriteLine("CNPJ: " + CNPJ);
            Console.WriteLine("Inscrição estadual: " + InscricaoEstadual);
            Console.WriteLine("");
            Console.WriteLine("");

            Console.WriteLine("Dados do Contrato");
            Console.WriteLine("-----------------");
            Console.WriteLine("Valor: " + Valor);
            Console.WriteLine("Prazo: " + Prazo);
            Console.WriteLine("ID de Segurança: " + IDContrato);
            Console.WriteLine("");
        }
    }
}
