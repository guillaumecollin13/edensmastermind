using System;

namespace master_mind
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] tCodeSecret = new int [4];
            int [] tCouleurJoueur = new int[4];
            Random alea = new Random();
            

            edensCoulDepart(tCodeSecret, alea ,out tCodeSecret);
            edensCoolPlayer(tCouleurJoueur ,out tCouleurJoueur);
            for (int compteur = 0; compteur < 4; compteur++)
            {
                Console.Write(tCouleurJoueur[compteur]);
            }
            Console.WriteLine("chubiduwaaaaaaa");
            for (int compteur = 0; compteur < 4; compteur++)
            {
                Console.Write(tCodeSecret[compteur]);
            }




            static void edensCoulDepart(int[] tCodeSecret, Random alea, out int[] lol)
        {
                
                for (int tc=0 ; tc <4; tc++)
            {              
                tCodeSecret[tc] = alea.Next (0,6);
            }
                lol = tCodeSecret;
        }

        static void edensCoolPlayer (int[] tCouleurJoueur, out int[] lol ) 
        {
            for (int compteur = 0; compteur < 4;compteur++) 
            {
                    Console.WriteLine("entrez le numero de la couleur choisie n°"+compteur);
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

    }
}}
