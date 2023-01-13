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
            bool cohesion;
            int compt;
            string repet;
            compt = 0;
     
            do
            {
                cohesion = false;
                coulDepart(tCodeSecret, alea, out tCodeSecret);
                do
                {

                    compt = compt + 1;
                    Console.WriteLine("essai N°" + compt);
                    coolPlayer(tCouleurJoueur, out tCouleurJoueur);
                    pionblanc = 0;
                    pionrouge = 0;
                    calcBonPlace(tCouleurJoueur, tCodeSecret, pionrouge, out pionrouge);
                    calcBonCoul(tCouleurJoueur, tCodeSecret, pionblanc, out pionblanc);
                    if ((pionrouge == 4) && (pionblanc >= 4))
                    {
                        cohesion = true;
                        compt = 10000;
                    }
                    else
                    {
                        Console.WriteLine("vous avez " + pionrouge + " couleurs a la bonne place et " + pionblanc + " bonne couleur");
                        Console.WriteLine(" ");
                        if (compt == 10)
                        {
                            cohesion = true;
                        }
                    }
                } while (cohesion == false);
                if (compt == 10000)
                {
                    Console.WriteLine("vous avez gagné");
                }
                else
                {
                    Console.WriteLine("vous avez perdu");
                }
                Console.WriteLine("voulez vous recomencez oui(Y) non(N)");
                repet = Console.ReadLine();
            } while (repet == "Y");
        }
        static void coulDepart(int[] tCodeSecret, Random alea, out int[] lol)
        {

            for (int tc = 0; tc < 4; tc++)
            {
                tCodeSecret[tc] = alea.Next(1, 6);
            }
            lol = tCodeSecret;
        }
        static void coolPlayer(int[] tCouleurJoueur, out int[] lol)
        {
            bool trypasse;
            bool trypasse2;
            for (int compteur = 0; compteur < 4; compteur++)
            {
                Console.WriteLine($"entrez le numero de la couleur choisie n° {compteur+1}");
                Console.WriteLine("(1 rouge, 2 jaune, 3 bleu,4 orange, 5 vert, 6 violet)");
                do
                {
                    trypasse = false;

                    if (int.TryParse(Console.ReadLine(), out tCouleurJoueur[compteur]))
                    {
                        while (tCouleurJoueur[compteur] <= 0 || tCouleurJoueur[compteur] > 7)
                        {

                            Console.WriteLine("ERROR NUMERO DE COULEUR NON CORRECT");
                            Console.WriteLine($"entrez le numero de la couleur choisie n° {compteur+1}");
                            Console.WriteLine("(1 rouge, 2 jaune, 3 bleu,4 orange, 5 vert, 6 violet)");
                            do
                            {
                                trypasse2 = false;
                                if (int.TryParse(Console.ReadLine(), out tCouleurJoueur[compteur]))
                                {
                                    trypasse2 = true;
                                }
                                else
                                {
                                    Console.WriteLine("ERROR NUMERO DE COULEUR NON CORREcCT");
                                    Console.WriteLine($"entrez le numero de la couleur choisie n° {compteur + 1}");
                                    Console.WriteLine("(1 rouge, 2 jaune, 3 bleu,4 orange, 5 vert, 6 violet)");
                                }
                            } while (trypasse2==false);
                        }
                        trypasse = true;

                    }
                    else
                    {
                        Console.WriteLine("ERROR ENTREE INCORRECT");
                        Console.WriteLine($"entrez le numero de la couleur choisie n° {compteur+1}");
                        Console.WriteLine("(1 rouge, 2 jaune, 3 bleu,4 orange, 5 vert, 6 violet)");
                    }
                } while (trypasse==false);


               

            }
            lol = tCouleurJoueur;
        }
        static void calcBonPlace(int[] tCouleurJoueur, int[] tCodeSecret, int pion, out int pionrouge)
        {
            for (int compteur = 0; compteur < 4; compteur++)
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
