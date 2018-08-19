using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console
{
    public class Node
    {
        public Position position    { get; set; }
        public Node fislGauche      { get; set; }
        public Node fislDroite      { get; set; }
        public Node parent          { get; set; }
        public object valeur        { get; set; }
        public bool dernierNoeud    { get; set; }

        public Node() { }
        public Node(int x, int y)
        {
            this.position = new Position(x, y);
        }

        public List<Node> Children(bool Player)
        {
            List<Node> children = new List<Node>();

            int x = 0, y = 0;

            for(x = 0; x <= 5; x++)
            {
                for(y = 0; y <= 5; y++)
                {
                    children.Add(
                        new Node(x, y)
                    );
                }
            }

            return children;
        }

        public bool IsTerminal(bool Player)
        {
            //terminalNode = false;

            // Game over?

            return false;
        }

        public int GetTotalScore(bool Player)
        {
            int totalScore = 0;

            // This method is a heuristic evaluation function to evaluate
            // the current situation of the player
            // It depends on the game. For example chess, tic-tac-to or other games suitable
            // for the minimax algorithm can have different evaluation functions.

            return totalScore;
        }

    }
}
