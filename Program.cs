using System;

namespace TesteJoao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] notasAlunos = new int[10, 4];
            int alunos = 0;

            for (int i = 0; i < 10; i++)
            {
                int posicaoArray = 0;

                for (int notas = 1; notas <= 4; notas++)
                {
                    Console.WriteLine("Insira a nota " + notas);
                    notasAlunos[alunos, posicaoArray] = int.Parse(Console.ReadLine());
                    posicaoArray++;
                }

                Console.WriteLine();
                Console.WriteLine();
                alunos++;
            }

            double mediaAluno1 = tirarMedia(notasAlunos[0,0], notasAlunos[0, 1], notasAlunos[0, 2], notasAlunos[0, 3]);
            double mediaAluno2 = tirarMedia(notasAlunos[1, 0], notasAlunos[1, 1], notasAlunos[1, 2], notasAlunos[1, 3]);
            double mediaAluno3 = tirarMedia(notasAlunos[2, 0], notasAlunos[2, 1], notasAlunos[2, 2], notasAlunos[2, 3]);
            double mediaAluno4 = tirarMedia(notasAlunos[3, 0], notasAlunos[3, 1], notasAlunos[3, 2], notasAlunos[3, 3]);
            double mediaAluno5 = tirarMedia(notasAlunos[4, 0], notasAlunos[4, 1], notasAlunos[4, 2], notasAlunos[4, 3]);
            double mediaAluno6 = tirarMedia(notasAlunos[5, 0], notasAlunos[5, 1], notasAlunos[5, 2], notasAlunos[5, 3]);
            double mediaAluno7 = tirarMedia(notasAlunos[6, 0], notasAlunos[6, 1], notasAlunos[6, 2], notasAlunos[6, 3]);
            double mediaAluno8 = tirarMedia(notasAlunos[7, 0], notasAlunos[7, 1], notasAlunos[7, 2], notasAlunos[7, 3]);
            double mediaAluno9 = tirarMedia(notasAlunos[8, 0], notasAlunos[8, 1], notasAlunos[8, 2], notasAlunos[8, 3]);
            double mediaAluno10 = tirarMedia(notasAlunos[9, 0], notasAlunos[9, 1], notasAlunos[9, 2], notasAlunos[9, 3]);

            int aprovados = 0;
            int reprovados = 0;

            if(mediaAluno1 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno2 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno3 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno4 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno5 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno6 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno7 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno8 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno9 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            if (mediaAluno10 >= 7)
            {
                aprovados++;
            }
            else
            {
                reprovados++;
            }

            double mediaGeral = (mediaAluno1 + mediaAluno2 + mediaAluno3 + mediaAluno4 + mediaAluno5 + mediaAluno6 + mediaAluno7 + mediaAluno8 + mediaAluno9 + mediaAluno10) / 10;

            Console.WriteLine("Média do aluno 1: " + mediaAluno1.ToString("F"));
            Console.WriteLine("Média do aluno 2: " + mediaAluno2.ToString("F"));
            Console.WriteLine("Média do aluno 3: " + mediaAluno3.ToString("F"));
            Console.WriteLine("Média do aluno 4: " + mediaAluno4.ToString("F"));
            Console.WriteLine("Média do aluno 5: " + mediaAluno5.ToString("F"));
            Console.WriteLine("Média do aluno 6: " + mediaAluno6.ToString("F"));
            Console.WriteLine("Média do aluno 7: " + mediaAluno7.ToString("F"));
            Console.WriteLine("Média do aluno 8: " + mediaAluno8.ToString("F"));
            Console.WriteLine("Média do aluno 9: " + mediaAluno9.ToString("F"));
            Console.WriteLine("Média do aluno 10: " + mediaAluno10.ToString("F"));

            Console.WriteLine("Aprovados: " + aprovados);
            Console.WriteLine("Reprovados: " + reprovados);

            Console.WriteLine("Média geral: " + mediaGeral);
        }

        public static double tirarMedia(int n1, int n2, int n3, int n4)
        {
            double media = (n1 + n2 + n3 + n4) / 4;
            return media;
        }
    }
}
