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
using YoteGame.Model.Static;

namespace YoteGame.Forms
{
    public partial class Form_Main : Form_App
    {
        #region Variables
        private readonly Random ran = new Random();

        public Type_Player _currentPlayer;
        private List<Space> _moves;
        private List<Space> _moveStack;
        private List<Space> displaySpace = new List<Space>();
        private Boolean actionFree = false;

        private const int RowCount = 5;
        private const int ColumnCount = 6;
        private const string id_block_name = "pB_block_";
        private Boolean isNotFirstplay { get; set; }

        private Player Player_1 { get; set; }
        private Player Player_2 { get; set; }
        private State_Space[,] Board { get; set; }
        private Space CurrentToken { get; set; }
        public List<Space> Moves
        {
            get { return _moves; }
            set { _moves = (value as List<Space>) ?? new List<Space>(value); }
        }
        public List<Space> MoveStack
        {
            get { return _moveStack; }
            set { _moveStack = (value as List<Space>) ?? new List<Space>(value); }
        }
        public Type_Player CurrentPlayer
        {
            get { return _currentPlayer; }
            set
            {
                if (_currentPlayer != value)
                {
                    _currentPlayer = value;
                    EventHandler handler = Event_curent_player_Change;
                    if (handler != null)
                        handler(this, EventArgs.Empty);
                }
            }
        }
        #endregion

        #region Constructeur
        public Form_Main()
        {
            InitializeComponent();
        }

        public Form_Main(string name_1, string name_2) : this()
        {
            // -- Create players -- //
            Player_1 = new Player(name_1, true);
            Player_2 = new Player(name_2, false);
            // -- Update event -- //
            Player_1.PropertyChanged += Event_Property_Player_Change;
            Player_2.PropertyChanged += Event_Property_Player_Change;

            // -- Initialise var -- //
            Moves = new List<Space>();
            MoveStack = new List<Space>();
            Board = new State_Space[RowCount, ColumnCount];
            isNotFirstplay = false;

            // -- Initialisation form -- //
            InitalisationForm();

            // -- Initialise current player -- //
            _currentPlayer = Type_Player.One;
        }
        #endregion


        private void Event_Property_Player_Change(object sender, PropertyChangedEventArgs property)
        {
            Player player = (Player)sender;

            // -- Property tokens
            #region tokens
            if (property.PropertyName == "tokens")
            {
                if (player.isOne.HasValue)
                {
                    if (player.isOne.Value)
                    {
                        lb_tokens_player_1.Text = (12 - player.tokens.Count).ToString();

                        // -- Add moves 
                        Player_1.tokens.LastOrDefault().Moves.Add(
                            new Space(
                                Player_1.tokens.LastOrDefault().Row,
                                Player_1.tokens.LastOrDefault().Column,
                                State_Space.One
                            )
                        );
                    }
                    else
                    {
                        lb_tokens_player_2.Text = (12 - player.tokens.Count).ToString();

                        // -- Add moves 
                        Player_2.tokens.LastOrDefault().Moves.Add(
                            new Space(
                                Player_2.tokens.LastOrDefault().Row,
                                Player_2.tokens.LastOrDefault().Column,
                                State_Space.Two
                            )
                        );
                    }
                }
            }
            #endregion
            // -- Property score
            #region score
            if (property.PropertyName == "score")
            {
                if (player.isOne.HasValue)
                {
                    if (player.isOne.Value)
                    {
                        lb_score_player_1.Text = player.score.ToString();
                    }
                    else
                    {
                        lb_score_player_2.Text = player.score.ToString();
                    }
                }
                // -- Plays sound -- //
                PlayAudio();
            }
            #endregion
        }

        // -- Change current player -- //
        private void Change_current_player()
        {
            CurrentPlayer = (CurrentPlayer == Type_Player.One) ? Type_Player.Two
                                                               : Type_Player.One;

            if (CurrentPlayer == Type_Player.Two)
            {
                Player_2_Play();
            }
        }

        // -- Event -- //
        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            // -- Stop application -- //
            Application.Exit();
        }

        private void InitalisationForm()
        {
            // -- Name of players -- //
            lb_name_player_1.Text = Player_1.name;
            lb_name_player_2.Text = Player_2.name;

            // -- Generation block -- //
            int location_x = 11;
            int location_y = 10;
            int tabIndex = 0;
            for (int x = 0; x < RowCount; x++) 
            {
                for (int y = 0; y < ColumnCount; y++)
                {
                    // -- Add Space -- //
                    Board[x, y] = State_Space.None;

                    // -- Create block -- //
                    var block = new System.Windows.Forms.PictureBox()
                    {
                        BackColor = System.Drawing.Color.Transparent,
                        Location = new System.Drawing.Point(location_x, location_y),
                        Name = $"{id_block_name}{x}{y}",
                        Size = new System.Drawing.Size(45, 45),
                        SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage,
                        Cursor = System.Windows.Forms.Cursors.Hand,
                        TabIndex = tabIndex++,
                        TabStop = false
                    };
                    // -- Event on click -- //
                    block.Click += new System.EventHandler(this.Event_block_Click);
                    // -- Event on click -- //
                    block.DoubleClick += new System.EventHandler(this.Event_block_DoubleClick);

                    // -- Add control in panle -- //
                    pan_game.Controls.Add(block);

                    // -- Increment location X -- //
                    location_x += 62;
                }
                // -- Initialise loacation X -- //
                location_x = 11;
                // -- Increment location Y -- //
                location_y += 62;
            }

            // -- Group Box player 2 -- //
            if (Player_2.nature == Nature_Player.Computeur)
            {
                gBox_player_2.Text = "ORDINATEUR";
                pBox_player_2.Image = Resources.robot_player_computeur;
                toolStripProgressBar.Visible = true;
            }

            // -- Date time beging Game -- //
            toolStripStatusLabel.Text = DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString();
        }

        // -- Computer play
        private void Computer_Play()
        {
            toolStripProgressBar.Value = 0;
            // -- Affichier le jeux -- //
            this.panTransform.Visible = false;
            timer.Stop();

            // -- Bulid bloc forgame -- //
            string id_block = MinMax.IA_jouer(YoteClass.CloneBoard(Board), Player_1, Player_2);

            var block = (PictureBox)pan_game.Controls.Find($"{id_block_name}{id_block}", false)[0];

            // -- Call action play -- //
            Action_Player(block);
        }

        // -- Check if computer plays
        private void Player_2_Play()
        {
            if (Player_2.nature == Nature_Player.Computeur)
            {
                this.panTransform.Visible = true;
                timer.Start();
            }
        }

        // -- Event when block is clicked -- //
        private void Event_block_Click(object sender, EventArgs e)
        {
            if (!Display_Move_Enable())
            {
                // -- Get block selected -- //
                var block = (PictureBox)pan_game.Controls.Find(((PictureBox)sender).Name, false)[0];

                // -- Get action game -- //
                Action_Player(block);
            }
            else
            {
                lb_status_game.Text = "Vous devez terminer votre action ou l'annuler!";
            }
        }

        // -- Event when block is double clicked -- //
        private void Event_block_DoubleClick(object sender, EventArgs e)
        {
            // -- Get block selected -- //
            var block = (PictureBox)pan_game.Controls.Find(((PictureBox)sender).Name, false)[0];

            Space space_block = Get_Space(block.Name);
            
            if (actionFree)
            {
                Boolean isWin = false;

                // -- Move token -- //
                Move_Current_Token(space_block, ref isWin);

                // -- Get action game -- //
                Hide_Move(CurrentToken);

                // -- Action to free play
                actionFree = false;

                // -- Change current player -- //
                Change_current_player();
            }
            // -- Check if token to win
            else if (block.BackColor != Color.Green)
            {
                if (Is_Block_Current_Player(space_block))
                {
                    if (!Display_Move_Enable())
                    {
                        // -- Get action game -- //
                        Display_Move(space_block);
                    }
                    else
                    {
                        // -- Get action game -- //
                        Hide_Move(space_block);
                    }
                }
                else
                {
                    lb_status_game.Text = "Vous devez selectionner un de vos jetons!";
                }
            }
            else
            {
                Boolean isWin = false;

                // -- Move token -- //
                Move_Current_Token(space_block, ref isWin);

                // -- Get action game -- //
                Hide_Move(CurrentToken);

                if (isWin)
                {
                    // -- Action to free play
                    Free_Play();

                    if (!actionFree)
                    {
                        Change_current_player();
                    }
                }
                else
                {
                    Change_current_player();
                }
            }
        }

        // -- Free action play
        private void Free_Play()
        {
            displaySpace = YoteClass.SpaceOpponentBoard(Board, (CurrentPlayer == Type_Player.One) ? State_Space.Two
                                                                                                 : State_Space.One);

            foreach (var val in displaySpace)
            {
                // -- Disply new space 
                ((PictureBox)pan_game.Controls.Find($"{id_block_name}{val.Row}{val.Column}", false)[0]).BackColor = Color.Green;

                // -- Action to free play
                actionFree = true;
            }
        }

        // -- Move token -- //
        private void Move_Current_Token(Space new_space, ref Boolean isWin)
        {
            if (!actionFree)
            {
                // -- Update state boad
                Board[CurrentToken.Row, CurrentToken.Column] = State_Space.None;

                // -- Get win token -- //
                Space win_token = YoteClass.WinTokenExist(new_space, CurrentToken);

                if (CurrentPlayer == Type_Player.One)
                {
                    // -- Update state boad
                    Board[new_space.Row, new_space.Column] = State_Space.One;
                    // -- Add move in token
                    Add_Move_In_Token_Player(Player_1, new_space);

                    // -- Check if win token exist
                    if (win_token != null)
                    {
                        // -- increment score
                        Player_1.score++;
                        // -- Pic hand 
                        pb_hand_player_1.Image = Resources.hand_get;

                        isWin = true;
                    }

                    // -- Disply new space 
                    ((PictureBox)pan_game.Controls.Find($"{id_block_name}{new_space.Row}{new_space.Column}", false)[0]).Image = Resources.ball_gray;
                }
                else
                {
                    // -- Update state boad
                    Board[new_space.Row, new_space.Column] = State_Space.Two;
                    // -- Add move in token
                    Add_Move_In_Token_Player(Player_2, new_space);

                    // -- Check if win token exist
                    if (win_token != null)
                    {
                        // -- increment score
                        Player_2.score++;
                        // -- Pic hand 
                        pb_hand_player_2.Image = Resources.hand_get;

                        isWin = true;
                    }

                    // -- Disply new space 
                    ((PictureBox)pan_game.Controls.Find($"{id_block_name}{new_space.Row}{new_space.Column}", false)[0]).Image = Resources.ball_black;
                }
                // -- Update win token
                Win_Token(win_token, new_space);
            }
            else
            {
                if (CurrentPlayer == Type_Player.One)
                {
                    // -- increment score
                    Player_1.score++;
                    // -- Pic hand 
                    pb_hand_player_1.Image = Resources.Hand;
                }
                else
                {
                    // -- increment score
                    Player_2.score++;
                    // -- Pic hand 
                    pb_hand_player_2.Image = Resources.Hand;
                }
                // -- Update win token
                Win_Token(new_space, new_space);
            }
        }

        // -- Add move in tokens player
        private void Add_Move_In_Token_Player(Player player, Space move)
        {
            try
            {
                // -- Add move in token
                player.tokens.Where(l => l.Row == CurrentToken.Row &&
                                         l.Column == CurrentToken.Column).ToList().ForEach(l =>
                                         {
                                             l.Moves.Add(move);
                                             l.Row = move.Row;
                                             l.Column = move.Column;
                                         }
                                    );
            }
            catch { }
        }

        // -- Win token
        private void Win_Token(Space win_token, Space new_space)
        {
            if (win_token != null)
            {
                // -- Update state boad
                Board[win_token.Row, win_token.Column] = State_Space.None;

                if (!actionFree)
                {
                    // -- Disply old space 
                    ((PictureBox)pan_game.Controls.Find($"{id_block_name}{CurrentToken.Row}{CurrentToken.Column}", false)[0]).Image = null;
                }

                // -- Disply old space 
                ((PictureBox)pan_game.Controls.Find($"{id_block_name}{win_token.Row}{win_token.Column}", false)[0]).Image = null;
                ((PictureBox)pan_game.Controls.Find($"{id_block_name}{win_token.Row}{win_token.Column}", false)[0]).BackColor = Color.Transparent;
            }
            else
            {
                // -- Disply old space 
                ((PictureBox)pan_game.Controls.Find($"{id_block_name}{CurrentToken.Row}{CurrentToken.Column}", false)[0]).Image = null;

                // -- Disply old space 
                ((PictureBox)pan_game.Controls.Find($"{id_block_name}{new_space.Row}{new_space.Column}", false)[0]).BackColor = Color.Transparent;
            }
        }

        // -- Check if block is current player -- //
        private Boolean Is_Block_Current_Player(Space space_block)
        {
            try
            {
                return
                    Board[space_block.Row, space_block.Column].ToString() == CurrentPlayer.ToString();
            }
            catch
            {
                return false;
            }
        }

        // -- Generate victory
        private void Generate_Victory(Type_Player player)
        {
            if (isNotFirstplay && YoteClass.IsVictory(Board, player))
            {
                MessageBox.Show(
                    $"Félicitation, le joueur{((player == Type_Player.One) ? "1 (" + Player_2.name + ")" : "2 (" + Player_1.name + ")")} a gagné!",
                    "Information",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                // -- Event new gae
                nouvellePartieToolStripMenuItem1.PerformClick();
            }
        }

        // -- Display move -- //
        private void Display_Move(Space space_block)
        {
            // -- Get display space -- //
            displaySpace = Space.Enable_Space(Board, space_block, CurrentPlayer);

            // -- Disply selected 
            ((PictureBox)pan_game.Controls.Find($"{id_block_name}{space_block.Row}{space_block.Column}", false)[0]).BackColor = Color.LightGoldenrodYellow;
            // -- Display all enable space -- //
            foreach (var space in displaySpace)
            {
                // -- Check previous action
                if (!YoteClass.IsPreviousAction(CurrentPlayer == Type_Player.One ? Player_1 : Player_2, space_block, space, actionFree))
                {
                    ((PictureBox)pan_game.Controls.Find($"{id_block_name}{space.Row}{space.Column}", false)[0]).BackColor = (space.State == State_Space.None) ? Color.Green
                                                                                                                                                              : ((CurrentPlayer == Type_Player.One && space.State == State_Space.Two) || (CurrentPlayer == Type_Player.Two && space.State == State_Space.One)) ? Color.Red
                                                                                                                                                                                                                                                                                                               : Color.Transparent;
                }
                lb_status_game.Text = "Vous devez selectionner un des emplacements de jeux!";
            }

            // -- Set currenttoken
            CurrentToken = space_block;
        }

        private void Hide_Move(Space space_block)
        {
            if (!actionFree)
            {
                if (((PictureBox)pan_game.Controls.Find($"{id_block_name}{space_block.Row}{space_block.Column}", false)[0]).BackColor == Color.LightGoldenrodYellow)
                {
                    // -- Disply selected 
                    ((PictureBox)pan_game.Controls.Find($"{id_block_name}{space_block.Row}{space_block.Column}", false)[0]).BackColor = Color.Transparent;
                    // -- Display all enable space -- //
                    foreach (var space in displaySpace)
                    {
                        ((PictureBox)pan_game.Controls.Find($"{id_block_name}{space.Row}{space.Column}", false)[0]).BackColor = Color.Transparent;
                    }

                    lb_status_game.Text = "...";
                }
            }
            else
            {
                // -- Display all enable space -- //
                foreach (var space in displaySpace)
                {
                    ((PictureBox)pan_game.Controls.Find($"{id_block_name}{space.Row}{space.Column}", false)[0]).BackColor = Color.Transparent;
                }

                lb_status_game.Text = "...";
            }

            // -- Set currenttoken
            CurrentToken = null;
            // -- Clear display space
            displaySpace = new List<Space>();
        }

        private Boolean Display_Move_Enable()
        {
            foreach(PictureBox block in pan_game.Controls)
            {
                if (block.BackColor == Color.Green || 
                    block.BackColor == Color.Red || 
                    block.BackColor == Color.LightGoldenrodYellow)
                    return true;
            }
            return false;
        }

        private Space Get_Space(string name)
        {
            return
                new Space(
                    Convert.ToInt32(name.Replace($"{id_block_name}", "")[0].ToString()),
                    Convert.ToInt32(name.Replace($"{id_block_name}", "")[1].ToString())
                );
        }

        private void Action_Player(PictureBox block)
        {
            // -- Get space selected -- //
            Space space = Get_Space(block.Name);

            // -- Check if space is emty -- //
            if (Board[space.Row, space.Column] == State_Space.None)
            {
                if (CurrentPlayer == Type_Player.One)
                {
                    // - Update image content -- //
                    block.Image = Resources.ball_gray;
                    // -- Update board content -- //
                    Board[space.Row, space.Column] = State_Space.One;
                    // -- define token -- //
                    Player_1.tokens.Add(space);
                }
                else if (CurrentPlayer == Type_Player.Two)
                {
                    // - Update image content -- //
                    block.Image = Resources.ball_black;
                    // -- Update board content -- //
                    Board[space.Row, space.Column] = State_Space.Two;
                    // -- define token -- //
                    Player_2.tokens.Add(space);
                }
                
                // -- Plays sound -- //
                PlayAudio();

                // -- Change current player -- //
                Change_current_player();
                
                // -- Update value
                isNotFirstplay = true;
            }
        }

        //private void Define_Block_image(PictureBox block)
        //{
        //    if (CurrentPlayer == Type_Player.One)
        //    {
        //        // - Update image content -- //
        //        block.Image = Resources.ball_gray;
        //    }
        //    else if (CurrentPlayer == Type_Player.Two)
        //    {
        //        // - Update image content -- //
        //        block.Image = Resources.ball_black;
        //    }
        //}

        // -- Event when curent player change -- //
        private void Event_curent_player_Change(object sender, EventArgs e)
        {
            if (CurrentPlayer == Type_Player.One)
            {
                pb_hand_player_1.Visible = true;
                pb_hand_player_2.Visible = false;

                lb_status_game.Text = "Au tour du joueur 1 de jouer.";
            }
            else
            {
                pb_hand_player_1.Visible = false;
                pb_hand_player_2.Visible = true;

                lb_status_game.Text = "Au tour du joueur 2 de jouer.";
            }

            // -- Generate victory
            Generate_Victory(CurrentPlayer);
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Fermer l'application ?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void nouvellePartieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // -- Hide me -- //
            this.Hide();

            // -- Display authentification -- //
            Program.form_authentification = new Form_Authentification();
            Program.form_authentification.Show();
        }

        private void recommencerLaPartieToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // -- Hide me -- //
            this.Hide();

            Program.form_application = new Form_Main(Player_1.name, Player_2.name);
            Program.form_application.Show();
        }

        // -- Event click
        private void reglesDuJeuxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.form_regle = new Form_Regles();
            Program.form_regle.Show();
        }

        // -- Event timer tick
        private void timer_Tick(object sender, EventArgs e)
        {
            toolStripProgressBar.Minimum = 0;
            toolStripProgressBar.Maximum = 250;

            if (toolStripProgressBar.Value < toolStripProgressBar.Maximum)
            {
                toolStripProgressBar.Value += 50;
            }

            // -- Check if finish
            if (toolStripProgressBar.Value == 250)
            {
                // -- Computer play
                Computer_Play();
            }
        }
    }
}
