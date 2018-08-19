using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoteGame.Model.Static
{
    public static class YoteClass
    {
        public static readonly Random ran = new Random();

        public static Boolean isValue(string[] value)
        {
            foreach (var val in value)
            {
                if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
                    return false;
            }

            return true;
        }

        public static State_Space[,] CloneBoard(State_Space[,] board)
        {
            var boardClone = new State_Space[Program.row_board_count, Program.column_board_count];
            for (int _x = 0; _x < Program.row_board_count; _x++)
            {
                for (int _y = 0; _y < Program.column_board_count; _y++)
                {
                    boardClone[_x, _y] = board[_x, _y];
                }
            }
            return boardClone;
        }

        public static List<Space> SpaceOpponentBoard(State_Space[,] board, State_Space state_space_player)
        {
            var liste = new List<Space>();

            for (int _x = 0; _x < Program.row_board_count; _x++)
            {
                for (int _y = 0; _y < Program.column_board_count; _y++)
                {
                    if (board[_x, _y] == state_space_player)
                        liste.Add(new Space(_x, _y));
                }
            }
            return liste;
        }

        public static Boolean IsVictory(State_Space[,] board, Type_Player type_player)
        {
            State_Space opponent = (type_player ==  Type_Player.One) ? State_Space.One
                                                                     : State_Space.Two;

            for (int _x = 0; _x < Program.row_board_count; _x++)
            {
                for (int _y = 0; _y < Program.column_board_count; _y++)
                {
                    if (board[_x, _y] == opponent)
                        return false;
                }
            }

            return true;
        }

        public static Boolean IsPreviousAction(Player player, Space space, Space block, Boolean actionFree)
        {
            if (player.tokens.FirstOrDefault(l => l.Row == space.Row && l.Column == space.Column).Moves.Count > 1 && !actionFree)
            {
                int count_moves = player.tokens.FirstOrDefault(l => l.Row == space.Row && l.Column == space.Column).Moves.Count;

                if (player.tokens.FirstOrDefault(l => l.Row == space.Row && l.Column == space.Column).Moves[count_moves - 2].Row == block.Row &&
                    player.tokens.FirstOrDefault(l => l.Row == space.Row && l.Column == space.Column).Moves[count_moves - 2].Column == block.Column)
                {
                    if (Math.Abs(player.tokens.FirstOrDefault(l => l.Row == space.Row && l.Column == space.Column).Moves[count_moves - 2].Row - space.Row) > 1 ||
                        Math.Abs(player.tokens.FirstOrDefault(l => l.Row == space.Row && l.Column == space.Column).Moves[count_moves - 2].Column - space.Column) > 1)
                    {
                        return false;
                    }

                    return true;
                }
            }

            return false;
        }

        public static Space WinTokenExist(Space new_space, Space CurrentToken)
        {
            Space win_token = null;

            try
            {
                if (Math.Abs(CurrentToken.Row - new_space.Row) > 1)
                {
                    win_token = new Space(
                                    (CurrentToken.Row > new_space.Row) ? CurrentToken.Row - 1
                                                                       : CurrentToken.Row + 1,
                                    CurrentToken.Column
                                );
                }
                else if (Math.Abs(CurrentToken.Column - new_space.Column) > 1)
                {
                    win_token = new Space(
                                    CurrentToken.Row,
                                    (CurrentToken.Column > new_space.Column) ? CurrentToken.Column - 1
                                                                             : CurrentToken.Column + 1
                                );
                }
            }
            catch { }

            return win_token;
        }
    }
}
