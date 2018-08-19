namespace YoteGame.Forms
{
    partial class Form_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main));
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panTransform = new System.Windows.Forms.Panel();
            this.lb_status_game = new System.Windows.Forms.Label();
            this.gBox_player_2 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.pb_hand_player_2 = new System.Windows.Forms.PictureBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lb_score_player_2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lb_tokens_player_2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pBox_player_2 = new System.Windows.Forms.PictureBox();
            this.lb_name_player_2 = new System.Windows.Forms.Label();
            this.gpBox_player_1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pb_hand_player_1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lb_score_player_1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lb_tokens_player_1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lb_name_player_1 = new System.Windows.Forms.Label();
            this.pan_game = new System.Windows.Forms.Panel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.recommencerLaPartieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reglesDuJeuxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.aProposDeYoyéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recommencerLaPartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvellePartieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.sStrip.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gBox_player_2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hand_player_2)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_player_2)).BeginInit();
            this.gpBox_player_1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_hand_player_1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel,
            this.toolStripProgressBar});
            this.sStrip.Location = new System.Drawing.Point(0, 432);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(665, 22);
            this.sStrip.TabIndex = 4;
            this.sStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.panTransform);
            this.panel2.Controls.Add(this.lb_status_game);
            this.panel2.Controls.Add(this.gBox_player_2);
            this.panel2.Controls.Add(this.gpBox_player_1);
            this.panel2.Controls.Add(this.pan_game);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(665, 402);
            this.panel2.TabIndex = 3;
            // 
            // panTransform
            // 
            this.panTransform.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panTransform.BackColor = System.Drawing.Color.Transparent;
            this.panTransform.Location = new System.Drawing.Point(144, 30);
            this.panTransform.Name = "panTransform";
            this.panTransform.Size = new System.Drawing.Size(383, 333);
            this.panTransform.TabIndex = 9;
            this.panTransform.Visible = false;
            // 
            // lb_status_game
            // 
            this.lb_status_game.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_status_game.Location = new System.Drawing.Point(145, 366);
            this.lb_status_game.Name = "lb_status_game";
            this.lb_status_game.Size = new System.Drawing.Size(375, 23);
            this.lb_status_game.TabIndex = 8;
            this.lb_status_game.Text = "Vous pouvez commencer la partie.";
            this.lb_status_game.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gBox_player_2
            // 
            this.gBox_player_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gBox_player_2.Controls.Add(this.groupBox5);
            this.gBox_player_2.Controls.Add(this.groupBox6);
            this.gBox_player_2.Controls.Add(this.groupBox7);
            this.gBox_player_2.Controls.Add(this.pBox_player_2);
            this.gBox_player_2.Controls.Add(this.lb_name_player_2);
            this.gBox_player_2.Location = new System.Drawing.Point(527, 11);
            this.gBox_player_2.Name = "gBox_player_2";
            this.gBox_player_2.Size = new System.Drawing.Size(126, 378);
            this.gBox_player_2.TabIndex = 7;
            this.gBox_player_2.TabStop = false;
            this.gBox_player_2.Text = "JOUEUR 2";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.pb_hand_player_2);
            this.groupBox5.Location = new System.Drawing.Point(6, 295);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(114, 75);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tour de jouer";
            // 
            // pb_hand_player_2
            // 
            this.pb_hand_player_2.BackColor = System.Drawing.Color.Transparent;
            this.pb_hand_player_2.Image = global::YoteGame.Resources.Hand;
            this.pb_hand_player_2.InitialImage = global::YoteGame.Resources.ball_gray;
            this.pb_hand_player_2.Location = new System.Drawing.Point(35, 21);
            this.pb_hand_player_2.Name = "pb_hand_player_2";
            this.pb_hand_player_2.Size = new System.Drawing.Size(40, 40);
            this.pb_hand_player_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hand_player_2.TabIndex = 6;
            this.pb_hand_player_2.TabStop = false;
            this.pb_hand_player_2.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lb_score_player_2);
            this.groupBox6.Location = new System.Drawing.Point(6, 229);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(114, 60);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Score";
            // 
            // lb_score_player_2
            // 
            this.lb_score_player_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_score_player_2.AutoEllipsis = true;
            this.lb_score_player_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lb_score_player_2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_score_player_2.Location = new System.Drawing.Point(6, 16);
            this.lb_score_player_2.Name = "lb_score_player_2";
            this.lb_score_player_2.Size = new System.Drawing.Size(102, 36);
            this.lb_score_player_2.TabIndex = 5;
            this.lb_score_player_2.Text = "0";
            this.lb_score_player_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lb_tokens_player_2);
            this.groupBox7.Controls.Add(this.pictureBox4);
            this.groupBox7.Location = new System.Drawing.Point(6, 106);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(114, 117);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Réserve";
            // 
            // lb_tokens_player_2
            // 
            this.lb_tokens_player_2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tokens_player_2.AutoEllipsis = true;
            this.lb_tokens_player_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lb_tokens_player_2.Location = new System.Drawing.Point(6, 75);
            this.lb_tokens_player_2.Name = "lb_tokens_player_2";
            this.lb_tokens_player_2.Size = new System.Drawing.Size(102, 36);
            this.lb_tokens_player_2.TabIndex = 5;
            this.lb_tokens_player_2.Text = "12";
            this.lb_tokens_player_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::YoteGame.Resources.ball_black;
            this.pictureBox4.InitialImage = global::YoteGame.Resources.ball_gray;
            this.pictureBox4.Location = new System.Drawing.Point(33, 19);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pBox_player_2
            // 
            this.pBox_player_2.BackColor = System.Drawing.Color.Transparent;
            this.pBox_player_2.Image = global::YoteGame.Resources.user_gray;
            this.pBox_player_2.Location = new System.Drawing.Point(39, 19);
            this.pBox_player_2.Name = "pBox_player_2";
            this.pBox_player_2.Size = new System.Drawing.Size(50, 50);
            this.pBox_player_2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pBox_player_2.TabIndex = 3;
            this.pBox_player_2.TabStop = false;
            // 
            // lb_name_player_2
            // 
            this.lb_name_player_2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_name_player_2.AutoEllipsis = true;
            this.lb_name_player_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_name_player_2.Location = new System.Drawing.Point(6, 68);
            this.lb_name_player_2.Name = "lb_name_player_2";
            this.lb_name_player_2.Size = new System.Drawing.Size(114, 20);
            this.lb_name_player_2.TabIndex = 2;
            this.lb_name_player_2.Text = "...";
            this.lb_name_player_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gpBox_player_1
            // 
            this.gpBox_player_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.gpBox_player_1.Controls.Add(this.groupBox3);
            this.gpBox_player_1.Controls.Add(this.groupBox2);
            this.gpBox_player_1.Controls.Add(this.groupBox1);
            this.gpBox_player_1.Controls.Add(this.pictureBox1);
            this.gpBox_player_1.Controls.Add(this.lb_name_player_1);
            this.gpBox_player_1.Location = new System.Drawing.Point(12, 11);
            this.gpBox_player_1.Name = "gpBox_player_1";
            this.gpBox_player_1.Size = new System.Drawing.Size(126, 378);
            this.gpBox_player_1.TabIndex = 3;
            this.gpBox_player_1.TabStop = false;
            this.gpBox_player_1.Text = "JOUEUR 1";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.pb_hand_player_1);
            this.groupBox3.Location = new System.Drawing.Point(6, 295);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(114, 75);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tour de jouer";
            // 
            // pb_hand_player_1
            // 
            this.pb_hand_player_1.BackColor = System.Drawing.Color.Transparent;
            this.pb_hand_player_1.Image = global::YoteGame.Resources.Hand;
            this.pb_hand_player_1.InitialImage = global::YoteGame.Resources.ball_gray;
            this.pb_hand_player_1.Location = new System.Drawing.Point(35, 21);
            this.pb_hand_player_1.Name = "pb_hand_player_1";
            this.pb_hand_player_1.Size = new System.Drawing.Size(40, 40);
            this.pb_hand_player_1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_hand_player_1.TabIndex = 6;
            this.pb_hand_player_1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_score_player_1);
            this.groupBox2.Location = new System.Drawing.Point(6, 229);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(114, 60);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score";
            // 
            // lb_score_player_1
            // 
            this.lb_score_player_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_score_player_1.AutoEllipsis = true;
            this.lb_score_player_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lb_score_player_1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lb_score_player_1.Location = new System.Drawing.Point(6, 16);
            this.lb_score_player_1.Name = "lb_score_player_1";
            this.lb_score_player_1.Size = new System.Drawing.Size(102, 36);
            this.lb_score_player_1.TabIndex = 5;
            this.lb_score_player_1.Text = "0";
            this.lb_score_player_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lb_tokens_player_1);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Réserve";
            // 
            // lb_tokens_player_1
            // 
            this.lb_tokens_player_1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_tokens_player_1.AutoEllipsis = true;
            this.lb_tokens_player_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.lb_tokens_player_1.Location = new System.Drawing.Point(6, 75);
            this.lb_tokens_player_1.Name = "lb_tokens_player_1";
            this.lb_tokens_player_1.Size = new System.Drawing.Size(102, 36);
            this.lb_tokens_player_1.TabIndex = 5;
            this.lb_tokens_player_1.Text = "12";
            this.lb_tokens_player_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::YoteGame.Resources.ball_gray;
            this.pictureBox2.InitialImage = global::YoteGame.Resources.ball_gray;
            this.pictureBox2.Location = new System.Drawing.Point(33, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::YoteGame.Resources.user_gray;
            this.pictureBox1.Location = new System.Drawing.Point(39, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lb_name_player_1
            // 
            this.lb_name_player_1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_name_player_1.AutoEllipsis = true;
            this.lb_name_player_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lb_name_player_1.Location = new System.Drawing.Point(6, 68);
            this.lb_name_player_1.Name = "lb_name_player_1";
            this.lb_name_player_1.Size = new System.Drawing.Size(114, 20);
            this.lb_name_player_1.TabIndex = 2;
            this.lb_name_player_1.Text = "...";
            this.lb_name_player_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pan_game
            // 
            this.pan_game.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pan_game.BackgroundImage = global::YoteGame.Resources.background_game;
            this.pan_game.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pan_game.Location = new System.Drawing.Point(145, 41);
            this.pan_game.Name = "pan_game";
            this.pan_game.Size = new System.Drawing.Size(375, 314);
            this.pan_game.TabIndex = 1;
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem1,
            this.aideToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(665, 24);
            this.menuStrip.TabIndex = 5;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fichierToolStripMenuItem1
            // 
            this.fichierToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.recommencerLaPartieToolStripMenuItem1,
            this.nouvellePartieToolStripMenuItem1,
            this.toolStripSeparator2,
            this.quitterToolStripMenuItem1});
            this.fichierToolStripMenuItem1.Name = "fichierToolStripMenuItem1";
            this.fichierToolStripMenuItem1.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem1.Text = "Fichier";
            // 
            // recommencerLaPartieToolStripMenuItem1
            // 
            this.recommencerLaPartieToolStripMenuItem1.Name = "recommencerLaPartieToolStripMenuItem1";
            this.recommencerLaPartieToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.recommencerLaPartieToolStripMenuItem1.Text = "Recommencer la partie";
            this.recommencerLaPartieToolStripMenuItem1.Click += new System.EventHandler(this.recommencerLaPartieToolStripMenuItem1_Click);
            // 
            // nouvellePartieToolStripMenuItem1
            // 
            this.nouvellePartieToolStripMenuItem1.Name = "nouvellePartieToolStripMenuItem1";
            this.nouvellePartieToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.nouvellePartieToolStripMenuItem1.Text = "Nouvelle partie";
            this.nouvellePartieToolStripMenuItem1.Click += new System.EventHandler(this.nouvellePartieToolStripMenuItem1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(193, 6);
            // 
            // quitterToolStripMenuItem1
            // 
            this.quitterToolStripMenuItem1.Name = "quitterToolStripMenuItem1";
            this.quitterToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.quitterToolStripMenuItem1.Text = "Quitter ?";
            this.quitterToolStripMenuItem1.Click += new System.EventHandler(this.quitterToolStripMenuItem1_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reglesDuJeuxToolStripMenuItem,
            this.toolStripSeparator3,
            this.aProposDeYoyéToolStripMenuItem});
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "Aide";
            // 
            // reglesDuJeuxToolStripMenuItem
            // 
            this.reglesDuJeuxToolStripMenuItem.Name = "reglesDuJeuxToolStripMenuItem";
            this.reglesDuJeuxToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.reglesDuJeuxToolStripMenuItem.Text = "Règles du jeux";
            this.reglesDuJeuxToolStripMenuItem.Click += new System.EventHandler(this.reglesDuJeuxToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(163, 6);
            // 
            // aProposDeYoyéToolStripMenuItem
            // 
            this.aProposDeYoyéToolStripMenuItem.Name = "aProposDeYoyéToolStripMenuItem";
            this.aProposDeYoyéToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aProposDeYoyéToolStripMenuItem.Text = "A propos de Yoyé";
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "Fichier";
            // 
            // recommencerLaPartieToolStripMenuItem
            // 
            this.recommencerLaPartieToolStripMenuItem.Name = "recommencerLaPartieToolStripMenuItem";
            this.recommencerLaPartieToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.recommencerLaPartieToolStripMenuItem.Text = "Recommencer la partie";
            // 
            // nouvellePartieToolStripMenuItem
            // 
            this.nouvellePartieToolStripMenuItem.Name = "nouvellePartieToolStripMenuItem";
            this.nouvellePartieToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.nouvellePartieToolStripMenuItem.Text = "Nouvelle partie";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(193, 6);
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.quitterToolStripMenuItem.Text = "Quitter ?";
            // 
            // timer
            // 
            this.timer.Interval = 250;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 454);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.gBox_player_2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hand_player_2)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBox_player_2)).EndInit();
            this.gpBox_player_1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_hand_player_1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pan_game;
        private System.Windows.Forms.Label lb_name_player_1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox gpBox_player_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.PictureBox pb_hand_player_1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lb_score_player_1;
        private System.Windows.Forms.Label lb_tokens_player_1;
        private System.Windows.Forms.GroupBox gBox_player_2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.PictureBox pb_hand_player_2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lb_score_player_2;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Label lb_tokens_player_2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pBox_player_2;
        private System.Windows.Forms.Label lb_name_player_2;
        private System.Windows.Forms.Label lb_status_game;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recommencerLaPartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem recommencerLaPartieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nouvellePartieToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem reglesDuJeuxToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem aProposDeYoyéToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar;
        private System.Windows.Forms.Panel panTransform;
        private System.Windows.Forms.Timer timer;
    }
}