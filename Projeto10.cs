using System;


namespace projeto10 //*nome do projeto  *//
{
    class Program
    {
        static void Main(string[] args)
        {
            string repete; //*criando a variavel repete*//
            do
            {
                Console.Write("Entre com o número: "); //* Escreve  para entrar com o numero *//
                string textoTela = Console.ReadLine();//*Armazena o numero na variavel textoTela*//
                string extenso = string.Empty;//*cria a variavel com o valor vazio *//
                string textoAux = ("000000" + textoTela).Substring(textoTela.Length);/*remove os numeros deixando apenas 6 casas ou completa com zeros */

                extenso = ProcessarCentenaMilhar(textoAux);/*chama o metodo de processamento que retorno o num extenso armazenado na variavel  */

                Console.WriteLine(extenso);
                Console.WriteLine("digite \"S\" para repetir");
                repete = Console.ReadLine();
            } while (repete.ToUpper() == "S");
        }

        private static string ProcessarCentenaMilhar(string texto) /*metodo criado para processar centenademilhar */
        {
            string extenso;
            string centenaMilhar = texto.Substring(0, 3);/*pega os 3 primeiros numeros das 6 posições*/
            string centena = texto.Substring(3, 3);/*pega os 3 ultimos numeros das 6 posições*/
            if (centenaMilhar == "000")/*Verifica se os 3 numeros da variavel centenaMilhar são 000*/
            {
                extenso = ProcessarCentena(centena);/*Metodo que processa o numero digitado  */
            }
            else if (centena == "000")
            {
                extenso = ProcessarCentena(centenaMilhar) + " mil"; //*Verifica se os 3 numeros da variavel centena são 000*//
            }
            else
            {
                extenso = ProcessarCentena(centenaMilhar) + " mil e " + ProcessarCentena(centena); //*Caso tenha numeros digitados na milhar e centena processa os 2 pq é uma milhar*//
            }
            return extenso;
        }

        private static string ProcessarCentena(string texto)/*criando o metodo processarCentena*/
        {
            string extensoCentena;/*criando a variavel*/
            string centena = texto.Substring(0, 1);/* separa  a centena em uma variavel*/
            string dezena = texto.Substring(1, 2);/*separa  a dezena em uma variavel*/

            switch (centena) /*verifica a centena para escrever seu extenso e processar a dezena final*/
            {
                case "0":
                    extensoCentena = ProcessarDezena(dezena);
                    break;
                case "1":
                    extensoCentena = centena == "00" ? "cem" : "cento e " + ProcessarDezena(dezena);
                    break;
                case "2":
                    extensoCentena = dezena == "00" ? "duzentos" : "duzentos e " + ProcessarDezena(dezena); break;
                case "3":
                    extensoCentena = dezena == "00" ? "trezentos" : "trezentos e " + ProcessarDezena(dezena); break;
                case "4":
                    extensoCentena = dezena == "00" ? "quatrocentos" : "quatrocentos e " + ProcessarDezena(dezena); break;
                case "5":
                    extensoCentena = dezena == "00" ? "quinhentos" : "quinhentos e " + ProcessarDezena(dezena); break;
                case "6":
                    extensoCentena = dezena == "00" ? "seisentos" : "seisentos e " + ProcessarDezena(dezena); break;
                case "7":
                    extensoCentena = dezena == "00" ? "setecentos" : "setecentos e " + ProcessarDezena(dezena); break;
                case "8":
                    extensoCentena = dezena == "00" ? "oitocentos" : "oitocentos e " + ProcessarDezena(dezena); break;
                case "9":
                    extensoCentena = dezena == "00" ? "novecentos" : "novecentos e " + ProcessarDezena(dezena); break;
                default:
                    extensoCentena = ("não é número!");
                    break;
            }
            return extensoCentena;
        }

        private static string ProcessarDezena(string texto)/*criando o metodo processarDezena*/
        {
            string extenso;
            string dezena = texto.Substring(0, 1);/*separa qual a dezena do numero*/
            string unidade = texto.Substring(1, 1);/*separa a unidade*/
            switch (dezena)/*verifica qual a dezena para escrever seu extenso e processa a unidade final*/
            {
                case "0":
                    extenso = ProcessarUnidade(unidade);/*se extenso for igual ProcessarUnidade ==processa unidade*/
                    break;
                case "1":
                    extenso = ProcessarDezeNa(texto);/**se extenso for igual ProcessarDezena ==processa dezena*/
                    break;
                case "2":
                    extenso = unidade == "0" ? "vinte" : "vinte e " + ProcessarUnidade(unidade);
                    break;
                case "3":
                    extenso = unidade == "0" ? "trinta" : "trinta e " + ProcessarUnidade(unidade);
                    break;
                case "4":
                    extenso = unidade == "0" ? "quarenta" : "quarenta e " + ProcessarUnidade(unidade);
                    break;
                case "5":
                    extenso = unidade == "0" ? "cinquenta" : "cinquenta e " + ProcessarUnidade(unidade);
                    break;
                case "6":
                    extenso = unidade == "0 " ? "sessenta" : "sessenta e " + ProcessarUnidade(unidade);
                    break;
                case "7":
                    extenso = unidade == "0" ? "setenta" : "setenta e " + ProcessarUnidade(unidade);
                    break;
                case "8":
                    extenso = unidade == "0" ? "oitenta" : "oitenta e " + ProcessarUnidade(unidade);
                    break;
                case "9":
                    extenso = unidade == "0" ? "noventa" : "noventa e " + ProcessarUnidade(unidade);
                    break;
                default:
                    extenso = ("não é número!");
                    break;
            }
            return extenso;
        }

        private static string ProcessarUnidade(string texto)/*criando o metodo processarUnidade*/
        {
            string extensoUnidade;/*verifica qual a unidde para escrever seu extenso*/
            switch (texto) /*/*verifica a unidade para escrever seu extenso e processar a unidade final*/
            {
                case "0":
                    extensoUnidade = "zero";
                    break;
                case "1":
                    extensoUnidade = ("um");
                    break;
                case "2":
                    extensoUnidade = ("dois");
                    break;
                case "3":
                    extensoUnidade = ("tres");
                    break;
                case "4":
                    extensoUnidade = ("quatro");
                    break;
                case "5":
                    extensoUnidade = ("cinco");
                    break;
                case "6":
                    extensoUnidade = ("seis");
                    break;
                case "7":
                    extensoUnidade = ("sete");
                    break;
                case "8":
                    extensoUnidade = ("oito");
                    break;
                case "9":
                    extensoUnidade = ("nove");
                    break;
                default:
                    extensoUnidade = ("não é número!");
                    break;
            }
            return extensoUnidade;
        }

        private static string ProcessarDezeNa(string texto)
        {
            string extensoDezena;/*verifica qual a dexena para escrever seu extenso*/
            switch (texto)/*/*verifica a dezena para escrever seu extenso e processar a dezena final*/
            {
                case "10":
                    extensoDezena = ("dez");
                    break;
                case "11":
                    extensoDezena = ("onze");
                    break;
                case "12":
                    extensoDezena = ("doze");
                    break;
                case "13":
                    extensoDezena = ("treze");
                    break;
                case "14":
                    extensoDezena = ("catorze");
                    break;
                case "15":
                    extensoDezena = ("quize");
                    break;
                case "16":
                    extensoDezena = ("dezeseis");
                    break;
                case "17":
                    extensoDezena = ("dezesete");
                    break;
                case "18":
                    extensoDezena = ("dezeoito");
                    break;
                case "19":
                    extensoDezena = ("dezenove");
                    break;
                default:
                    extensoDezena = ("não é número!");
                    break;
            }
            return extensoDezena;
        }
    }
}
