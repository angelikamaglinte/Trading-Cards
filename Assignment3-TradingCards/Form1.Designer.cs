namespace Assignment3_TradingCards
{
    partial class TradingCards
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listBoxPlayers = new ListBox();
            lblTradingCards = new Label();
            lblName = new Label();
            lblTeam = new Label();
            pictureBoxPlayer = new PictureBox();
            lblGamesPlayed = new Label();
            textBoxName = new TextBox();
            textBoxTeam = new TextBox();
            textBoxGamesPlayed = new TextBox();
            panelCard = new Panel();
            btnAddNewPlayer = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            panelBorder = new Panel();
            textBoxTouchdowns = new TextBox();
            textBoxYards = new TextBox();
            btnSelectImage = new Button();
            lblTouchdowns = new Label();
            lblYards = new Label();
            lblRatings = new Label();
            textBoxRatings = new TextBox();
            textBoxAddRatings = new TextBox();
            textBoxAddYards = new TextBox();
            textBoxAddTouchdowns = new TextBox();
            textBoxAddGamesPlayed = new TextBox();
            textBoxAddTeam = new TextBox();
            textBoxAddName = new TextBox();
            btnAddImage = new Button();
            pictureBoxAddPlayer = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).BeginInit();
            panelCard.SuspendLayout();
            panelBorder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddPlayer).BeginInit();
            SuspendLayout();
            // 
            // listBoxPlayers
            // 
            listBoxPlayers.FormattingEnabled = true;
            listBoxPlayers.ItemHeight = 15;
            listBoxPlayers.Location = new Point(12, 69);
            listBoxPlayers.Name = "listBoxPlayers";
            listBoxPlayers.Size = new Size(306, 259);
            listBoxPlayers.TabIndex = 0;
            // 
            // lblTradingCards
            // 
            lblTradingCards.AutoSize = true;
            lblTradingCards.Font = new Font("Segoe Print", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTradingCards.Location = new Point(14, 9);
            lblTradingCards.Name = "lblTradingCards";
            lblTradingCards.Size = new Size(193, 43);
            lblTradingCards.TabIndex = 1;
            lblTradingCards.Text = "Trading Cards";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(538, 479);
            lblName.Name = "lblName";
            lblName.Size = new Size(56, 26);
            lblName.TabIndex = 2;
            lblName.Text = "Name";
            // 
            // lblTeam
            // 
            lblTeam.AutoSize = true;
            lblTeam.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblTeam.ForeColor = Color.Black;
            lblTeam.Location = new Point(538, 517);
            lblTeam.Name = "lblTeam";
            lblTeam.Size = new Size(54, 26);
            lblTeam.TabIndex = 3;
            lblTeam.Text = "Team";
            // 
            // pictureBoxPlayer
            // 
            pictureBoxPlayer.Location = new Point(20, 20);
            pictureBoxPlayer.Name = "pictureBoxPlayer";
            pictureBoxPlayer.Size = new Size(267, 320);
            pictureBoxPlayer.TabIndex = 4;
            pictureBoxPlayer.TabStop = false;
            // 
            // lblGamesPlayed
            // 
            lblGamesPlayed.AutoSize = true;
            lblGamesPlayed.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblGamesPlayed.ForeColor = Color.Black;
            lblGamesPlayed.Location = new Point(538, 553);
            lblGamesPlayed.Name = "lblGamesPlayed";
            lblGamesPlayed.Size = new Size(119, 26);
            lblGamesPlayed.TabIndex = 5;
            lblGamesPlayed.Text = "Games Played";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(157, 351);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(161, 23);
            textBoxName.TabIndex = 6;
            // 
            // textBoxTeam
            // 
            textBoxTeam.Location = new Point(157, 389);
            textBoxTeam.Name = "textBoxTeam";
            textBoxTeam.Size = new Size(161, 23);
            textBoxTeam.TabIndex = 7;
            // 
            // textBoxGamesPlayed
            // 
            textBoxGamesPlayed.Location = new Point(157, 425);
            textBoxGamesPlayed.Name = "textBoxGamesPlayed";
            textBoxGamesPlayed.Size = new Size(161, 23);
            textBoxGamesPlayed.TabIndex = 8;
            // 
            // panelCard
            // 
            panelCard.Controls.Add(pictureBoxPlayer);
            panelCard.Location = new Point(18, 20);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(305, 358);
            panelCard.TabIndex = 9;
            // 
            // btnAddNewPlayer
            // 
            btnAddNewPlayer.BackColor = SystemColors.ActiveCaption;
            btnAddNewPlayer.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnAddNewPlayer.Location = new Point(894, 426);
            btnAddNewPlayer.Name = "btnAddNewPlayer";
            btnAddNewPlayer.Size = new Size(190, 36);
            btnAddNewPlayer.TabIndex = 10;
            btnAddNewPlayer.Text = "Add";
            btnAddNewPlayer.UseVisualStyleBackColor = false;
            btnAddNewPlayer.Click += btnAddNewPlayer_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = SystemColors.ActiveCaption;
            btnUpdate.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnUpdate.Location = new Point(71, 639);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 36);
            btnUpdate.TabIndex = 11;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = SystemColors.ActiveCaption;
            btnDelete.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnDelete.Location = new Point(71, 681);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(190, 36);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // panelBorder
            // 
            panelBorder.Controls.Add(panelCard);
            panelBorder.Location = new Point(352, 69);
            panelBorder.Name = "panelBorder";
            panelBorder.Size = new Size(340, 394);
            panelBorder.TabIndex = 10;
            // 
            // textBoxTouchdowns
            // 
            textBoxTouchdowns.Location = new Point(157, 464);
            textBoxTouchdowns.Name = "textBoxTouchdowns";
            textBoxTouchdowns.Size = new Size(161, 23);
            textBoxTouchdowns.TabIndex = 14;
            // 
            // textBoxYards
            // 
            textBoxYards.Location = new Point(157, 506);
            textBoxYards.Name = "textBoxYards";
            textBoxYards.Size = new Size(161, 23);
            textBoxYards.TabIndex = 15;
            // 
            // btnSelectImage
            // 
            btnSelectImage.BackColor = SystemColors.ActiveBorder;
            btnSelectImage.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnSelectImage.Location = new Point(71, 597);
            btnSelectImage.Name = "btnSelectImage";
            btnSelectImage.Size = new Size(190, 36);
            btnSelectImage.TabIndex = 16;
            btnSelectImage.Text = "Select Image";
            btnSelectImage.UseVisualStyleBackColor = false;
            btnSelectImage.Click += btnSelectImage_Click;
            // 
            // lblTouchdowns
            // 
            lblTouchdowns.AutoSize = true;
            lblTouchdowns.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblTouchdowns.ForeColor = Color.Black;
            lblTouchdowns.Location = new Point(538, 591);
            lblTouchdowns.Name = "lblTouchdowns";
            lblTouchdowns.Size = new Size(111, 26);
            lblTouchdowns.TabIndex = 17;
            lblTouchdowns.Text = "Touch Downs";
            // 
            // lblYards
            // 
            lblYards.AutoSize = true;
            lblYards.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblYards.ForeColor = Color.Black;
            lblYards.Location = new Point(538, 631);
            lblYards.Name = "lblYards";
            lblYards.Size = new Size(55, 26);
            lblYards.TabIndex = 18;
            lblYards.Text = "Yards";
            // 
            // lblRatings
            // 
            lblRatings.AutoSize = true;
            lblRatings.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            lblRatings.ForeColor = Color.Black;
            lblRatings.Location = new Point(538, 671);
            lblRatings.Name = "lblRatings";
            lblRatings.Size = new Size(68, 26);
            lblRatings.TabIndex = 19;
            lblRatings.Text = "Ratings";
            // 
            // textBoxRatings
            // 
            textBoxRatings.Location = new Point(157, 546);
            textBoxRatings.Name = "textBoxRatings";
            textBoxRatings.Size = new Size(161, 23);
            textBoxRatings.TabIndex = 20;
            // 
            // textBoxAddRatings
            // 
            textBoxAddRatings.Location = new Point(894, 339);
            textBoxAddRatings.Name = "textBoxAddRatings";
            textBoxAddRatings.Size = new Size(190, 23);
            textBoxAddRatings.TabIndex = 26;
            // 
            // textBoxAddYards
            // 
            textBoxAddYards.Location = new Point(894, 294);
            textBoxAddYards.Name = "textBoxAddYards";
            textBoxAddYards.Size = new Size(190, 23);
            textBoxAddYards.TabIndex = 25;
            // 
            // textBoxAddTouchdowns
            // 
            textBoxAddTouchdowns.Location = new Point(894, 251);
            textBoxAddTouchdowns.Name = "textBoxAddTouchdowns";
            textBoxAddTouchdowns.Size = new Size(190, 23);
            textBoxAddTouchdowns.TabIndex = 24;
            // 
            // textBoxAddGamesPlayed
            // 
            textBoxAddGamesPlayed.Location = new Point(894, 210);
            textBoxAddGamesPlayed.Name = "textBoxAddGamesPlayed";
            textBoxAddGamesPlayed.Size = new Size(190, 23);
            textBoxAddGamesPlayed.TabIndex = 23;
            // 
            // textBoxAddTeam
            // 
            textBoxAddTeam.Location = new Point(894, 174);
            textBoxAddTeam.Name = "textBoxAddTeam";
            textBoxAddTeam.Size = new Size(190, 23);
            textBoxAddTeam.TabIndex = 22;
            // 
            // textBoxAddName
            // 
            textBoxAddName.Location = new Point(894, 136);
            textBoxAddName.Name = "textBoxAddName";
            textBoxAddName.Size = new Size(190, 23);
            textBoxAddName.TabIndex = 21;
            // 
            // btnAddImage
            // 
            btnAddImage.BackColor = SystemColors.ActiveBorder;
            btnAddImage.Font = new Font("Segoe Print", 12F, FontStyle.Bold);
            btnAddImage.Location = new Point(894, 377);
            btnAddImage.Name = "btnAddImage";
            btnAddImage.Size = new Size(190, 36);
            btnAddImage.TabIndex = 27;
            btnAddImage.Text = "Upload Image";
            btnAddImage.UseVisualStyleBackColor = false;
            btnAddImage.Click += btnAddImage_Click;
            // 
            // pictureBoxAddPlayer
            // 
            pictureBoxAddPlayer.Location = new Point(1151, 123);
            pictureBoxAddPlayer.Name = "pictureBoxAddPlayer";
            pictureBoxAddPlayer.Size = new Size(267, 320);
            pictureBoxAddPlayer.TabIndex = 5;
            pictureBoxAddPlayer.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(812, 89);
            label1.Name = "label1";
            label1.Size = new Size(186, 28);
            label1.TabIndex = 28;
            label1.Text = "Add New Player Here";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label2.Location = new Point(14, 348);
            label2.Name = "label2";
            label2.Size = new Size(56, 26);
            label2.TabIndex = 29;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label3.Location = new Point(14, 387);
            label3.Name = "label3";
            label3.Size = new Size(54, 26);
            label3.TabIndex = 30;
            label3.Text = "Team";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label4.Location = new Point(14, 461);
            label4.Name = "label4";
            label4.Size = new Size(103, 26);
            label4.TabIndex = 32;
            label4.Text = "Touchdowns";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label5.Location = new Point(14, 422);
            label5.Name = "label5";
            label5.Size = new Size(119, 26);
            label5.TabIndex = 31;
            label5.Text = "Games Played";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label6.Location = new Point(14, 503);
            label6.Name = "label6";
            label6.Size = new Size(55, 26);
            label6.TabIndex = 33;
            label6.Text = "Yards";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label7.Location = new Point(14, 543);
            label7.Name = "label7";
            label7.Size = new Size(68, 26);
            label7.TabIndex = 34;
            label7.Text = "Ratings";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(390, 674);
            label8.Name = "label8";
            label8.Size = new Size(68, 26);
            label8.TabIndex = 40;
            label8.Text = "Ratings";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(390, 634);
            label9.Name = "label9";
            label9.Size = new Size(55, 26);
            label9.TabIndex = 39;
            label9.Text = "Yards";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(390, 592);
            label10.Name = "label10";
            label10.Size = new Size(103, 26);
            label10.TabIndex = 38;
            label10.Text = "Touchdowns";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(390, 553);
            label11.Name = "label11";
            label11.Size = new Size(119, 26);
            label11.TabIndex = 37;
            label11.Text = "Games Played";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(390, 517);
            label12.Name = "label12";
            label12.Size = new Size(54, 26);
            label12.TabIndex = 36;
            label12.Text = "Team";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label13.ForeColor = Color.Red;
            label13.Location = new Point(390, 479);
            label13.Name = "label13";
            label13.Size = new Size(56, 26);
            label13.TabIndex = 35;
            label13.Text = "Name";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label14.Location = new Point(767, 336);
            label14.Name = "label14";
            label14.Size = new Size(68, 26);
            label14.TabIndex = 46;
            label14.Text = "Ratings";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label15.Location = new Point(767, 291);
            label15.Name = "label15";
            label15.Size = new Size(55, 26);
            label15.TabIndex = 45;
            label15.Text = "Yards";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label16.Location = new Point(767, 248);
            label16.Name = "label16";
            label16.Size = new Size(103, 26);
            label16.TabIndex = 44;
            label16.Text = "Touchdowns";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label17.Location = new Point(767, 207);
            label17.Name = "label17";
            label17.Size = new Size(119, 26);
            label17.TabIndex = 43;
            label17.Text = "Games Played";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label18.Location = new Point(767, 171);
            label18.Name = "label18";
            label18.Size = new Size(54, 26);
            label18.TabIndex = 42;
            label18.Text = "Team";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold);
            label19.Location = new Point(767, 133);
            label19.Name = "label19";
            label19.Size = new Size(56, 26);
            label19.TabIndex = 41;
            label19.Text = "Name";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe Print", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.Location = new Point(1193, 89);
            label20.Name = "label20";
            label20.Size = new Size(171, 28);
            label20.TabIndex = 47;
            label20.Text = "Image Preview Here";
            // 
            // TradingCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1578, 740);
            Controls.Add(label20);
            Controls.Add(label14);
            Controls.Add(label15);
            Controls.Add(label16);
            Controls.Add(label17);
            Controls.Add(label18);
            Controls.Add(label19);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBoxAddPlayer);
            Controls.Add(btnAddImage);
            Controls.Add(textBoxAddRatings);
            Controls.Add(textBoxAddYards);
            Controls.Add(textBoxAddTouchdowns);
            Controls.Add(textBoxAddGamesPlayed);
            Controls.Add(textBoxAddTeam);
            Controls.Add(textBoxAddName);
            Controls.Add(textBoxRatings);
            Controls.Add(lblRatings);
            Controls.Add(lblYards);
            Controls.Add(lblTouchdowns);
            Controls.Add(btnSelectImage);
            Controls.Add(textBoxYards);
            Controls.Add(textBoxTouchdowns);
            Controls.Add(panelBorder);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAddNewPlayer);
            Controls.Add(textBoxGamesPlayed);
            Controls.Add(textBoxTeam);
            Controls.Add(textBoxName);
            Controls.Add(lblGamesPlayed);
            Controls.Add(lblTeam);
            Controls.Add(lblName);
            Controls.Add(lblTradingCards);
            Controls.Add(listBoxPlayers);
            Name = "TradingCards";
            Text = "Trading Cards";
            Load += TradingCards_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPlayer).EndInit();
            panelCard.ResumeLayout(false);
            panelBorder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxAddPlayer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxPlayers;
        private Label lblTradingCards;
        private Label lblName;
        private Label lblTeam;
        private PictureBox pictureBoxPlayer;
        private Label lblGamesPlayed;
        private TextBox textBoxName;
        private TextBox textBoxTeam;
        private TextBox textBoxGamesPlayed;
        private Panel panelCard;
        private Button btnAddNewPlayer;
        private Button btnUpdate;
        private Button btnDelete;
        private Panel panelBorder;
        private TextBox textBoxTouchdowns;
        private TextBox textBoxYards;
        private Button btnAddImage;
        private Button btnSelectImage;
        private Label lblTouchdowns;
        private Label lblYards;
        private Label lblRatings;
        private TextBox textBoxRatings;
        private TextBox textBoxAddRatings;
        private TextBox textBoxAddYards;
        private TextBox textBoxAddTouchdowns;
        private TextBox textBoxAddGamesPlayed;
        private TextBox textBoxAddTeam;
        private TextBox textBoxAddName;
        private PictureBox pictureBoxAddPlayer;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
    }
}
