using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoteGame.Model.Interfaces
{
    public interface IMinMax
    {
        void IA_jouer(State_Space[,] board, int profondeur);

        int Max_Computer(State_Space[,] board, int profondeur);

        int Min_Human(State_Space[,] board, int profondeur);

        int Evaluation(State_Space[,] board);

        State_Space Gagnant(State_Space[,] board);

        void Simulation(State_Space[,] board, int rowLocation, int ColumnLocation, State_Space stape_space);

        void Cancellation(State_Space[,] board, int rowLocation, int ColumnLocation);
    }
}
