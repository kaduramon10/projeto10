using System;

namespace projeto
{
    class Program
    {
        static void Main()
        {
            string repete;
            do
            {
                Console.Write("Entre com o número: ");
                string textoTela = Console.ReadLine();
                string extenso = string.Empty;
                string textoAux = ("000000" + textoTela).Substring(textoTela.Length);

                extenso = ProcessarCentenaMilhar(textoAux);

                Console.WriteLine(extenso);
                Console.WriteLine("digite \"S\" para repetir");
                repete = Console.ReadLine();
            } while (repete.ToUpper() == "S");
        }

        private static string ProcessarCentenaMilhar(string texto)
        {
            string extenso;
            string centenaMilhar = texto.Substring(0, 3);
            string centena = texto.Substring(3, 3);
            if (centenaMilhar == "000")
            {
                extenso = ProcessarCentena(centena);
            }
            else
            {
                extenso = ProcessarCentena(centenaMilhar) + " mil e " + ProcessarCentena(centena);
            }
            return extenso;
        }

        private static string ProcessarDezena(string texto)
        {
            string extenso;
            string dezena = texto.Substring(0, 1);
            string unidade = texto.Substring(1, 1);
            switch (dezena)
            {
                case "0":
                    extenso = ProcessarUnidade(unidade);
                    break;
                case "1":
                    extenso = ProcessarDezeN(texto);
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
                default:using System;

namespace projeto10
{
    class Program
    {
        static void Main()
        {
            string repete;
            do
            {
                Console.Write("Entre com o número: ");
                string textoTela = Console.ReadLine();
                string extenso = string.Empty;
                string textoAux = ("000000" + textoTela).Substring(textoTela.Length);

                extenso = ProcessarCentenaMilhar(textoAux);

                Console.WriteLine(extenso);
                Console.WriteLine("digite \"S\" para repetir");
                repete = Console.ReadLine();
            } while (repete.ToUpper() == "S");
        }

        private static string ProcessarCentenaMilhar(string texto)
        {
            string extenso;
            string centenaMilhar = texto.Substring(0, 3);
            string centena = texto.Substring(3, 3);
            if (centenaMilhar == "000")
            {
                extenso = ProcessarCentena(centena);
            }
            else
            {
                extenso = ProcessarCentena(centenaMilhar) + " mil e " + ProcessarCentena(centena);
            }
            return extenso;
        }

        private static string ProcessarDezena(string texto)
        {
            string extenso;
            string dezena = texto.Substring(0, 1);
            string unidade = texto.Substring(1, 1);
            switch (dezena)
            {
                case "0":
                    extenso = ProcessarUnidade(unidade);
                    break;
                case "1":
                    extenso = ProcessarDezena(texto);
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

        private static string ProcessarDezeNa(string texto)
        {
            string extensoDezena;
            switch (texto)
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

        private static string ProcessarUnidade(string texto)
        {
            string extensoUnidade;
            switch (texto)
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
        private static string ProcessarCentena(string texto)


        {
            string extensoCentena;
            string centena = texto.Substring(0, 1);
            string dezena = texto.Substring(1, 2);

            switch (centena)
            {
                case "0":
                    extensoCentena = ProcessarDezena(dezena);
                    break;
                case "1":
                    extensoCentena = centena == "00" ? "cem" : "cento e " + ProcessarDezena(dezena); break;
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


    }
}

                    extenso = ("não é número!");
                    break;
            }
            return extenso;
        }

        private static string ProcessarDezeN(string texto)
        {
            string extensoDezena;
            switch (texto)
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

        private static string ProcessarUnidade(string texto)
        {
            string extensoUnidade;
            switch (texto)
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
        private static string ProcessarCentena(string texto)
        {
            string extensoCentena;
            string centena = texto.Substring(0, 1);
            string dezena = texto.Substring(1, 2);

            switch (centena)
            {
                case "0":
                    extensoCentena = ProcessarDezena(dezena);
                    break;
                case "1":
                    extensoCentena = dezena == "00" ? "cem" : "cento e " + ProcessarDezena(dezena);
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
    }
}
