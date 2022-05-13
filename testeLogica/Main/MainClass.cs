using CalculateArea.Formas;
using ExtractDataList;

namespace Main
{
    public static class MainClass
    {
        public static void Menu()
        {
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine("                         Testes de Logica                                         ");
            Console.WriteLine("----------------------------------------------------------------------------------");

            Console.WriteLine("1 | Exerxicio 1 - Calcular formas geometricas"                                     );
            Console.WriteLine("2 | Exercicio 2 - Extrair a média e o maior e menor valor da lista"                );
            Console.WriteLine("3 | Exercicio 3 - Resultado da saída do programa"                                  );
            Console.WriteLine("4 | Exercicio 4 - Soma dos valores de todas as posições de M"                      );
            Console.WriteLine("5 | Exercicio 5 - Tempo de execução do algoritmo caso as variaves varie de 1 a 100");
            Console.WriteLine("0 | Sair ");

            var op = Int32.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("                               Calcular a area                               ");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("1 | Calcular a área de um triangulo");
                    Console.WriteLine("2 | Calcular a área de um retângulo");
                    Console.WriteLine("0 | Voltar para o Menu");

                    var op1 = Int32.Parse(Console.ReadLine());
                    switch (op1)
                    {                        
                        case 1:
                            Console.WriteLine("Digito o valor da base: ");
                            var _base = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o valor da altura: ");
                            var height = Int32.Parse(Console.ReadLine());

                            var resultCalcAreaTriangulo = new Triangulo().CalcularArea(_base, height);
                            Console.WriteLine(@$"Valor da Area do Retangulo é {resultCalcAreaTriangulo}");
                            MainClass.Menu();
                            break;

                        case 2:
                            Console.WriteLine("Digito o valor da base: ");
                            _base = Int32.Parse(Console.ReadLine());

                            Console.WriteLine("Digite o valor da altura: ");
                            height = Int32.Parse(Console.ReadLine());

                            var resultCalcAreaRetangulo = new Retangulo().CalcularArea(_base, height);
                            Console.WriteLine(@$"Valor da Area do Retangulo é {resultCalcAreaRetangulo}");
                            MainClass.Menu();
                            break;

                        case 0:
                            MainClass.Menu();
                            break;

                        default:
                            Console.WriteLine("Digite um valor valido.");
                            MainClass.Menu();
                            break;
                    }
                    break;

                  case 2:
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("                               Extraction                                    ");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("Lista = { -3, 8, 12, -5, 1, 4, 21, 13, 7}");
                    Console.WriteLine("1 | Calcular a media da lista");
                    Console.WriteLine("2 | Trazer o maior numero da lista");
                    Console.WriteLine("3 | Trazer o maior numero da lista");
                    Console.WriteLine("0 | Voltar para o Menu");

                    var op2 = Int32.Parse(Console.ReadLine());
                    switch (op2)
                    {
                        case 1:
                            var resultAverge = new Extraction().ReturnAverageFromList();
                            Console.WriteLine(@$"A media da Lista é:  {resultAverge}");
                            MainClass.Menu();
                            break;
                        case 2:
                            var resultBiggest = new Extraction().ReturnTheLargestInTheList();
                            Console.WriteLine(@$"O maior numero da Lista é: {resultBiggest}");
                            MainClass.Menu();
                            return;

                        case 3:
                            var resultMinimum = new Extraction().ReturnTheMinimumtInTheList();
                            Console.WriteLine(@$"O menor numero da Lista é: {resultMinimum}");
                            MainClass.Menu();
                            return;

                        case 0:
                            MainClass.Menu();
                            break;

                        default:
                            Console.WriteLine("Digite um valor valido.");
                            MainClass.Menu();
                            break;
                    }
                    break;

                case 3:
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("             Exercicio -3  Qual a saída do programa abaixo?                  ");
                    Console.WriteLine("-----------------------------------------------------------------------------");
                    Console.WriteLine("O valor da saida do programa é : 0,1,1,3,5,7,9,11,13");

                    MainClass.Menu();
                    break;

                case 4:
                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Exercicio -4 Considerando o algoritmo apresentado, pode-se afirmar que,após a sua execução,");
                    Console.WriteLine(" a soma dos valores de todas as posições de M será igual a: b)10");
                    Console.WriteLine("--------------------------------------------------------------------------------------------");
                    Console.WriteLine("O valor da saida do programa é : 0,1,1,3,5,7,9,11,13");

                    MainClass.Menu();
                    break;

                case 5:
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");
                    Console.WriteLine(" Exercicio 5 - No algoritmo apresentado, caso cada um dos loops, referentes às variáveis i, j e k, varie");
                    Console.WriteLine("de 1 até 100, o tempo de execução do algoritmo, aproximadamente, será: b)b)	90 vezes maior"             );
                    Console.WriteLine("--------------------------------------------------------------------------------------------------------");

                    MainClass.Menu();
                    break;

                case 0:                    
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Digite um numero Valido");
                    MainClass.Menu();
                    break;
            }

        }
    }
}
