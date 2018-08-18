using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoteGame.Model.Interfaces;

namespace YoteGame.Model
{
    public class MinMax : IMinMax
    {
        public State_Space Gagnant(State_Space[,] board)
        {
            int i, j;
            int j1 = 0, j2 = 0;

            nb_series(board, ref j1, ref j2, 3);

            if (j1 > 0)
            {
                return State_Space.One;
            }
            else if (j2 > 0)
            {
                return State_Space.Two;
            }
            else
            {
                //Si le board n'est pas fini et que personne n'a gagné, on renvoie 0
                for (i = 0; i < Program.row_board_count; i++)
                {
                    for (j = 0; j < Program.column_board_count; j++)
                    {
                        if (board[i,j] == State_Space.None)
                        {
                            return State_Space.None;
                        }
                    }
                }
            }

            //Si le board est fini et que personne n'a gagné, on renvoie 3
            return State_Space.None;
        }

        public void IA_jouer(State_Space[,] board, int profondeur)
        {
            int max = -int.MaxValue;
            int tmp, maxi = 0, maxj = 0;

            // -- Read through all row
            for (int x = 0; x < Program.row_board_count; x++)
            {
                // -- Read through all column
                for (int y = 0; y < Program.column_board_count; y++)
                {
                    if (board[x,y] == State_Space.None)
                    {
                        // -- Simulationn
                        Simulation(board, x, y, State_Space.Two);

                        tmp = Min_Human(board, profondeur - 1);

                        if (tmp > max)
                        {
                            max = tmp;
                            maxi = x;
                            maxj = y;
                        }

                        // -- Cancellation
                        Cancellation(board, x, y);
                    }
                }
            }

            board[maxi,maxj] = State_Space.One;
        }

        public int Max_Computer(State_Space[,] board, int profondeur)
        {
            if (profondeur == 0 || Gagnant(board) != State_Space.None)
            {
                return Evaluation(board);
            }

            int max = -int.MaxValue, tmp;

            // -- Read through all row
            for (int x = 0; x < Program.row_board_count; x++)
            {
                // -- Read through all column
                for (int y = 0; y < Program.column_board_count; y++)
                {
                    if (board[x,y] == State_Space.None)
                    {
                        // -- Simulationn
                        Simulation(board, x, y, State_Space.Two);

                        tmp = Min_Human(board, profondeur - 1);

                        if (tmp > max)
                        {
                            max = tmp;
                        }

                        // -- Cancellation
                        Cancellation(board, x, y);
                    }
                }
            }

            return max;
        }

        public int Min_Human(State_Space[,] board, int profondeur)
        {
            if (profondeur == 0 || Gagnant(board) != State_Space.None)
            {
                return Evaluation(board);
            }

            int min = int.MaxValue, tmp;

            for (int x = 0; x < Program.row_board_count; x++)
            {
                for (int y = 0; y < Program.column_board_count; y++)
                {
                    if (board[x,y] == State_Space.None)
                    {
                        // -- Simulationn
                        Simulation(board, x, y, State_Space.One);

                        tmp = Max_Computer(board, profondeur - 1);

                        if (tmp < min)
                        {
                            min = tmp;
                        }

                        // -- Cancellation -- //
                        Cancellation(board, x, y);
                    }
                }
            }

            return min;
        }

        //Compte le nombre de séries de n pions alignés de chacun des joueurs
        public void nb_series(State_Space[,] board, ref int series_j1, ref int series_j2, int n) 
        {
            int compteur1, compteur2;

            series_j1 = 0;
            series_j2 = 0;

            compteur1 = 0;
            compteur2 = 0;

            //Diagonale descendante
            for (int x = 0; x < Program.row_board_count; x++)
            {
                if (board[x,x] == State_Space.One)
                {
                    compteur1++;
                    compteur2 = 0;

                    if (compteur1 == n)
                    {
                        series_j1++;
                    }
                }
                else if (board[x,x] == State_Space.Two)
                {
                    compteur2++;
                    compteur1 = 0;

                    if (compteur2 == n)
                    {
                        series_j2++;
                    }
                }
            }

            compteur1 = 0;
            compteur2 = 0;

            //Diagonale montante
            for (int x = 0; x < Program.row_board_count; x++)
            {
                if (board[x,2 - x] == State_Space.One)
                {
                    compteur1++;
                    compteur2 = 0;

                    if (compteur1 == n)
                    {
                        series_j1++;
                    }
                }
                else if (board[x,2 - x] == State_Space.Two)
                {
                    compteur2++;
                    compteur1 = 0;

                    if (compteur2 == n)
                    {
                        series_j2++;
                    }
                }
            }

            //En ligne
            for (int i = 0; i < Program.row_board_count; i++)
            {
                compteur1 = 0;
                compteur2 = 0;

                //Horizontalement
                for (int j = 0; j < Program.column_board_count; j++)
                {
                    if (board[i,j] == State_Space.One)
                    {
                        compteur1++;
                        compteur2 = 0;

                        if (compteur1 == n)
                        {
                            series_j1++;
                        }
                    }
                    else if (board[i,j] == State_Space.Two)
                    {
                        compteur2++;
                        compteur1 = 0;

                        if (compteur2 == n)
                        {
                            series_j2++;
                        }
                    }
                }

                compteur1 = 0;
                compteur2 = 0;

                //Verticalement
                for (int j = 0; j < Program.column_board_count; j++)
                {
                    if (board[j,i] == State_Space.One)
                    {
                        compteur1++;
                        compteur2 = 0;

                        if (compteur1 == n)
                        {
                            series_j1++;
                        }
                    }
                    else if (board[j,i] == State_Space.Two)
                    {
                        compteur2++;
                        compteur1 = 0;

                        if (compteur2 == n)
                        {
                            series_j2++;
                        }
                    }
                }
            }
        }

        public int Evaluation(State_Space[,] board)
        {
            State_Space vainqueur;
            int nb_de_pions = 0;

            //On compte le nombre de pions présents sur le plateau
            for (int i = 0; i < Program.row_board_count; i++)
            {
                for (int j = 0; j < Program.column_board_count; j++)
                {
                    if (board[i,j] != State_Space.None)
                    {
                        nb_de_pions++;
                    }
                }
            }

            if ((vainqueur = Gagnant(board)) != State_Space.None)
            {
                if (vainqueur == State_Space.One)
                {
                    return 1000 - nb_de_pions;
                }
                else if (vainqueur == State_Space.Two)
                {
                    return -1000 + nb_de_pions;
                }
                else
                {
                    return 0;
                }
            }

            //On compte le nombre de séries de 2 pions alignés de chacun des joueurs
            int series_j1 = 0, series_j2 = 0;

            nb_series(board, ref series_j1, ref series_j2, 2);

            return series_j1 - series_j2;

        }

        public void Simulation(State_Space[,] board, int rowLocation, int ColumnLocation, State_Space stape_space)
        {
            board[rowLocation, ColumnLocation] = stape_space;
        }

        public void Cancellation(State_Space[,] board, int rowLocation, int ColumnLocation)
        {
            board[rowLocation, ColumnLocation] = State_Space.None;
        }
    }
}
