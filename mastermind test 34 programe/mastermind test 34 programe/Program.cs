using System;

namespace mastermind_test_34_programe
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tCodeSecret = new int[4];
            int[] tCouleurJoueur = new int[4];
            Random alea = new Random();
            int pionblanc;
            int pionrouge;
            pionblanc = 0;
            pionrouge = 0;
     
            coulDepart(tCodeSecret, alea, out tCodeSecret);
            coolPlayer(tCouleurJoueur, out tCouleurJoueur);

            calcBonPlace(tCouleurJoueur, tCodeSecret, pionrouge, out pionrouge);
            calcBonCoul(tCouleurJoueur, tCodeSecret, pionblanc, out pionblanc);

            if (pionblanc = 5)
            {

            }

        } 
            static void coulDepart(int[] tCodeSecret, Random alea, out int[] lol)
            {

                for (int tc = 0; tc < 4; tc++)
                {
                    tCodeSecret[tc] = alea.Next(0, 6);
                }
                lol = tCodeSecret;
            }
            static void coolPlayer(int[] tCouleurJoueur, out int[] lol)
            {
                for (int compteur = 0; compteur < 4; compteur++)
                {
                    Console.WriteLine("entrez le numero de la couleur choisie n°" + compteur);
                    Console.WriteLine("(1 rouge, 2 jaune, 3 bleu,4 orange, 5 vert, 6 violet)");
                    tCouleurJoueur[compteur] = int.Parse(Console.ReadLine());
                    Console.WriteLine(tCouleurJoueur[compteur]);

                    while (tCouleurJoueur[compteur] < 0 || tCouleurJoueur[compteur] > 7)
                    {

                        Console.WriteLine("ERROR NUMERO DE COULEUR NON CORRECT");
                        Console.WriteLine("entrez le numero de la couleur choisie n°" + compteur);
                        Console.WriteLine("(1 rouge, 2 jaune, 3 bleu,4 orange, 5 vert, 6 violet)");
                        tCouleurJoueur[compteur] = int.Parse(Console.ReadLine());
                    }

                }
                lol = tCouleurJoueur;
            }
            static void calcBonPlace(int[] tCouleurJoueur, int[] tCodeSecret, int pion, out int pionrouge)
            {
                for (int compteur = 0; compteur < 4;compteur++)
                {
                    if (tCouleurJoueur[compteur] == tCodeSecret[compteur])
                    {
                        pion = pion + 1;
                    }
                }
                pionrouge = pion;
            }
            static void calcBonCoul(int[] tCouleurJoueur, int[] tCodeSecret, int pion, out int pionblanc)
            {
                for (int compteur = 0; compteur < 4; compteur++)
                {
                    for (int compteur2 = 0; compteur2 < 4; compteur2++)
                    {
                        if (tCodeSecret[compteur] == tCouleurJoueur[compteur2])
                        {
                            pion = pion + 1;
                        }
                    }
                }
                pionblanc = pion;
            }
    }
}
