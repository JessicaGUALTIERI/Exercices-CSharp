using System;
using System.Linq;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // GRILLE DE BASE
            int[,] sudoku =
            {
                { 0, 5, 0,    2, 0, 0,    0, 0, 0 },
                { 0, 8, 9,    0, 7, 5,    6, 4, 3 },
                { 3, 7, 6,    0, 0, 0,    0, 0, 2 },

                { 0, 2, 8,    0, 4, 0,    0, 0, 0 },
                { 1, 0, 0,    0, 0, 0,    0, 0, 8 },
                { 0, 0, 0,    0, 1, 0,    7, 6, 0 },

                { 7, 0, 0,    0, 0, 0,    8, 2, 1 },
                { 5, 9, 2,    3, 8, 0,    4, 7, 0 },
                { 0, 0, 0,    0, 0, 6,    0, 9, 0 }
            };
            /*
            int[,] sudoku =
            {
                { 0, 0, 0,    0, 0, 0,    0, 0, 0 },
                { 0, 0, 0,    0, 0, 0,    0, 0, 0 },
                { 0, 0, 0,    0, 0, 0,    0, 0, 0 },

                { 0, 0, 0,    0, 0, 0,    0, 0, 0 },
                { 0, 0, 0,    0, 0, 0,    0, 0, 0 },
                { 0, 0, 0,    0, 0, 0,    0, 0, 0 },

                { 0, 0, 0,    0, 0, 0,    0, 0, 0 },
                { 0, 0, 0,    0, 0, 0,    0, 0, 0 },
                { 0, 0, 0,    0, 0, 0,    0, 0, 0 }
            };
            */

            // CASES REMPLIES DANS LA GRILLE DE BASE (CONDITIONS D'ARRÊT DE LA BOUCLE WHILE DU RÉSOLVEUR)
            int casesRemplies = 0;



            // CALCUL DU NOMBRE DE CASES REMPLIES
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                for (int j = 0; j < sudoku.GetLength(1); j++)
                {
                    if (sudoku[i, j] != 0)
                    {
                        casesRemplies += 1;
                    }
                }
            }

            // BOUCLE WHILE DE RÉSOLUTION, CONDITION DE SORTIE : TOUTES LES CASES SONT REMPLIES
            while (casesRemplies != 81)
            {
                // On réinitialise la variable 'bloc'
                int bloc = -1;

                // Début de la boucle for pour parcourir les lignes (i)
                for (int i = 0; i < sudoku.GetLength(0); i++)
                {
                    // Début de la boucle for pour parcourir les colonnes (j)
                    for (int j = 0; j < sudoku.GetLength(1); j++)
                    {
                        // -----------------------------------------------------------LIGNES-----------------------------------------------------------
                        // Calcul des chiffres possibles sur chaque ligne :
                        List<int> ligne0ChiffresRemplis = new List<int>();
                        List<int> ligne0ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne0ChiffresRemplis, ligne0ChiffresPossibles, 0);

                        List<int> ligne1ChiffresRemplis = new List<int>();
                        List<int> ligne1ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne1ChiffresRemplis, ligne1ChiffresPossibles, 1);

                        List<int> ligne2ChiffresRemplis = new List<int>();
                        List<int> ligne2ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne2ChiffresRemplis, ligne2ChiffresPossibles, 2);

                        List<int> ligne3ChiffresRemplis = new List<int>();
                        List<int> ligne3ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne3ChiffresRemplis, ligne3ChiffresPossibles, 3);

                        List<int> ligne4ChiffresRemplis = new List<int>();
                        List<int> ligne4ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne4ChiffresRemplis, ligne4ChiffresPossibles, 4);

                        List<int> ligne5ChiffresRemplis = new List<int>();
                        List<int> ligne5ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne5ChiffresRemplis, ligne5ChiffresPossibles, 5);

                        List<int> ligne6ChiffresRemplis = new List<int>();
                        List<int> ligne6ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne6ChiffresRemplis, ligne6ChiffresPossibles, 6);

                        List<int> ligne7ChiffresRemplis = new List<int>();
                        List<int> ligne7ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne7ChiffresRemplis, ligne7ChiffresPossibles, 7);

                        List<int> ligne8ChiffresRemplis = new List<int>();
                        List<int> ligne8ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesLignes(sudoku, ligne8ChiffresRemplis, ligne8ChiffresPossibles, 8);

                        // On regroupe les calculs pour chaque ligne :
                        Dictionary<int, List<int>> lignes = new Dictionary<int, List<int>>();
                        lignes.Add(0, ligne0ChiffresPossibles);
                        lignes.Add(1, ligne1ChiffresPossibles);
                        lignes.Add(2, ligne2ChiffresPossibles);
                        lignes.Add(3, ligne3ChiffresPossibles);
                        lignes.Add(4, ligne4ChiffresPossibles);
                        lignes.Add(5, ligne5ChiffresPossibles);
                        lignes.Add(6, ligne6ChiffresPossibles);
                        lignes.Add(7, ligne7ChiffresPossibles);
                        lignes.Add(8, ligne8ChiffresPossibles);


                        // ----------------------------------------------------------COLONNES----------------------------------------------------------
                        // Calcul des chiffres possibles sur chaque colonne :
                        List<int> colonne0ChiffresRemplis = new List<int>();
                        List<int> colonne0ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne0ChiffresRemplis, colonne0ChiffresPossibles, 0);

                        List<int> colonne1ChiffresRemplis = new List<int>();
                        List<int> colonne1ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne1ChiffresRemplis, colonne1ChiffresPossibles, 1);

                        List<int> colonne2ChiffresRemplis = new List<int>();
                        List<int> colonne2ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne2ChiffresRemplis, colonne2ChiffresPossibles, 2);

                        List<int> colonne3ChiffresRemplis = new List<int>();
                        List<int> colonne3ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne3ChiffresRemplis, colonne3ChiffresPossibles, 3);

                        List<int> colonne4ChiffresRemplis = new List<int>();
                        List<int> colonne4ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne4ChiffresRemplis, colonne4ChiffresPossibles, 4);

                        List<int> colonne5ChiffresRemplis = new List<int>();
                        List<int> colonne5ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne5ChiffresRemplis, colonne5ChiffresPossibles, 5);

                        List<int> colonne6ChiffresRemplis = new List<int>();
                        List<int> colonne6ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne6ChiffresRemplis, colonne6ChiffresPossibles, 6);

                        List<int> colonne7ChiffresRemplis = new List<int>();
                        List<int> colonne7ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne7ChiffresRemplis, colonne7ChiffresPossibles, 7);

                        List<int> colonne8ChiffresRemplis = new List<int>();
                        List<int> colonne8ChiffresPossibles = new List<int>();
                        calculChiffresPossiblesColonnes(sudoku, colonne8ChiffresRemplis, colonne8ChiffresPossibles, 8);

                        // On regroupe les calculs pour chaque colonne :
                        Dictionary<int, List<int>> colonnes = new Dictionary<int, List<int>>();
                        colonnes.Add(0, colonne0ChiffresPossibles);
                        colonnes.Add(1, colonne1ChiffresPossibles);
                        colonnes.Add(2, colonne2ChiffresPossibles);
                        colonnes.Add(3, colonne3ChiffresPossibles);
                        colonnes.Add(4, colonne4ChiffresPossibles);
                        colonnes.Add(5, colonne5ChiffresPossibles);
                        colonnes.Add(6, colonne6ChiffresPossibles);
                        colonnes.Add(7, colonne7ChiffresPossibles);
                        colonnes.Add(8, colonne8ChiffresPossibles);

                        // ------------------------------------------------------------BLOCS------------------------------------------------------------
                        // On regroupe les calculs pour chaque ligne :
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
                        List<int> bloc0ChiffresRemplis = new List<int>();
                        List<int> bloc0ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 0; blocIndexColonnes < 3; blocIndexColonnes++)
                        {
                            if (sudoku[0, blocIndexColonnes] != 0)
                            {
                                bloc0ChiffresRemplis.Add(sudoku[0, blocIndexColonnes]);
                            }
                            if (sudoku[1, blocIndexColonnes] != 0)
                            {
                                bloc0ChiffresRemplis.Add(sudoku[1, blocIndexColonnes]);
                            }
                            if (sudoku[2, blocIndexColonnes] != 0)
                            {
                                bloc0ChiffresRemplis.Add(sudoku[2, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc0ChiffresRemplis, bloc0ChiffresPossibles);

                        List<int> bloc1ChiffresRemplis = new List<int>();
                        List<int> bloc1ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 3; blocIndexColonnes < 6; blocIndexColonnes++)
                        {
                            if (sudoku[0, blocIndexColonnes] != 0)
                            {
                                bloc1ChiffresRemplis.Add(sudoku[0, blocIndexColonnes]);
                            }
                            if (sudoku[1, blocIndexColonnes] != 0)
                            {
                                bloc1ChiffresRemplis.Add(sudoku[1, blocIndexColonnes]);
                            }
                            if (sudoku[2, blocIndexColonnes] != 0)
                            {
                                bloc1ChiffresRemplis.Add(sudoku[2, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc1ChiffresRemplis, bloc1ChiffresPossibles);

                        List<int> bloc2ChiffresRemplis = new List<int>();
                        List<int> bloc2ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 6; blocIndexColonnes < 9; blocIndexColonnes++)
                        {
                            if (sudoku[0, blocIndexColonnes] != 0)
                            {
                                bloc2ChiffresRemplis.Add(sudoku[0, blocIndexColonnes]);
                            }
                            if (sudoku[1, blocIndexColonnes] != 0)
                            {
                                bloc2ChiffresRemplis.Add(sudoku[1, blocIndexColonnes]);
                            }
                            if (sudoku[2, blocIndexColonnes] != 0)
                            {
                                bloc2ChiffresRemplis.Add(sudoku[2, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc2ChiffresRemplis, bloc2ChiffresPossibles);

                        List<int> bloc3ChiffresRemplis = new List<int>();
                        List<int> bloc3ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 0; blocIndexColonnes < 3; blocIndexColonnes++)
                        {
                            if (sudoku[3, blocIndexColonnes] != 0)
                            {
                                bloc3ChiffresRemplis.Add(sudoku[3, blocIndexColonnes]);
                            }
                            if (sudoku[4, blocIndexColonnes] != 0)
                            {
                                bloc3ChiffresRemplis.Add(sudoku[4, blocIndexColonnes]);
                            }
                            if (sudoku[5, blocIndexColonnes] != 0)
                            {
                                bloc3ChiffresRemplis.Add(sudoku[5, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc3ChiffresRemplis, bloc3ChiffresPossibles);

                        List<int> bloc4ChiffresRemplis = new List<int>();
                        List<int> bloc4ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 3; blocIndexColonnes < 6; blocIndexColonnes++)
                        {
                            if (sudoku[3, blocIndexColonnes] != 0)
                            {
                                bloc4ChiffresRemplis.Add(sudoku[3, blocIndexColonnes]);
                            }
                            if (sudoku[4, blocIndexColonnes] != 0)
                            {
                                bloc4ChiffresRemplis.Add(sudoku[4, blocIndexColonnes]);
                            }
                            if (sudoku[5, blocIndexColonnes] != 0)
                            {
                                bloc4ChiffresRemplis.Add(sudoku[5, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc4ChiffresRemplis, bloc4ChiffresPossibles);

                        List<int> bloc5ChiffresRemplis = new List<int>();
                        List<int> bloc5ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 6; blocIndexColonnes < 9; blocIndexColonnes++)
                        {
                            if (sudoku[3, blocIndexColonnes] != 0)
                            {
                                bloc5ChiffresRemplis.Add(sudoku[3, blocIndexColonnes]);
                            }
                            if (sudoku[4, blocIndexColonnes] != 0)
                            {
                                bloc5ChiffresRemplis.Add(sudoku[4, blocIndexColonnes]);
                            }
                            if (sudoku[5, blocIndexColonnes] != 0)
                            {
                                bloc5ChiffresRemplis.Add(sudoku[5, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc5ChiffresRemplis, bloc5ChiffresPossibles);

                        List<int> bloc6ChiffresRemplis = new List<int>();
                        List<int> bloc6ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 0; blocIndexColonnes < 3; blocIndexColonnes++)
                        {
                            if (sudoku[6, blocIndexColonnes] != 0)
                            {
                                bloc6ChiffresRemplis.Add(sudoku[6, blocIndexColonnes]);
                            }
                            if (sudoku[7, blocIndexColonnes] != 0)
                            {
                                bloc6ChiffresRemplis.Add(sudoku[7, blocIndexColonnes]);
                            }
                            if (sudoku[8, blocIndexColonnes] != 0)
                            {
                                bloc6ChiffresRemplis.Add(sudoku[8, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc6ChiffresRemplis, bloc6ChiffresPossibles);

                        List<int> bloc7ChiffresRemplis = new List<int>();
                        List<int> bloc7ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 3; blocIndexColonnes < 6; blocIndexColonnes++)
                        {
                            if (sudoku[6, blocIndexColonnes] != 0)
                            {
                                bloc7ChiffresRemplis.Add(sudoku[6, blocIndexColonnes]);
                            }
                            if (sudoku[7, blocIndexColonnes] != 0)
                            {
                                bloc7ChiffresRemplis.Add(sudoku[7, blocIndexColonnes]);
                            }
                            if (sudoku[8, blocIndexColonnes] != 0)
                            {
                                bloc7ChiffresRemplis.Add(sudoku[8, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc7ChiffresRemplis, bloc7ChiffresPossibles);

                        List<int> bloc8ChiffresRemplis = new List<int>();
                        List<int> bloc8ChiffresPossibles = new List<int>();
                        for (int blocIndexColonnes = 6; blocIndexColonnes < 9; blocIndexColonnes++)
                        {
                            if (sudoku[6, blocIndexColonnes] != 0)
                            {
                                bloc8ChiffresRemplis.Add(sudoku[6, blocIndexColonnes]);
                            }
                            if (sudoku[7, blocIndexColonnes] != 0)
                            {
                                bloc8ChiffresRemplis.Add(sudoku[7, blocIndexColonnes]);
                            }
                            if (sudoku[8, blocIndexColonnes] != 0)
                            {
                                bloc8ChiffresRemplis.Add(sudoku[8, blocIndexColonnes]);
                            }
                        }
                        calculChiffresPossiblesBloc(bloc8ChiffresRemplis, bloc8ChiffresPossibles);

                        // On regroupe les calculs pour chaque bloc :
                        Dictionary<int, List<int>> blocs = new Dictionary<int, List<int>>();
                        blocs.Add(0, bloc0ChiffresPossibles);
                        blocs.Add(1, bloc1ChiffresPossibles);
                        blocs.Add(2, bloc2ChiffresPossibles);
                        blocs.Add(3, bloc3ChiffresPossibles);
                        blocs.Add(4, bloc4ChiffresPossibles);
                        blocs.Add(5, bloc5ChiffresPossibles);
                        blocs.Add(6, bloc6ChiffresPossibles);
                        blocs.Add(7, bloc7ChiffresPossibles);
                        blocs.Add(8, bloc8ChiffresPossibles);

                        // -----------------------------------------------------RÉSOLVEUR DE SUDOKU-----------------------------------------------------
                        // Calcul pour les cases :
                        List<int> caseChiffresPossibles = new List<int>();
                        if (sudoku[i, j] == 0)
                        {
                            if (i >= 0 && i < 3 && j >= 0 && j < 3)
                            {
                                bloc = 0;
                            }
                            else if (i >= 0 && i < 3 && j >= 3 && j < 6)
                            {
                                bloc = 1;
                            }
                            else if (i >= 0 && i < 3 && j >= 6 && j < 9)
                            {
                                bloc = 2;
                            }
                            else if (i >= 3 && i < 6 && j >= 0 && j < 3)
                            {
                                bloc = 3;
                            }
                            else if (i >= 3 && i < 6 && j >= 3 && j < 6)
                            {
                                bloc = 4;
                            }
                            else if (i >= 3 && i < 6 && j >= 6 && j < 9)
                            {
                                bloc = 5;
                            }
                            else if (i >= 6 && i < 9 && j >= 0 && j < 3)
                            {
                                bloc = 6;
                            }
                            else if (i >= 6 && i < 9 && j >= 3 && j < 6)
                            {
                                bloc = 7;
                            }
                            else if (i >= 6 && i < 9 && j >= 6 && j < 9)
                            {
                                bloc = 8;
                            }

                            // Vérification des conditions
                            for (int k = 1; k < 10; k++)
                            {
                                if (lignes[i].Contains(k) && colonnes[j].Contains(k) && blocs[bloc].Contains(k))
                                {
                                    caseChiffresPossibles.Add(k);
                                }
                            }

                            // On remet à jour les listes des chiffres possibles pour chaque ligne/colonne/bloc
                            if (caseChiffresPossibles.Count() == 1)
                            {
                                casesRemplies++;
                                sudoku[i, j] = caseChiffresPossibles[0];
                                lignes[i].Remove(caseChiffresPossibles[0]);
                                colonnes[j].Remove(caseChiffresPossibles[0]);
                                blocs[bloc].Remove(caseChiffresPossibles[0]);
                            }
                        }
                    }
                }
            }
            Console.WriteLine();
            afficherSudoku(sudoku); 
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
                    if (j == 2 || j == 5) {
                        Console.Write('|');
                    }
                }
                Console.WriteLine();
                if (i == 2 || i == 5)
                {
                    Console.Write("-----------\n");
                }
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
            // CRÉATION DES LISTES DE CHIFFRES REMPLIS ET POSSIBLES POUR LA LIGNE X
        public static void calculChiffresPossiblesLignes(int[,] sudoku, List <int> ligneChiffresRemplisList, List <int> ligneChiffresPossiblesList, int indexLigne)
        {
            ligneChiffresRemplis(sudoku, ligneChiffresRemplisList, indexLigne);
            ligneChiffresPossibles(ligneChiffresRemplisList, ligneChiffresPossiblesList);
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
        // CRÉATION DES LISTES DE CHIFFRES REMPLIS ET POSSIBLES POUR LA COLONNE X
        public static void calculChiffresPossiblesColonnes(int[,] sudoku, List<int> colonneChiffresRemplisList, List<int> colonneChiffresPossiblesList, int indexColonne)
        {
            colonneChiffresRemplis(sudoku, colonneChiffresRemplisList, indexColonne);
            colonneChiffresPossibles(colonneChiffresRemplisList, colonneChiffresPossiblesList);
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
        // CRÉATION DES LISTES DE CHIFFRES REMPLIS ET POSSIBLES POUR LE BLOC X
        public static void calculChiffresPossiblesBloc(List<int> blocChiffresRemplisList, List<int> blocChiffresPossiblesList)
        {
            blocChiffresPossibles(blocChiffresRemplisList, blocChiffresPossiblesList);
        }
    }
}