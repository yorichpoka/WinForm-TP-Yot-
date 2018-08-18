using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoteGame.Forms;
using YoteGame.Model;

namespace YoteGame
{
    static class Program
    {
        // -- Variables -- //
        public static Form_Main form_application { get; set; }
        public static Form_Authentification form_authentification { get; set; }
        public static Form_Regles form_regle { get; set; }
        public static readonly int row_board_count = 5;
        public static readonly int column_board_count = 6;

        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // -- Initialise var -- //
            form_authentification = new Form_Authentification();

            // -- Start form -- //
            Application.Run(form_authentification);
        }
    }
}
