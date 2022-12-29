using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using KoloBazilla.Models;

namespace KoloBazilla
{
    public partial class NewGame : Form
    {
        private List<string> _players;
        private string _password;
        private int _vowelPrice;

        public NewGame()
        {
            InitializeComponent();
            playersList.ItemSelectionChanged += PlayersList_ItemSelectionChanged;
        }

        private bool CheckFill()
        {
            if (playersList.Items.Count < 1) return false;
            if (string.IsNullOrEmpty(password_tb.Text)) return false;
            return true;
        }

        private void PlayersList_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (playersList.Items.Count < 1) return;
            try
            {
                playerName_tb.Text = playersList.SelectedItems[0].Text;
            }
            catch { }
        }

        private void addPlayer_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(playerName_tb.Text) || playersList.Items.ContainsKey(playerName_tb.Text)) return;
            ListViewItem newPlayer = new ListViewItem(playerName_tb.Text);
            newPlayer.Name = playerName_tb.Text;
            playersList.Items.Add(newPlayer);
            playerName_tb.Clear();
        }

        private void removePlayer_button_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(playerName_tb.Text) || !playersList.Items.ContainsKey(playerName_tb.Text)) return;
            playersList.Items.RemoveByKey(playerName_tb.Text);
            playerName_tb.Clear();
        }

        private void startGame_button_Click(object sender, EventArgs e)
        {
            if (CheckFill())
            {
                _players = new List<string>();
                foreach (ListViewItem item in playersList.Items)
                {
                    _players.Add(item.Text);
                }
                _password = password_tb.Text;
                _vowelPrice = (int)vowelPrice_numeric.Value;
                Hide();
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie informacje!");
            }
        }

        public List<string> players
        {
            get => _players;
            set => _players = value;
        }

        public string password
        {
            get => _password;
            set => _password = value;
        }

        public int vowelPrice
        {
            get => _vowelPrice;
            set => _vowelPrice = value;
        }
    }
}
