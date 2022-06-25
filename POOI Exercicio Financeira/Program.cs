﻿/*
 * 
 * 1) Uma Financeira possui clientes pessoa física e pessoa jurídica.
 * A Financeira precisa de um sistema para gerenciar os contratos de financiamento com seus clientes.
 * Os contratos possuem número, nome do contratante, valor do contrato e prazo.

 * Crie uma classe contrato com os atributos idContrato ( Guid ), contratante ( string ), valor ( decimal ) e prazo ( int ).

 * 1.1. ) Herança - Os contratos podem ser contrato de pessoa física e contrato de pessoa jurídica.
 * Os contratos de pessoa física também tem o CPF  e a data de nascimento do contratante.
 * Os contratos de pessoa jurídica possuem o CNPJ e a inscrição estadual da empresa contratante.
 * 
 * Usando o conceito de herança, crie a classe ContratoPessoaFisica herdando da classe Contrato
 * e com os atributos adicionais do Contrato Pessoa Física.
 * Em seguida, crie a classe ContratoPessoaJuridica herdando da classe Contrato e com os atributos adicionais do Contrato Pessoa Jurídica.
 * Implemente as classes necessárias para representar os diferentes contratos da Financeira.

 * 1.2. ) Polimorfismo - O valor da prestação de um contrato é calculado por um método calcularPrestação(),
 * como sendo o valor do contrato dividido pelo prazo. Este método calcularPrestação() existe para todos os Contratos.
 * Entretanto, para os contratos de === pessoa jurídica === existe um adicional de 3 reais no valor de cada prestação e
 * para os contratos de === pessoa física === o valor da prestação também tem um adicional no valor da prestação que deve
 * ser calculado de acordo com a idade do contratante:
 * idade <= 30 tem adicional de 1,00
 * idade <= 40 tem adicional de 2,00
 * idade <= 50 tem adicional de 3,00
 * idade > 50 tem adicional de 4,00
 * Implemente o método calcularPrestacao() na(s) classe(s) necessárias.
 * 
 * 1.3 ) Mais métodos - Todos os contratos devem ter um método exibirInfo() ( que não retorna valor e que não tem parâmetros )
 * para informar o valor do contrato, o prazo e o valor da prestação.
 * Além disso, os contratos de pessoa física devem informar também a idade do contratante.
 *
 *
 * VALIDAR TODAS AS ENTRADAS
 * CRIAR METODO DE VALIDAÇÃO**
 *
 *
 * IDEIA: armazenar todos os contratos em uma lista de objetos.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using POOI_Exercicio_Financeira;


namespace POOI_Exercicio_Financeira
{

    public class Program
    {
         static void Main(string[] args)
        {
            CadastrarContrato cadastrarContrato = new CadastrarContrato();


            Console.WriteLine("\tInicie a Criação do Contrato");
            Console.WriteLine("\t----------------------------");
            Console.WriteLine(" ");

            Console.WriteLine("\tMenu de opções:");
            Console.WriteLine("1.\tPessoa Física");
            Console.WriteLine("2.\tPessoa Juridica");

            int inputMenu = Convert.ToInt32(Console.ReadLine());

            switch (inputMenu)
            {
                case 1:
                    cadastrarContrato.CadastrarContratoPF();
                    break;
                
                case 2:
                    cadastrarContrato.CadastrarContratoPJ();
                    break;

                default:
                    break;

            }
                

        }
    }

}