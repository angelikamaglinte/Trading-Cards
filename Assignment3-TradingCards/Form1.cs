namespace Assignment3_TradingCards
{
    public partial class TradingCards : Form
    {
        BindingSource bindingSource = new BindingSource();
        public TradingCards()
        {
            InitializeComponent();
            bindingSource.CurrentChanged += bindingSource_CurrentChanged;
        }

        private void bindingSource_CurrentChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is Player current)
            {
                panelBorder.BorderStyle = BorderStyle.FixedSingle;
                panelBorder.BackColor = Color.Black;

                if (current.Team == "Kansas City Chiefs")
                {
                    panelCard.BackColor = Color.Red;  // Kansas City Chiefs - Red
                }
                else if (current.Team == "Tennessee Titans")
                {
                    panelCard.BackColor = Color.Navy;  // Tennessee Titans - Navy Blue
                }
                else if (current.Team == "Miami Dolphins")
                {
                    panelCard.BackColor = Color.Aqua;  // Miami Dolphins - Aqua
                }
                else
                {
                    panelCard.BackColor = SystemColors.Control;  // Default for other teams
                }
            }
        }

        private void TradingCards_Load(object sender, EventArgs e)
        {
            bindingSource.DataSource = Player.Players;

            listBoxPlayers.DataSource = bindingSource;
            listBoxPlayers.DisplayMember = "Name";

            textBoxName.DataBindings.Add("Text", bindingSource, "Name");
            textBoxTeam.DataBindings.Add("Text", bindingSource, "Team");
            textBoxGamesPlayed.DataBindings.Add("Text", bindingSource, "GamesPlayed");
            textBoxTouchdowns.DataBindings.Add("Text", bindingSource, "Touchdowns");
            textBoxYards.DataBindings.Add("Text", bindingSource, "Yards");
            textBoxRatings.DataBindings.Add("Text", bindingSource, "Rating");
            pictureBoxPlayer.DataBindings.Add("ImageLocation", bindingSource, "PhotoPath");
            pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;

            lblName.DataBindings.Add("Text", bindingSource, "Name");
            lblTeam.DataBindings.Add("Text", bindingSource, "Team");
            lblGamesPlayed.DataBindings.Add("Text", bindingSource, "GamesPlayed");
            lblTouchdowns.DataBindings.Add("Text", bindingSource, "Touchdowns");
            lblYards.DataBindings.Add("Text", bindingSource, "Yards");
            lblRatings.DataBindings.Add("Text", bindingSource, "Rating");
        }


        private void listBoxPlayers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (bindingSource.Current is Player selectedPlayer)
            {
                lblName.Text = selectedPlayer.Name;
                lblTeam.Text = selectedPlayer.Team;
                lblGamesPlayed.Text = selectedPlayer.GamesPlayed.ToString();
                lblTouchdowns.Text = selectedPlayer.Touchdowns.ToString();
                lblYards.Text = selectedPlayer.Yards.ToString();
                lblRatings.Text = selectedPlayer.Rating.ToString();

                pictureBoxPlayer.ImageLocation = selectedPlayer.PhotoPath;
                pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void btnAddNewPlayer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAddName.Text) || string.IsNullOrWhiteSpace(textBoxAddTeam.Text))
            {
                MessageBox.Show("Please provide a Name and Team for the player.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string newPlayerName = textBoxAddName.Text.Trim();
            bool isDuplicate = Player.Players.Any(p => p.Name.Equals(newPlayerName, StringComparison.OrdinalIgnoreCase));

            if (isDuplicate)
            {
                MessageBox.Show("A player with this name already exists. Please enter a unique name.", "Duplicate Player", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Player newPlayer = new Player
            {
                Name = newPlayerName,
                Team = textBoxAddTeam.Text.Trim(),
                PhotoPath = pictureBoxAddPlayer.ImageLocation ?? "", 
                GamesPlayed = int.TryParse(textBoxAddGamesPlayed.Text, out int games) ? games : 0,
                Touchdowns = int.TryParse(textBoxAddTouchdowns.Text, out int touchdowns) ? touchdowns : 0,
                Yards = int.TryParse(textBoxAddYards.Text, out int yards) ? yards : 0,
                Rating = 0 
            };

            Player.Players.Add(newPlayer);

            bindingSource.ResetBindings(false);

            ClearAddPlayerTextboxes();

            MessageBox.Show("Player added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ClearAddPlayerTextboxes()
        {
            textBoxAddName.Clear();
            textBoxAddTeam.Clear();
            textBoxAddGamesPlayed.Clear();
            textBoxAddTouchdowns.Clear();
            textBoxAddYards.Clear();
            textBoxAddRatings.Clear();
            pictureBoxAddPlayer.ImageLocation = null; 
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current == null)
            {
                MessageBox.Show("Please select a player to delete.", "Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Player.Players.Remove((Player)bindingSource.Current);

            bindingSource.ResetBindings(false);
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Player Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    if (bindingSource.Current is Player currentPlayer)
                    {
                        currentPlayer.PhotoPath = openFileDialog.FileName;
                        pictureBoxPlayer.ImageLocation = currentPlayer.PhotoPath;
                        pictureBoxPlayer.SizeMode = PictureBoxSizeMode.Zoom;
                        bindingSource.ResetBindings(false);
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (bindingSource.Current is Player selectedPlayer)
            {
                selectedPlayer.Name = textBoxName.Text;
                selectedPlayer.Team = textBoxTeam.Text;
                selectedPlayer.GamesPlayed = int.TryParse(textBoxGamesPlayed.Text, out int games) ? games : 0;
                selectedPlayer.Touchdowns = int.TryParse(textBoxTouchdowns.Text, out int touchdowns) ? touchdowns : 0;
                selectedPlayer.Yards = int.TryParse(textBoxYards.Text, out int yards) ? yards : 0;

                bindingSource.ResetBindings(false);

                MessageBox.Show("Player details updated successfully!", "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No player selected to update.", "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select a Player Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBoxAddPlayer.ImageLocation = openFileDialog.FileName;
                    pictureBoxAddPlayer.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}