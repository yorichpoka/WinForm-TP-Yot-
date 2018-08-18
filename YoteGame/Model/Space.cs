using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoteGame.Model
{
    public class Space
    {
        public int Row { get; set; }
        public int Column { get; set; }
        public State_Space State { get; set; }
        public List<Space> Moves { get; set; }

        public Space()
        {
            this.Moves = new List<Space>();
        }
        public Space(int x, int y)
        {
            this.Row = x;
            this.Column = y;
            this.State = State_Space.None;
            this.Moves = new List<Space>();
        }

        public Space(int x, int y, State_Space state)
        {
            this.Row = x;
            this.Column = y;
            this.State = state;
            this.Moves = new List<Space>();
        }

        public override string ToString()
        {
            return String.Format("({0},{1})", Row, Column);
        }

        public override bool Equals(object obj)
        {
            var space = obj as Space;
            if (space == null) return false;
            return this.Row == space.Row && this.Column == space.Column;
        }

        public override int GetHashCode()
        {
            return Row ^ Column;
        }

        public void AddMove(Space moves)
        {
            Moves.Add(moves);
        }

        public static List<Space> Enable_Space(State_Space[,] Board, Space space, Type_Player type_player)
        {
            List<Space> list = new List<Space>();
            State_Space my_state = (type_player == Type_Player.One) ? State_Space.One
                                                                    : State_Space.Two;
            Boolean have_opponent = false;

            for (int passage = 1; passage <= 4; passage++)
            {
                // -- Var 
                int row = space.Row, row_second = space.Row,
                    column = space.Column, column_second = space.Column;

                // -- Update var with passage
                switch (passage)
                {
                    case 1:
                        row = space.Row - 1;
                        row_second = space.Row - 2;
                        break;
                    case 2:
                        row = space.Row + 1;
                        row_second = space.Row + 2;
                        break;
                    case 3:
                        column = space.Column - 1;
                        column_second = space.Column - 2;
                        break;
                    default:
                        column = space.Column + 1;
                        column_second = space.Column + 2;
                        break;
                }

                // x-1, x+1, y-1, y+1
                try
                {
                    if (Board[row, column] != my_state)
                    {
                        // -- Space to mive -- //
                        if (Board[row, column] == State_Space.None)
                        {
                            // -- Add
                            list.Add(new Space(row, column, Board[row, column]));
                        }
                        // -- Space to win -- //
                        else if (Board[row_second, column_second] == State_Space.None)
                        {
                            // -- Add
                            list.Add(new Space(row, column, Board[row, column]));
                            // -- Add second
                            list.Add(new Space(row_second, column_second, Board[row_second, column_second]));
                            // -- Update opponent -- //
                            have_opponent = true;
                        }
                    }
                }
                catch { }
            }

            if (have_opponent)
            {
                // -- remove -- //
                list.RemoveAll(l => (Math.Abs(l.Row - space.Row) == 1 || Math.Abs(l.Column - space.Column) == 1) && 
                                    l.State == State_Space.None);
            }

            return list;
        }
    }
}
