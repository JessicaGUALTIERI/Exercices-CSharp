using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DÉCLARATIONS
            // GRILLE DE BASE
            // Remarques :
            // Une ligne :
            // sudoku[i, j] où i vaut 0 à 8 (i fixe, j varie)
            // Une colonne :
            // sudoku[i, j] où j vaut 0 à 8 (j fixe, i varie)
            int[,] sudoku =
            {
                { 0, 3, 5,    0, 0, 1,    0, 0, 0 },
                { 2, 9, 0,    0, 4, 0,    0, 0, 0 },
                { 0, 6, 8,    0, 5, 2,    9, 0, 0 },

                { 0, 0, 4,    5, 0, 0,    0, 8, 0 },
                { 0, 0, 7,    0, 0, 6,    3, 0, 5 },
                { 0, 5, 6,    0, 0, 8,    0, 0, 0 },

                { 6, 4, 0,    0, 7, 5,    0, 0, 0 },
                { 0, 0, 9,    3, 0, 0,    6, 0, 2 },
                { 8, 7, 2,    1, 0, 0,    0, 4, 3 }
            };
            // CASES REMPLIES DANS LA GRILLE DE BASE (CONDITIONS D'ARRÊT DE LA BOUCLE WHILE DU RÉSOLVEUR)
            int casesRemplies = 0;
            /* GRILLE REMPLIE
            int[,] sudokuSolution =
            {
                { 7, 3, 5,    8, 9, 1,    2, 6, 4 },
                { 2, 9, 1,    6, 4, 3,    7, 5, 8 },
                { 4, 6, 8,    7, 5, 2,    9, 3, 1 },

                { 9, 2, 4,    5, 3, 7,    1, 8, 6 },
                { 1, 8, 7,    4, 2, 6,    3, 9, 5 },
                { 3, 5, 6,    9, 1, 8,    4, 2, 7 },

                { 6, 4, 3,    2, 7, 5,    8, 1, 9 },
                { 5, 1, 9,    3, 8, 4,    6, 7, 2 },
                { 8, 7, 2,    1, 6, 9,    5, 4, 3 }
            };
            */
            // LIGNES --------------------------------------------------------------------------------------------------------------
            List<int> ligne0ChiffresRemplis = new List<int>();
            List<int> ligne0ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne0ChiffresRemplis, ligne0ChiffresPossibles, 0);

            List<int> ligne1ChiffresRemplis = new List<int>();
            List<int> ligne1ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne1ChiffresRemplis, ligne1ChiffresPossibles, 1);

            List<int> ligne2ChiffresRemplis = new List<int>();
            List<int> ligne2ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne2ChiffresRemplis, ligne2ChiffresPossibles, 2);

            List<int> ligne3ChiffresRemplis = new List<int>();
            List<int> ligne3ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne3ChiffresRemplis, ligne3ChiffresPossibles, 3);

            List<int> ligne4ChiffresRemplis = new List<int>();
            List<int> ligne4ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne4ChiffresRemplis, ligne4ChiffresPossibles, 4);

            List<int> ligne5ChiffresRemplis = new List<int>();
            List<int> ligne5ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne5ChiffresRemplis, ligne5ChiffresPossibles, 5);

            List<int> ligne6ChiffresRemplis = new List<int>();
            List<int> ligne6ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne6ChiffresRemplis, ligne6ChiffresPossibles, 6);

            List<int> ligne7ChiffresRemplis = new List<int>();
            List<int> ligne7ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne7ChiffresRemplis, ligne7ChiffresPossibles, 7);

            List<int> ligne8ChiffresRemplis = new List<int>();
            List<int> ligne8ChiffresPossibles = new List<int>();
            creationAffichageLigne(sudoku, ligne8ChiffresRemplis, ligne8ChiffresPossibles, 8);


            // COLONNES ------------------------------------------------------------------------------------------------------------
            List<int> colonne0ChiffresRemplis = new List<int>();
            List<int> colonne0ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne0ChiffresRemplis, colonne0ChiffresPossibles, 0);

            List<int> colonne1ChiffresRemplis = new List<int>();
            List<int> colonne1ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne1ChiffresRemplis, colonne1ChiffresPossibles, 1);

            List<int> colonne2ChiffresRemplis = new List<int>();
            List<int> colonne2ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne2ChiffresRemplis, colonne2ChiffresPossibles, 2);

            List<int> colonne3ChiffresRemplis = new List<int>();
            List<int> colonne3ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne3ChiffresRemplis, colonne3ChiffresPossibles, 3);

            List<int> colonne4ChiffresRemplis = new List<int>();
            List<int> colonne4ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne4ChiffresRemplis, colonne4ChiffresPossibles, 4);

            List<int> colonne5ChiffresRemplis = new List<int>();
            List<int> colonne5ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne5ChiffresRemplis, colonne5ChiffresPossibles, 5);

            List<int> colonne6ChiffresRemplis = new List<int>();
            List<int> colonne6ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne6ChiffresRemplis, colonne6ChiffresPossibles, 6);

            List<int> colonne7ChiffresRemplis = new List<int>();
            List<int> colonne7ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne7ChiffresRemplis, colonne7ChiffresPossibles, 7);

            List<int> colonne8ChiffresRemplis = new List<int>();
            List<int> colonne8ChiffresPossibles = new List<int>();
            creationAffichageColonne(sudoku, colonne8ChiffresRemplis, colonne8ChiffresPossibles, 8);


            // BLOCS ---------------------------------------------------------------------------------------------------------------
            // Représentation des blocs :
            /*
            {
                {                                 },
                {    0           1           2    },
                {                                 },

                {                                 },
                {    3           4           5    },
                {                                 },

                {                                 },
                {    6           7           8    },
                {                                 }
            };
            */

            // BLOC 0
            List<int> bloc0ChiffresRemplis = new List<int>();
            List<int> bloc0ChiffresPossibles = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                if (sudoku[0, i] != 0)
                {
                    bloc0ChiffresRemplis.Add(sudoku[0, i]);
                }
                if (sudoku[1, i] != 0)
                {
                    bloc0ChiffresRemplis.Add(sudoku[1, i]);
                }
                if (sudoku[2, i] != 0)
                {
                    bloc0ChiffresRemplis.Add(sudoku[2, i]);
                }
            }
            affichageBloc(sudoku, bloc0ChiffresRemplis, bloc0ChiffresPossibles, 0);
            // BLOC 1
            List<int> bloc1ChiffresRemplis = new List<int>();
            List<int> bloc1ChiffresPossibles = new List<int>();
            for (int i = 3; i < 6; i++)
            {
                if (sudoku[0, i] != 0)
                {
                    bloc1ChiffresRemplis.Add(sudoku[0, i]);
                }
                if (sudoku[1, i] != 0)
                {
                    bloc1ChiffresRemplis.Add(sudoku[1, i]);
                }
                if (sudoku[2, i] != 0)
                {
                    bloc1ChiffresRemplis.Add(sudoku[2, i]);
                }
            }
            affichageBloc(sudoku, bloc1ChiffresRemplis, bloc1ChiffresPossibles, 1);
            // BLOC 2
            List<int> bloc2ChiffresRemplis = new List<int>();
            List<int> bloc2ChiffresPossibles = new List<int>();
            for (int i = 6; i < 9; i++)
            {
                if (sudoku[0, i] != 0)
                {
                    bloc2ChiffresRemplis.Add(sudoku[0, i]);
                }
                if (sudoku[1, i] != 0)
                {
                    bloc2ChiffresRemplis.Add(sudoku[1, i]);
                }
                if (sudoku[2, i] != 0)
                {
                    bloc2ChiffresRemplis.Add(sudoku[2, i]);
                }
            }
            affichageBloc(sudoku, bloc2ChiffresRemplis, bloc2ChiffresPossibles, 2);
            // BLOC 3
            List<int> bloc3ChiffresRemplis = new List<int>();
            List<int> bloc3ChiffresPossibles = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                if (sudoku[3, i] != 0)
                {
                    bloc3ChiffresRemplis.Add(sudoku[3, i]);
                }
                if (sudoku[4, i] != 0)
                {
                    bloc3ChiffresRemplis.Add(sudoku[4, i]);
                }
                if (sudoku[5, i] != 0)
                {
                    bloc3ChiffresRemplis.Add(sudoku[5, i]);
                }
            }
            affichageBloc(sudoku, bloc3ChiffresRemplis, bloc3ChiffresPossibles, 3);
            // BLOC 4
            List<int> bloc4ChiffresRemplis = new List<int>();
            List<int> bloc4ChiffresPossibles = new List<int>();
            for (int i = 3; i < 6; i++)
            {
                if (sudoku[3, i] != 0)
                {
                    bloc4ChiffresRemplis.Add(sudoku[3, i]);
                }
                if (sudoku[4, i] != 0)
                {
                    bloc4ChiffresRemplis.Add(sudoku[4, i]);
                }
                if (sudoku[5, i] != 0)
                {
                    bloc4ChiffresRemplis.Add(sudoku[5, i]);
                }
            }
            affichageBloc(sudoku, bloc4ChiffresRemplis, bloc4ChiffresPossibles, 4);
            // BLOC 5
            List<int> bloc5ChiffresRemplis = new List<int>();
            List<int> bloc5ChiffresPossibles = new List<int>();
            for (int i = 6; i < 9; i++)
            {
                if (sudoku[3, i] != 0)
                {
                    bloc5ChiffresRemplis.Add(sudoku[3, i]);
                }
                if (sudoku[4, i] != 0)
                {
                    bloc5ChiffresRemplis.Add(sudoku[4, i]);
                }
                if (sudoku[5, i] != 0)
                {
                    bloc5ChiffresRemplis.Add(sudoku[5, i]);
                }
            }
            affichageBloc(sudoku, bloc5ChiffresRemplis, bloc5ChiffresPossibles, 5);
            // BLOC 6
            List<int> bloc6ChiffresRemplis = new List<int>();
            List<int> bloc6ChiffresPossibles = new List<int>();
            for (int i = 0; i < 3; i++)
            {
                if (sudoku[6, i] != 0)
                {
                    bloc6ChiffresRemplis.Add(sudoku[6, i]);
                }
                if (sudoku[7, i] != 0)
                {
                    bloc6ChiffresRemplis.Add(sudoku[7, i]);
                }
                if (sudoku[8, i] != 0)
                {
                    bloc6ChiffresRemplis.Add(sudoku[8, i]);
                }
            }
            affichageBloc(sudoku, bloc6ChiffresRemplis, bloc6ChiffresPossibles, 6);
            // BLOC 7
            List<int> bloc7ChiffresRemplis = new List<int>();
            List<int> bloc7ChiffresPossibles = new List<int>();
            for (int i = 3; i < 6; i++)
            {
                if (sudoku[6, i] != 0)
                {
                    bloc7ChiffresRemplis.Add(sudoku[6, i]);
                }
                if (sudoku[7, i] != 0)
                {
                    bloc7ChiffresRemplis.Add(sudoku[7, i]);
                }
                if (sudoku[8, i] != 0)
                {
                    bloc7ChiffresRemplis.Add(sudoku[8, i]);
                }
            }
            affichageBloc(sudoku, bloc7ChiffresRemplis, bloc7ChiffresPossibles, 7);
            // BLOC 8
            List<int> bloc8ChiffresRemplis = new List<int>();
            List<int> bloc8ChiffresPossibles = new List<int>();
            for (int i = 6; i < 9; i++)
            {
                if (sudoku[6, i] != 0)
                {
                    bloc8ChiffresRemplis.Add(sudoku[6, i]);
                }
                if (sudoku[7, i] != 0)
                {
                    bloc8ChiffresRemplis.Add(sudoku[7, i]);
                }
                if (sudoku[8, i] != 0)
                {
                    bloc8ChiffresRemplis.Add(sudoku[8, i]);
                }
            }
            affichageBloc(sudoku, bloc8ChiffresRemplis, bloc8ChiffresPossibles, 8);

            
            List<int> case00ChiffresPossibles = new List<int>();
            if (sudoku[0, 0] == 0)
            {
                for (int i = 1; i < 10; i++)
                {
                    if (ligne0ChiffresPossibles.Contains(i) && colonne0ChiffresPossibles.Contains(i) && bloc0ChiffresPossibles.Contains(i))
                    {
                        case00ChiffresPossibles.Add(i);
                    }
                }
            }
            Console.WriteLine("TEST AFFICHAGE :");
            for (int i = 0; i < case00ChiffresPossibles.Count(); i++)
            {
                Console.Write(case00ChiffresPossibles[i]);
            }

           


            // PROGRAMME
            // CALCUL DU NOMBRE DE CASES REMPLIES
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                for (int j = 0; j < sudoku.GetLength(1); j++)
                {
                    if (sudoku[i,j] != 0)
                    {
                        casesRemplies += 1;
                    }
                }
            }
        }
        // FONCTIONS
        // SUDOKU ------------------------------------------------------------------------------------------------------------------
            // FONCTION D'AFFICHAGE DU SUDOKU
        public static void afficherSudoku(int[,] sudoku)
        {
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                for (int j = 0; j < sudoku.GetLength(1); j++)
                {
                    Console.Write(sudoku[i, j]);
                }
                Console.WriteLine();
            }
        }
        // LIGNES ------------------------------------------------------------------------------------------------------------------
            // FONCTION DE CRÉATION DE LA LISTE CONTENANT TOUS LES CHIFFRES DÉJÀ PRÉSENTS DANS LA LIGNE X DU SUDOKU
        public static void ligneChiffresRemplis(int[,] sudoku, List <int> ligne, int indexLigne)
        {
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                if (sudoku[indexLigne, i] != 0)
                {
                    ligne.Add(sudoku[indexLigne, i]);
                }
            }
        }
            // FONCTION DE CRÉATION DE LA LISTE CONTENANT TOUS LES CHIFFRES NON PRÉSENTS ET DONC POSSIBLES DANS LA LIGNE X DU SUDOKU
        public static void ligneChiffresPossibles(List <int> ligneChiffresRemplis, List <int> ligneChiffresPossibles)
        {
            for (int i = 0; i < ligneChiffresRemplis.Count(); i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (ligneChiffresRemplis[i] != j && !(ligneChiffresRemplis.Contains(j)) && !(ligneChiffresPossibles.Contains(j)))
                    {
                        ligneChiffresPossibles.Add(j);
                    }
                }
            }
        }
            // AFFICHAGE DE LA LIGNE DU SUDOKU
        public static void afficherLigne(List <int> ligne)
        {
            for (int i = 0; i < ligne.Count(); i++)
            {
                Console.Write(ligne[i]);
            }
        }
            // CRÉATION DES LISTES DE CHIFFRES REMPLIS ET POSSIBLES POUR LA LIGNE X ET AFFICHAGE
        public static void creationAffichageLigne(int[,] sudoku, List <int> ligneChiffresRemplisList, List <int> ligneChiffresPossiblesList, int indexLigne)
        {
            ligneChiffresRemplis(sudoku, ligneChiffresRemplisList, indexLigne);
            ligneChiffresPossibles(ligneChiffresRemplisList, ligneChiffresPossiblesList);
            Console.WriteLine("\n\nChiffres remplis sur la ligne " + indexLigne + " :");
            afficherLigne(ligneChiffresRemplisList);
            Console.WriteLine("\nChiffres possibles sur la ligne " + indexLigne + " :");
            afficherLigne(ligneChiffresPossiblesList);
        }
        // COLONNES ----------------------------------------------------------------------------------------------------------------
            // FONCTION DE CRÉATION DE LA COLONNE CONTENANT TOUS LES CHIFFRES DÉJÀ PRÉSENTS DANS LA COLONNE X DU SUDOKU
        public static void colonneChiffresRemplis(int[,] sudoku, List<int> colonne, int indexColonne)
        {
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                if (sudoku[i, indexColonne] != 0)
                {
                    colonne.Add(sudoku[i, indexColonne]);
                }
            }
        }
            // FONCTION DE CRÉATION DE LA LISTE CONTENANT TOUS LES CHIFFRES NON PRÉSENTS ET DONC POSSIBLES DANS LA COLONNE X DU SUDOKU
        public static void colonneChiffresPossibles(List<int> colonneChiffresRemplis, List<int> colonneChiffresPossibles)
        {
            for (int i = 0; i < colonneChiffresRemplis.Count(); i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (colonneChiffresRemplis[i] != j && !(colonneChiffresRemplis.Contains(j)) && !(colonneChiffresPossibles.Contains(j)))
                    {
                        colonneChiffresPossibles.Add(j);
                    }
                }
            }
        }
            // AFFICHAGE DE LA COLONNE DU SUDOKU
        public static void afficherColonne(List<int> colonne)
        {
            for (int i = 0; i < colonne.Count(); i++)
            {
                Console.Write(colonne[i]);
            }
        }
        // CRÉATION DES LISTES DE CHIFFRES REMPLIS ET POSSIBLES POUR LA COLONNE X ET AFFICHAGE
        public static void creationAffichageColonne(int[,] sudoku, List<int> colonneChiffresRemplisList, List<int> colonneChiffresPossiblesList, int indexColonne)
        {
            colonneChiffresRemplis(sudoku, colonneChiffresRemplisList, indexColonne);
            colonneChiffresPossibles(colonneChiffresRemplisList, colonneChiffresPossiblesList);
            Console.WriteLine("\n\nChiffres remplis sur la colonne " + indexColonne + " :");
            afficherColonne(colonneChiffresRemplisList);
            Console.WriteLine("\nChiffres possibles sur la colonne " + indexColonne + " :");
            afficherColonne(colonneChiffresPossiblesList);
        }

        // BLOCS -------------------------------------------------------------------------------------------------------------------
        // FONCTION DE CRÉATION DE LA LISTE CONTENANT TOUS LES CHIFFRES NON PRÉSENTS ET DONC POSSIBLES DANS LE BLOC X DU SUDOKU
        public static void blocChiffresPossibles(List<int> blocChiffresRemplis, List<int> blocChiffresPossibles)
        {
            for (int i = 0; i < blocChiffresRemplis.Count(); i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    if (blocChiffresRemplis[i] != j && !(blocChiffresRemplis.Contains(j)) && !(blocChiffresPossibles.Contains(j)))
                    {
                        blocChiffresPossibles.Add(j);
                    }
                }
            }
        }
        // AFFICHAGE DE LA COLONNE DU SUDOKU
        public static void afficherBloc(List<int> bloc)
        {
            for (int i = 0; i < bloc.Count(); i++)
            {
                Console.Write(bloc[i]);
            }
        }
        // CRÉATION DES LISTES DE CHIFFRES REMPLIS ET POSSIBLES POUR LE BLOC X ET AFFICHAGE
        public static void affichageBloc(int[,] sudoku, List<int> blocChiffresRemplisList, List<int> blocChiffresPossiblesList, int indexBloc)
        {
            blocChiffresPossibles(blocChiffresRemplisList, blocChiffresPossiblesList);
            Console.WriteLine("\n\nChiffres remplis sur le bloc " + indexBloc + " :");
            afficherBloc(blocChiffresRemplisList);
            Console.WriteLine("\nChiffres possibles sur le bloc " + indexBloc + " :");
            afficherBloc(blocChiffresPossiblesList);
        }
    }
}