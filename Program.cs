using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[,] tabuleiro = geraTabuleiroJogo(30, 10);
            desenhaTabuleiroJogo(tabuleiro, 30, 10);
            bool[][,] tetriminos = new bool[28][,];
            //bool[,] tetro1 = criarTetro1(); //guardar a funcao da criacao do tetr na funcao inicial
            //bool[,] tetro2 = criarTetro2();
            //bool[,] tetro3 = criarTetro3();
            //bool[,] tetro4 = criarTetro4();
            //bool[,] tetro5 = criarTetro5();
            //bool[,] tetro6 = criarTetro6();
            //bool[,] tetro7 = criarTetro7();
            //bool[,] tetro8 = criarTetro8();
            //bool[,] tetro9 = criarTetro9();
            //bool[,] tetro10 = criarTetro10();
            //bool[,] tetro11 = criarTetro11();
            //bool[,] tetro12 = criarTetro12();
            //bool[,] tetro13 = criarTetro13();
            //bool[,] tetro14 = criarTetro14();
            //bool[,] tetro15 = criarTetro15();
            //bool[,] tetro16 = criarTetro16();
            //bool[,] tetro17 = criarTetro17();
            //bool[,] tetro18 = criarTetro18();
            //bool[,] tetro19 = criarTetro19();
            //bool[,] tetro20 = criarTetro20();
            //bool[,] tetro21 = criarTetro21();
            //bool[,] tetro22 = criarTetro22();
            //bool[,] tetro23 = criarTetro23();
            //bool[,] tetro24 = criarTetro24();
            //bool[,] tetro25 = criarTetro25();
            //bool[,] tetro26 = criarTetro26();
            //bool[,] tetro27 = criarTetro27();
            //bool[,] tetro28 = criarTetro28();


            Console.ReadLine();
        }

        public static bool[,] geraTabuleiroJogo(int linha, int coluna) //gerar o tabuleiro
        {
            bool[,] tabuleiro;

            tabuleiro = new bool[linha, coluna];
            for (int i = 0; i < linha; i++)
            {
                for (int k = 0; k < coluna; k++)
                {
                    tabuleiro[i, k] = false;
                }
            }
            for (int i = 0; i < linha; i++)
            {
                for (int k = 0; k < coluna; k++)
                {
                    tabuleiro[i, k] = false;
                }
            }
            return tabuleiro;

        }

        public static void desenhaTabuleiroJogo(bool[,] tabuleiro, int linha, int coluna)
        {

            for (int i = 0; i < linha; i++)
            {
                Console.Write("|");                             //nao devolve valor
                                                                //i linhas z colunas

                for (int z = 0; z < coluna; z++)
                {
                    if (tabuleiro[i, z] == true)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine("|");
            }
            for (int a = 0; a < 12; a++)
            {
                Console.Write("-");
            }
            Console.WriteLine(" ");

        }

        public static void Ocupa(bool[,] tabuleiro, int linha, int coluna)
        {
            tabuleiro[linha, coluna] = true;
        }

        public static bool [][,] CriaTodosTetriminos(bool[,] tetro1, bool[,] tetro2, bool[,] tetro3, bool[,] tetro4, 
            bool[,] tetro5, bool[,] tetro6, bool[,] tetro7, bool[,] tetro8, bool[,] tetro9, bool[,] tetro10,
            bool[,] tetro11, bool[,] tetro12, bool[,] tetro13, bool[,] tetro14, bool[,] tetro15, 
            bool[,] tetro16, bool[,] tetro17, bool[,] tetro18, bool[,] tetro19, bool[,] tetro20,
            bool[,] tetro21, bool[,] tetro22, bool[,] tetro23, bool[,] tetro24, bool[,] tetro25, 
            bool[,] tetro26, bool[,] tetro27, bool[,] tetro28)
        {
            bool[][,] tetriminos;
            tetriminos = new bool[28][,];

            tetriminos[0] = criarTetro1();
            tetriminos[1] = criarTetro2();
            tetriminos[2] = criarTetro3();
            tetriminos[3] = criarTetro4();
            tetriminos[4] = criarTetro5();
            tetriminos[5] = criarTetro6();
            tetriminos[6] = criarTetro7();
            tetriminos[7] = criarTetro8();
            tetriminos[8] = criarTetro9();
            tetriminos[9] = criarTetro10();
            tetriminos[10] = criarTetro11();
            tetriminos[11] = criarTetro12();
            tetriminos[12] = criarTetro13();
            tetriminos[13] = criarTetro14();
            tetriminos[14] = criarTetro15();
            tetriminos[15] = criarTetro16();
            tetriminos[16] = criarTetro17();
            tetriminos[17] = criarTetro18();
            tetriminos[18] = criarTetro19();
            tetriminos[19] = criarTetro20();
            tetriminos[20] = criarTetro21();
            tetriminos[21] = criarTetro22();
            tetriminos[22] = criarTetro23();
            tetriminos[23] = criarTetro24();
            tetriminos[24] = criarTetro25();
            tetriminos[25] = criarTetro26();
            tetriminos[26] = criarTetro27();
            tetriminos[27] = criarTetro28();


            return tetriminos;

        }


        public static bool[,] criarTetro1()   //criar a funcao
        {
            bool[,] tetro1 = new bool[4, 4];  // //declaro tipo de array nome da array = crio novo array e que tamanho 

            for (int i = 0; i < 4; i++)            // i corresponde a linhas z colunas
            {
                for (int z = 0; z < 4; z++)
                {
                    if (i == 1)
                    {
                        tetro1[i, z] = true;
                    }
                    else
                    {
                        tetro1[i, z] = false;
                    }
                }
            }
            return tetro1;                  //vai devolver o tetro
        }

        public static bool[,] criarTetro2()
        {
            bool[,] tetro2 = new bool[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    if (z == 2)
                    {
                        tetro2[i, z] = true;
                    }
                    else
                    {
                        tetro2[i, z] = false;
                    }
                }
            }
            return tetro2;
        }

        public static bool[,] criarTetro3()
        {
            bool[,] tetro3 = new bool[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    if (i == 2)
                    {
                        tetro3[i, z] = true;

                    }
                    else
                    {
                        tetro3[i, z] = false;

                    }
                }
            }
            return tetro3;
        }

        public static bool[,] criarTetro4()
        {
            bool[,] tetro4 = new bool[4, 4];

            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    if (z == 1)
                    {
                        tetro4[i, z] = true;
                    }
                    else
                    {
                        tetro4[i, z] = false;
                    }
                }
            }
            return tetro4;
        }

        public static bool[,] criarTetro5()
        {
            bool[,] tetro5 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if ((i == 0 && z == 0) || i == 1)
                    {
                        tetro5[i, z] = true;
                    }
                    else
                    {
                        tetro5[i, z] = false;
                    }
                }
            }
            return tetro5;
        }

        public static bool[,] criarTetro6()
        {
            bool[,] tetro6 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (z == 1 || (i == 0 && z == 2))
                    {
                        tetro6[i, z] = true;
                    }
                    else
                    {
                        tetro6[i, z] = false;
                    }
                }
            }
            return tetro6;
        }

        public static bool[,] criarTetro7()
        {
            bool[,] tetro7 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (i == 1 || (z == 2 && i == 2))
                    {
                        tetro7[i, z] = true;
                    }
                    else
                    {
                        tetro7[i, z] = false;
                    }
                }
            }
            return tetro7;
        }


        public static bool[,] criarTetro8()
        {
            bool[,] tetro8 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {

                for (int z = 0; z < 3; z++)
                {
                    if (z == 1 || (i == 2 && z == 0))
                    {
                        tetro8[i, z] = true;
                    }
                    else
                    {
                        tetro8[i, z] = false;
                    }
                }
            }
            return tetro8;
        }

        public static bool[,] criarTetro9()
        {
            bool[,] tetro9 = new bool[3, 3];

              for (int i= 0; i < 3; i++)
            {
             
                for (int z = 0; z < 3; z++)
                {
                    if (i== 1 || (i == 0 && z == 2))
                    {
                        tetro9[i, z] = true;                      
                    }
                    else
                    {
                        tetro9[i,z] = false;                       
                    }
                }
            }
            return tetro9;
        }

        public static bool[,] criarTetro10()
        {
            bool[,] tetro10 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (z == 1 || (i == 2 && z == 2))
                    {
                        tetro10[i, z] = true;                   
                    }
                    else
                    {
                        tetro10[i,z] = false;                   
                    }
                }
            }
            return tetro10;
        }

        public static bool[,] criarTetro11()
        {
            bool[,] tetro11 = new bool[3, 3];

            for (int i = 0; i < 3; i++)
            {
             
                for (int z = 0; z < 3; z++)
                {
                    if (i == 1 || (i == 2 && z == 0))
                    {
                        tetro11[i, z] = true;                   
                    }
                    else
                    {
                        tetro11[i,z] = false;                  
                    }
                }
            }
            return tetro11;
        }

        public static bool[,] criarTetro12()
        {
            bool[,] tetro12 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (z == 1 || (i == 0 && z == 0))
                    {
                        tetro12[i, z] = true;
                    }
                    else
                    {
                        tetro12[i, z] = false;
                    }
                }               
            }
            return tetro12;
        }

        public static bool[,] criarTetro13()
        {
            bool[,] tetro13 = new bool[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    if (((z == 1 && i == 0) || (i == 0 && z == 2)) || (i == 1 && z == 2) || (i == 1 && z == 1))
                    {
                        tetro13[i, z] = true;
                    }
                    else
                    {
                        tetro13[i, z] = false;
                    }
                }
            }
            return tetro13;
        }

        public static bool[,] criarTetro14()
        {
            bool[,] tetro14 = new bool[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    if (((z == 1 && i == 0) || (i == 0 && z == 2)) || (i == 1 && z == 2) || (i == 1 && z == 1))
                    {
                        tetro14[i, z] = true;
                    }
                    else
                    {
                        tetro14[i, z] = false;
                    }
                }
            }
            return tetro14;
        }

        public static bool[,] criarTetro15()
        {
            bool[,] tetro15 = new bool[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    if (((z == 1 && i == 0) || (i == 0 && z == 2)) || (i == 1 && z == 2) || (i == 1 && z == 1))
                    {
                        tetro15[i, z] = true;
                    }
                    else
                    {
                        tetro15[i, z] = false;
                    }
                }
            }
            return tetro15;
        }
        public static bool[,] criarTetro16()
        {
            bool[,] tetro16 = new bool[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int z = 0; z < 4; z++)
                {
                    if (((z == 1 && i == 0) || (i == 0 && z == 2)) || (i == 1 && z == 2) || (i == 1 && z == 1))
                    {
                        tetro16[i, z] = true;
                    }
                    else
                    {
                        tetro16[i, z] = false;
                    }
                }
            }
            return tetro16;
        }

        public static bool[,] criarTetro17()
        {
            bool[,] tetro17 = new bool[3, 3];
            for (int i= 0; i < 3; i++)
            {              
                for (int z = 0; z < 3; z++)
                {
                    if (((z == 0 && i == 1) || (i == 1 && z == 1)) || (i == 0 && z == 1) || (i == 0 && z == 2))
                    {
                        tetro17[i, z] = true;
                    }
                    else
                    {
                        tetro17[i, z] = false;
                    }
                }
            }
            return tetro17;
        }


        public static bool[,] criarTetro18()
        {
            bool[,] tetro18 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (((z == 1 && i == 0) || (i == 1 && z == 1)) || (i == 1 && z == 2) || (i == 2 && z == 2))
                    {
                        tetro18[i, z] = true;
                    }
                    else
                    {
                        tetro18[i, z] = false;
                    }
                }
            }
            return tetro18;
        }

        public static bool[,] criarTetro19()
        {
            bool[,] tetro19 = new bool[3, 3];  
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (((z == 0 && i == 2) || (i == 2 && z == 1)) || (i == 1 && z == 1) || (i == 1 && z == 2))
                    {
                        tetro19[i, z] = true;
                    }
                    else
                    {
                        tetro19[i, z] = false;
                    }
                }
            }
            return tetro19;
        }
                    
        public static bool[,] criarTetro20()
        {
            bool[,] tetro20 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (((z == 0 && i == 0) || (i == 1 && z == 0)) || (i == 1 && z == 1) || (i == 2 && z == 1))
                    {
                        tetro20[i, z] = true;
                    }
                    else
                    {
                        tetro20[i, z] = false;
                    }
                }
            }
            return tetro20;
        }
                   
        public static bool[,] criarTetro21()
        {
            bool[,] tetro21 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (i == 1 || (z == 1 && i == 0))
                    {
                        tetro21[i, z] = true;
                    }
                    else
                    {
                        tetro21[i, z] = false;
                    }
                }
            }
            return tetro21;
        }
                    
        public static bool[,] criarTetro22()
        {
            bool[,] tetro22 = new bool[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (z == 1 || (z == 2 && i == 1))
                    {
                        tetro22[i, z] = true;
                    }
                    else
                    {
                        tetro22[i, z] = false;
                    }
                }
            }
            return tetro22;
        }

        public static bool[,] criarTetro23()
        {
            bool[,] tetro23 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (i == 1 || (z == 1 && i == 2))
                    {
                        tetro23[i, z] = true;
                    }
                    else
                    {
                        tetro23[i, z] = false;
                    }
                }
            }
            return tetro23;
        }
       
        public static bool[,] criarTetro24()
        {
            bool[,] tetro24 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (z == 1 || (z == 0 && i == 1))
                    {
                        tetro24[i, z] = true;
                    }
                    else
                    {
                        tetro24[i, z] = false;
                    }
                }
            }
            return tetro24;
        }

       public static bool[,] criarTetro25()
        {
            bool[,] tetro25 = new bool[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (((z == 0 && i == 0) || (i == 0 && z == 1)) || (i == 1 && z == 1) || (i == 1 && z == 2))
                    {
                        tetro25[i, z] = true;
                    }
                    else
                    {
                        tetro25[i, z] = false;
                    }
                }
            }
            return tetro25;
        }

        public static bool[,] criarTetro26()
        {
            bool[,] tetro26 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (((z == 2 && i == 0) || (i == 1 && z == 2)) || (i == 1 && z == 1) || (i == 2 && z == 1))
                    {
                        tetro26[i, z] = true;
                    }
                    else
                    {
                        tetro26[i, z] = false;
                    }
                }
            }
            return tetro26;
        }

        public static bool[,] criarTetro27()
        {
            bool[,] tetro27 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (((z == 0 && i == 1) || (i == 1 && z == 1)) || (i == 2 && z == 1) || (i == 2 && z == 2))
                    {
                        tetro27[i, z] = true;
                    }
                    else
                    {
                        tetro27[i, z] = false;
                    }
                }
            }
            return tetro27;
        }
        
        public static bool[,] criarTetro28()
        {
            bool[,] tetro28 = new bool[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int z = 0; z < 3; z++)
                {
                    if (((z == 1 && i == 0) || (i == 1 && z == 1)) || (i == 1 && z == 0) || (i == 2 && z == 0))
                    {
                        tetro28[i, z] = true;
                    }
                    else
                    {
                        tetro28[i, z] = false;
                    }
                }
            }
            return tetro28;
        }
                   


    }

    }



