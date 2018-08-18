using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoteGame.Model;

namespace YoteGame.Forms
{
    public partial class Form_Authentification : Form_App
    {
        public Form_Authentification()
        {
            InitializeComponent();

            Testes();
        }

        // -- Event -- //
        private void bt_cancel_Click(object sender, EventArgs e)
        {
            // -- Stop application -- //
            Application.Exit();
        }

        private void bt_go_Click(object sender, EventArgs e)
        {
            // -- Valisation form -- //
            if (!AppClass.isValue(new string[] { txtBox_name1.Text, cBox_name2.Text }))
                MessageBox.Show("Veuillez entrer les noms des joueurs!", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                // -- Initialise -- //
                Program.form_application = new Form_Main(txtBox_name1.Text, cBox_name2.Text);
                Program.form_application.Show();

                // -- me close -- //
                this.Hide();
            }

        }

        private void Testes()
        {
            txtBox_name1.Text = "POKA";
            cBox_name2.Text = "Ulrich";
        }
    }
}
