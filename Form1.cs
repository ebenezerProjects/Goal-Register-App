using System.Text.RegularExpressions;

namespace Assignment7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private List<HockeyPlayer> teamPlayers = new List<HockeyPlayer>();
        private string sort = "";


        private void addButton_Click(object sender, EventArgs e)
        {
            if(nameTextBox.Text !="" && jerseyTextBox.Text!="" && goalTextBox.Text != "") 
            { 
            string pName = nameTextBox.Text;
            int jerseyNum = Convert.ToInt32(jerseyTextBox.Text);
            int goals = Convert.ToInt32(goalTextBox.Text);

            HockeyPlayer newPlayer = new HockeyPlayer(pName, jerseyNum, goals);
            teamPlayers.Add(newPlayer);

            updateDisplayListBox();
            clearFields();
            }
            else{
                MessageBox.Show("Please Enter All Fields [Player Name, Jersey Number & Goals]");
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (displayBox.SelectedIndex != null) { 
            int playerIndex = displayBox.SelectedIndex;

                if (nameTextBox.Text != "" && jerseyTextBox.Text != "" && goalTextBox.Text != "") 
                { 
                    string name = nameTextBox.Text;
                    int jerseyNum = Convert.ToInt32(jerseyTextBox.Text);
                    int goals = Convert.ToInt32(goalTextBox.Text);

                    HockeyPlayer updatedPlayer = new HockeyPlayer(name, jerseyNum, goals);
                    teamPlayers[playerIndex] = updatedPlayer;

                    updateDisplayListBox();
                    clearFields();

                }
                else
                {
                    MessageBox.Show("Please Enter All Fields [Player Name, Jersey Number & Goals]");
                }

            }
            else
            {
                MessageBox.Show("Please Double Click on a Player and Edit the Desired Field");
            }

        }


        private void displayBox_DoubleClick(object sender, EventArgs e)
        {
            if (displayBox.SelectedItem != null)
            {
                HockeyPlayer selectedPlayer = (HockeyPlayer)displayBox.SelectedItem;
                nameTextBox.Text = selectedPlayer.PlayerName;
                jerseyTextBox.Text = selectedPlayer.JerseyNumber.ToString();
                goalTextBox.Text = selectedPlayer.GoalsScored.ToString();
            }
        }

        private void nameRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sort = "name";
        }

        private void jerseyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sort = "jerseyNum";
        }

        private void goalRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            sort = "goals";
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(displayBox.Text))
            {
                updateDisplayListBox();
            }
            else
            {
                MessageBox.Show("There is Nothing to Display");
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (HockeyPlayer player in teamPlayers)
                    {
                        writer.WriteLine(player);
                    }
                }
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Use regular expressions to extract valid fields
                        Match match = Regex.Match(line, @"(\S+)\s+(\S+)\s+(\S+)$");

                        if (match.Success && match.Groups.Count == 4)
                        {
                            string name = match.Groups[1].Value;
                            string jerseyStr = match.Groups[2].Value;
                            string goalsStr = match.Groups[3].Value;

                            // Convert jersey number and goals to integers
                            if (int.TryParse(jerseyStr, out int jerseyNum) && int.TryParse(goalsStr, out int goals))
                            {
                                HockeyPlayer newPlayer = new HockeyPlayer(name, jerseyNum, goals);
                                teamPlayers.Add(newPlayer);
                            }
                            else
                            {
                                MessageBox.Show("Failed to Convert String to Numbers");
                            }
                        }
                        else
                        {
                            MessageBox.Show("There are no Matching Values");
                        }
                    }
                }
            }
            updateDisplayListBox();
        }


        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        /*
         * Function: clearFields()
         * This function clears all text input field.
         */
        public void clearFields()
        {
            nameTextBox.Clear();
            jerseyTextBox.Clear();
            goalTextBox.Clear();

            nameRadioButton.Checked = false;
            goalRadioButton.Checked = false;
            jerseyRadioButton.Checked = false;
            reverseCheckBox.Checked = false;
        }

        /*
         * Function: updateDisplayListBox()
         * This function displays all the players in the list box.
         */
        private void updateDisplayListBox()
        {
            displayBox.Items.Clear();
            switch (sort)
            {
                case "name":
                    teamPlayers.Sort((x, y) => string.Compare(x.PlayerName, y.PlayerName));
                    break;
                case "jerseyNum":
                    teamPlayers.Sort((x, y) => x.JerseyNumber.CompareTo(y.JerseyNumber));
                    break;
                case "goals":
                    teamPlayers.Sort((x, y) => x.GoalsScored.CompareTo(y.GoalsScored));
                    break;
            }

            // Reverse the sorted order if the reverseSort flag is true
            if (reverseCheckBox.Checked)
            {
                teamPlayers.Reverse();
            }

            // Populate the playerListBox with the sorted and possibly reversed list of players
            foreach (HockeyPlayer player in teamPlayers)
            {
                displayBox.Items.Add(player);
            }
        }

       
    }

    public class HockeyPlayer : IComparable<HockeyPlayer>
    {
        public string PlayerName { get; }
        public int JerseyNumber { get; }
        public int GoalsScored { get; set; }

        public HockeyPlayer(string name, int number, int goals)
        {
            PlayerName = name;
            JerseyNumber = number;
            GoalsScored = goals;
        }

        public override string ToString()
        {
            return $"{PlayerName,-55} {JerseyNumber,-35} {GoalsScored}";
        }

        public int CompareTo(HockeyPlayer other)
        {
            return PlayerName.CompareTo(other.PlayerName);
        }
    }
}
