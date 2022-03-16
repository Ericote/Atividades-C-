using System;

namespace Exe
{
    public class Exercicios
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("+-------------------------------+");
            Console.WriteLine("|         EXERCÍCIOS C#         |");
            Console.WriteLine("|-------------------------------|");
            Console.WriteLine("| 0  | SAIR                     |");
            Console.WriteLine("| 1  | MÉDIA DE NOTAS           |");
            Console.WriteLine("| 2  | CALCULO DE ÁREA          |");
            Console.WriteLine("| 3  | CALCULO DE VOLUME        |");
            Console.WriteLine("| 4  | MÉDIA DE NOTAS 2         |");
            Console.WriteLine("| 5  | NÚMERO DO MÊS            |");
            Console.WriteLine("| 6  | TABUADA                  |");
            Console.WriteLine("| 7  | ARRAY COM FOREACH        |");
            Console.WriteLine("| 8  | DOUBLE COM ARRAY         |");
            Console.WriteLine("| 9  | TEMPERATURA MÉDIA ANUAL  |");
            Console.WriteLine("| 10 | TRIBUNAL VIRTUAL         |");
            Console.WriteLine("+-------------------------------+");
            
            int escolha = 0;

             do
            {
                try
                {
                    Console.WriteLine("Escolha uma opção: ");
                    escolha = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    escolha = 99;
                }
                try{
                    switch (escolha)
                    {
                        case 0:
                        {
                            Console.WriteLine("Obrigado por utilizar o sistema!");
                            break;
                        }

                        case 1:
                        {
                            Console.WriteLine("========== Exe Média de Notas ==========");

                            int nota1;
                            int nota2;
                            int nota3;

                            Console.WriteLine(" Digite a primeira nota: ");
                            nota1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(" Digite a segunda nota: ");
                            nota2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(" Digite a terceira nota: ");
                            nota3 = Convert.ToInt32(Console.ReadLine());

                            int media = (nota1 + nota2 + nota3) / 3;

                            Console.WriteLine("A média das notas é " + media);
                            break;
                        }

                        case 2:
                        {
                            Console.WriteLine("======== Exe Calculo de Área ========");

                            int lado1;
                            int lado2;

                            Console.WriteLine(" Digite o valor do primeiro lado: ");
                            lado1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(" Digite o valor do segundo lado: ");
                            lado2 = Convert.ToInt32(Console.ReadLine());

                            int soma = (lado1 * lado2);

                            Console.WriteLine("A sua área é " + soma);
                            break;
                        }

                        case 3:
                        {
                            Console.WriteLine("======== Exe Calculo de Volume =======");

                            int largura;
                            int altura;
                            int profundidade;

                            Console.WriteLine("Digite a largura: ");
                            largura = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine(" Digite a altura: ");
                            altura = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite a profundidade: ");
                            profundidade = Convert.ToInt32(Console.ReadLine());

                            int volume = (largura * altura * profundidade);
           
                            Console.WriteLine("O volume é " +volume);
                            break;
                        }

                        case 4:
                        {
                            Console.WriteLine("======== Exe Média de Notas 2.0 ========");

                            int nota1;
                            int nota2;
                            int nota3;

                            Console.WriteLine("Digite a primeira nota: ");
                            nota1 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite a segunda nota: ");
                            nota2 = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite a terceira nota: ");
                            nota3 = Convert.ToInt32(Console.ReadLine());

                            int media = (nota1 + nota2 + nota3) / 3;

                            if(media<7)
                            {
                                Console.WriteLine("Sua média é: " +media+ "\n Status: REPROVADO");
                            }
                            else
                            {
                                Console.WriteLine("Sua média é: " +media+ "\n Status: APROVADO");
                            }
                            break;
                        }

                        case 5:
                        {
                            Console.WriteLine("======== Número do Mês ========");

                            int mes = 0;
                            
                            Console.WriteLine("Digite um número do mês desejado: ");
                            mes =  Convert.ToInt32(Console.ReadLine());
                            
                            if(mes == 1)
                            {
                                Console.WriteLine("\n Janeiro ");
                            }
                            if(mes == 2)
                            {
                                Console.WriteLine("\n Fevereiro");
                            }
                            if(mes == 3)
                            {
                                Console.WriteLine("\n Março");
                            }
                            if(mes == 4)
                            {
                                Console.WriteLine("\n Abril");
                            }
                            if(mes == 5)
                            {
                                Console.WriteLine("\n Maio");
                            }
                            if(mes == 6)
                            {
                                Console.WriteLine("\n Junho");
                            }
                            if(mes == 7)
                            {
                                Console.WriteLine("\n Julho");
                            }
                            if(mes == 8)
                            {
                                Console.WriteLine("\n Agosto");
                            }
                            if(mes == 9)
                            {
                                Console.WriteLine("\n Setembro");
                            }
                            if(mes == 10)
                            {
                                Console.WriteLine("\n Outubro");
                            }
                            if(mes == 11)
                            {
                                Console.WriteLine("\n Novembro");
                            }
                            if(mes == 12)
                            {
                                Console.WriteLine("\n Dezembro");
                            }
                            
                            break;
                        }

                        case 6:
                        {
                            Console.WriteLine("======== Tabuada ========");
                            int num;
                            int i = 0;
                            Console.WriteLine("Digite o número desejado para a tabuada: ");
                            num = Convert.ToInt32(Console.ReadLine());

                            do
                            {
                                Console.WriteLine(num+"*"+i+" = "+num*i);
                                i++;
                            }while(i<=10);
                            break;
                        }

                        case 7:
                        {
                            Console.WriteLine("======== Imprimir Array com Foreach =======");


                            int[] Numeros = {10, 20, 30, 40, 50, 60, 70};
		                    foreach (int Num in Numeros)
		                    {
		                    	Console.WriteLine(Num);
		                    }
                            break;
                        }

                        case 8:
                        {
                            Console.WriteLine("======== Leitor Double Salvando em Array ========-");

                            int i = 0;
		                    Double[] Num = new Double[10];
		                    for(i=0; i<10; i++)
		                    {
		                    	Console.WriteLine("Informe o " +(i+1)+ "a número: ");
		                    	try
		                    	{
		                    		Num[i] = Convert.ToInt32(Console.ReadLine());
		                    	}
		                    	catch(Exception)
		                    	{
		                    	Console.WriteLine("Número inválido tente novamente!");	
		                    	}
		                    }
		                    for(i = 0; i < Num.Length; i++)
		                    {
		                    	Console.WriteLine(" O "+(i+1)+"a valor é: " + Num[i]);	
		                    }
                            break;
                        }

                        case 9:
                        {
                            Console.WriteLine("======== Temperatura Média ========");

                            int ano = 12;
		                    Double[] temp = new Double[ano];
		                    Double soma = 0;

		                    for(int i = 0; i < ano; i++)
		                    {
			                Console.WriteLine("Digite a " + (i + 1) + "a temperatura");
			                try
			                {
			                	temp[i] = Convert.ToDouble(Console.ReadLine());
			                	soma += temp[i];
			                }
			                catch(Exception)
			                {
			                	Console.WriteLine("Temperatura inválida tente novamente!");
			                }
		                    }
                            Double media = soma / ano;
		                    Console.WriteLine("A temperatura média do ano é: " + media);
                            break;
                        }

                        case 10:
                        {
                            Console.WriteLine("======== Tribunal Virtual ========");
                            int respTotal = 0;
                            int resp;

                            Console.WriteLine("Telefonou a vitíma?");
                            Console.WriteLine("\n [1]-SIM \n [2]-NÃO");
                            resp = Convert.ToInt32(Console.ReadLine());
                            if(resp==1)
                            {
                                respTotal++;
                            }
                            Console.WriteLine("\n Esteve no local do crime?");
                            Console.WriteLine("\n [1]-SIM \n [2]-NÃO");
                            resp = Convert.ToInt32(Console.ReadLine());
                            if(resp==1)
                            {
                                respTotal++;
                            }
                            Console.WriteLine("\n Mora perto da vítima?");
                            Console.WriteLine("\n [1]-SIM \n [2]-NÃO");
                            resp = Convert.ToInt32(Console.ReadLine());
                            if(resp==1)
                            {
                                respTotal++;
                            }
                            Console.WriteLine("\n Devia para a vítima?");
                            Console.WriteLine("\n [1]-SIM \n [2]-NÃO");
                            resp = Convert.ToInt32(Console.ReadLine());
                            if(resp==1)
                            {
                                respTotal++;
                            }
                            Console.WriteLine("\n Já trabalhou com a vítima?");
                            Console.WriteLine("\n [1]-SIM \n [2]-NÃO");
                            resp = Convert.ToInt32(Console.ReadLine());
                            if(resp==1)
                            {
                                respTotal++;
                            }
                            if(respTotal<=1)
                            {
                                Console.WriteLine(" Você é...INOCENTE!");
                            }
                            if(respTotal==2)
                            {
                                Console.WriteLine(" Você é...SUSPEITO!");
                            }
                            if(respTotal==3 || respTotal==4)
                            {
                                Console.WriteLine(" Você é...CUMPLICE!");
                            }
                            if(respTotal==5)
                            {
                                Console.WriteLine("Você é...ASSASSINO!");
                            }
                            break;
                        }
                        
                    }
                }catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                    escolha = 99;
                }
            }while(escolha!=0);
        }
    }
}