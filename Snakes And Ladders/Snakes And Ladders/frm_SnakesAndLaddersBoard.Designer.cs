namespace Snakes_And_Ladders
{
    partial class frm_SnakesAndLaddersBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_SnakesAndLaddersBoard));
            this.btn_rollDie = new System.Windows.Forms.Button();
            this.lbl_winnerTitle = new System.Windows.Forms.Label();
            this.lbl_winnerIs = new System.Windows.Forms.Label();
            this.lbl_PlayerThatIsGoing = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.pbx_Diceface = new System.Windows.Forms.PictureBox();
            this.pnl_board = new System.Windows.Forms.Panel();
            this.pbx_Player2 = new System.Windows.Forms.PictureBox();
            this.pbx_Player1 = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Diceface)).BeginInit();
            this.pnl_board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Player2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Player1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_rollDie
            // 
            this.btn_rollDie.Enabled = false;
            this.btn_rollDie.Location = new System.Drawing.Point(42, 557);
            this.btn_rollDie.Name = "btn_rollDie";
            this.btn_rollDie.Size = new System.Drawing.Size(180, 70);
            this.btn_rollDie.TabIndex = 1;
            this.btn_rollDie.Text = "Roll Die";
            this.btn_rollDie.UseVisualStyleBackColor = true;
            this.btn_rollDie.Click += new System.EventHandler(this.btn_rollDie_Click);
            // 
            // lbl_winnerTitle
            // 
            this.lbl_winnerTitle.AutoSize = true;
            this.lbl_winnerTitle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winnerTitle.Location = new System.Drawing.Point(30, 27);
            this.lbl_winnerTitle.Name = "lbl_winnerTitle";
            this.lbl_winnerTitle.Size = new System.Drawing.Size(201, 31);
            this.lbl_winnerTitle.TabIndex = 2;
            this.lbl_winnerTitle.Text = "The winner is ...";
            this.lbl_winnerTitle.Visible = false;
            // 
            // lbl_winnerIs
            // 
            this.lbl_winnerIs.AutoSize = true;
            this.lbl_winnerIs.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winnerIs.Location = new System.Drawing.Point(30, 58);
            this.lbl_winnerIs.Name = "lbl_winnerIs";
            this.lbl_winnerIs.Size = new System.Drawing.Size(90, 31);
            this.lbl_winnerIs.TabIndex = 3;
            this.lbl_winnerIs.Text = "Player";
            this.lbl_winnerIs.Visible = false;
            // 
            // lbl_PlayerThatIsGoing
            // 
            this.lbl_PlayerThatIsGoing.AutoSize = true;
            this.lbl_PlayerThatIsGoing.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PlayerThatIsGoing.Location = new System.Drawing.Point(37, 520);
            this.lbl_PlayerThatIsGoing.Name = "lbl_PlayerThatIsGoing";
            this.lbl_PlayerThatIsGoing.Size = new System.Drawing.Size(0, 27);
            this.lbl_PlayerThatIsGoing.TabIndex = 4;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(42, 103);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(180, 70);
            this.btn_Start.TabIndex = 5;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // pbx_Diceface
            // 
            this.pbx_Diceface.Location = new System.Drawing.Point(42, 324);
            this.pbx_Diceface.Name = "pbx_Diceface";
            this.pbx_Diceface.Size = new System.Drawing.Size(180, 180);
            this.pbx_Diceface.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_Diceface.TabIndex = 6;
            this.pbx_Diceface.TabStop = false;
            // 
            // pnl_board
            // 
            this.pnl_board.BackgroundImage = global::Snakes_And_Ladders.Properties.Resources.snakes_and_ladders_game_board_by_avaruusturri_d63fn1g;
            this.pnl_board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_board.Controls.Add(this.pbx_Player2);
            this.pnl_board.Controls.Add(this.pbx_Player1);
            this.pnl_board.Location = new System.Drawing.Point(269, 27);
            this.pnl_board.Name = "pnl_board";
            this.pnl_board.Size = new System.Drawing.Size(600, 600);
            this.pnl_board.TabIndex = 0;
            // 
            // pbx_Player2
            // 
            this.pbx_Player2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pbx_Player2.Location = new System.Drawing.Point(25, 564);
            this.pbx_Player2.Name = "pbx_Player2";
            this.pbx_Player2.Size = new System.Drawing.Size(20, 20);
            this.pbx_Player2.TabIndex = 2;
            this.pbx_Player2.TabStop = false;
            this.pbx_Player2.Visible = false;
            // 
            // pbx_Player1
            // 
            this.pbx_Player1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.pbx_Player1.Location = new System.Drawing.Point(25, 538);
            this.pbx_Player1.Name = "pbx_Player1";
            this.pbx_Player1.Size = new System.Drawing.Size(20, 20);
            this.pbx_Player1.TabIndex = 0;
            this.pbx_Player1.TabStop = false;
            this.pbx_Player1.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "apple.png");
            this.imageList2.Images.SetKeyName(1, "banana.png");
            this.imageList2.Images.SetKeyName(2, "kiwi.jpg");
            this.imageList2.Images.SetKeyName(3, "lemon.jpg");
            this.imageList2.Images.SetKeyName(4, "orange.png");
            this.imageList2.Images.SetKeyName(5, "pinapple.jpg");
            this.imageList2.Images.SetKeyName(6, "strawberry.jpg");
            this.imageList2.Images.SetKeyName(7, "watermelon.jpg");
            // 
            // frm_SnakesAndLaddersBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 648);
            this.Controls.Add(this.pbx_Diceface);
            this.Controls.Add(this.btn_Start);
            this.Controls.Add(this.lbl_PlayerThatIsGoing);
            this.Controls.Add(this.lbl_winnerIs);
            this.Controls.Add(this.lbl_winnerTitle);
            this.Controls.Add(this.btn_rollDie);
            this.Controls.Add(this.pnl_board);
            this.Name = "frm_SnakesAndLaddersBoard";
            this.Text = "Snakes And Ladders";
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Diceface)).EndInit();
            this.pnl_board.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Player2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_Player1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_board;
        private System.Windows.Forms.Button btn_rollDie;
        private System.Windows.Forms.PictureBox pbx_Player2;
        private System.Windows.Forms.PictureBox pbx_Player1;
        private System.Windows.Forms.Label lbl_winnerTitle;
        private System.Windows.Forms.Label lbl_winnerIs;
        private System.Windows.Forms.Label lbl_PlayerThatIsGoing;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.PictureBox pbx_Diceface;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
    }
}

