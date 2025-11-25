using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendasApp.Models;

namespace VendasApp.Validacoes
{
    public class ValidacaoCliente
    {
        public bool Documento(Cliente cliente)
        {
            if (cliente.Tipodocumento == Models.Enums.TipoDocumentoEnums.Tipodocumento.CPF)
            {

                return Validacpf(cliente.Documento);
            }
            else
            {
               return Validacnpj(cliente.Documento);

            }
        }
        private bool Validacpf(string documento)
        {
            string cpf_digitado = documento.Replace(",","").Replace("-","").Replace(".","").Trim();
            int soma = 0;
            int primeiro_digito = 0;
            int segundo_digito = 0;
            

            int[] multiplicadores = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };

            soma = CalculadigitoCPF(multiplicadores, cpf_digitado);

            primeiro_digito = Calcula_resto(primeiro_digito, soma);


            multiplicadores = new int[] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            soma = 0;
            
            string cpf_concatenado = cpf_digitado.Substring(0, 9) + primeiro_digito.ToString();

            soma = CalculadigitoCPF(multiplicadores, cpf_concatenado);

            segundo_digito = Calcula_resto(segundo_digito, soma);


            return  Valida(cpf_digitado, primeiro_digito, segundo_digito);
            
        }
        private int CalculadigitoCPF(int[] multiplicadores, string cpf_digitado)
        {
            int somaDoMetodo = 0;
            for (int i = 0; i < multiplicadores.Length; i++)
            {
                string cpf_divido = cpf_digitado.Substring(i, 1);
                int digito = Convert.ToInt32(cpf_divido);
                somaDoMetodo += multiplicadores[i] * digito;
            }
            return somaDoMetodo;

        }
        private int Calcula_resto(int digito, int somei)
        {

            int resta = somei % 11;
            if (resta < 2)
            {
                digito = 0;
            }
            else
            {
                digito = 11 - resta;
            }
            return digito;
        }
         

        private  bool Valida(string cpf_digitado, int primeiro_digito, int segundo_digito)
        {


            if (cpf_digitado.Substring(9, 1) == primeiro_digito.ToString() && cpf_digitado.Substring(10, 1) == segundo_digito.ToString())
            {

                return true;
            }
            else
            {
                return false;
            }


        }
        private bool Validacnpj(string cnpj)
        {
            {
                int[] multiplicador1 = new int[12] { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int[] multiplicador2 = new int[13] { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
                int soma;
                int resto;
                string digito;
                string tempCnpj;

                cnpj = cnpj.Trim();
                cnpj = cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Replace(",","");

                if (cnpj.Length != 14)
                    return false;

                tempCnpj = cnpj.Substring(0, 12);

                soma = 0;
                for (int i = 0; i < 12; i++)
                {
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador1[i];
                }
                resto = (soma % 11);
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }

                 digito = resto.ToString();
                
                tempCnpj = tempCnpj + digito;
                soma = 0;
                for (int i = 0; i < 13; i++)
                {
                    soma += int.Parse(tempCnpj[i].ToString()) * multiplicador2[i];
                }
                resto = (soma % 11);
                if (resto < 2)
                {
                    resto = 0;
                }
                else
                {
                    resto = 11 - resto;
                }
                digito = digito + resto.ToString();

                return cnpj.EndsWith(digito);
            }
        }
        
    }




}
