using System;
using System.Collections.ObjectModel;
using System.Windows.Forms;
using KoloBazilla.Models;

namespace KoloBazilla
{
    public partial class MainScreen : Form
    {
        private Game _game;
        public MainScreen()
        {
            InitializeComponent();
            playerBoard.Width = newGame_button.Width;
            wheel_button.Click += Wheel_button_Click;
            wheel_button.Enabled = false;
            newPassword_button.Enabled = false;
            showPassword_button.Enabled = false;
            checkLetter_button.Enabled = false;
        }

        private Game GetNewGame(ObservableCollection<Player> players, string password, int vowelPrice)
        {
            Game game = new Game(players, new Wheel(Wheel.Type.Default), new Password(password), vowelPrice);
            game.players.CollectionChanged += Players_CollectionChanged;
            password_tb.Text = game.password.LettersToString();
            return game;
        }


        private void StartTurn()
        {
            if (_game.password.CheckIfShown()) return;
            _game.NextTurn();
            UpdatePlayerList();
            var vowelBuy = MessageBox.Show("Czy chcesz kupić samogłoskę?", "Samogłoska", MessageBoxButtons.YesNo);
            if (vowelBuy == DialogResult.Yes)
            {
                if (_game.currentPlayer.moneyCount >= _game.vowelPrice)
                {
                    _game.currentPlayer.moneyCount -= _game.vowelPrice;
                    _game.currentPlayer.vowelBought = true;
                }
                else
                    MessageBox.Show("Nie stać Cię na samogłoskę, biedaku.");
            }
            UpdatePlayerList();
            wheel_button.Enabled = true;
            checkLetter_button.Enabled = false;
        }

        private void UpdatePlayerList()
        {
            playerBoard.Items.Clear();
            foreach (Player player in _game.players)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = player.name;
                lvi.SubItems.Add(player.moneyCount.ToString());
                lvi.SubItems.Add(player.smileCount.ToString());
                playerBoard.Items.Add(lvi);
                if (_game.currentPlayer == player)
                    playerBoard.Items[_game.players.IndexOf(player)].Selected = true;
            }
        }

        private void Wheel_button_Click(object sender, EventArgs e)
        {
            if (!wheel_box.Enabled)
            {
                wheel_box.Enabled = true;
                wheel_button.Text = "Zatrzymaj koło";
            } else
            {
                wheel_box.Enabled = false;
                wheel_button.Text = "Zakręć kołem";
                wheelResult_label.Text = $"{(_game.currentField.name == Field.money50.name ? $"{_game.currentField.value} " : "")}{_game.currentField.name}";
                if (_game.currentField.name != Field.secondChance.name)
                {
                    wheel_button.Enabled = false;
                    checkLetter_button.Enabled = true;
                }
                else
                {
                    _game.TakeEffectInstant();
                    return;
                }
                if (_game.currentField.name == Field.turnLoss.name)
                {
                    _game.currentPlayer.vowelBought = false;
                    StartTurn();
                }
            }
        }

        private void Players_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            UpdatePlayerList();
        }

        private void checkLetter_button_Click(object sender, EventArgs e)
        {
            try
            {
                bool result =
                    _game.password.CheckLetter(checkLetter_tb.Text.ToUpper().ToCharArray()[0],
                        _game.currentPlayer.vowelBought);
                if (result)
                {
                    UpdatePassword();
                    if (!_game.currentPlayer.vowelBought)
                        _game.TakeEffectPositive();
                }
                else
                {
                    if (!incorrectLetters_box.Text.Contains(checkLetter_tb.Text.ToUpper()))
                    {
                        incorrectLetters_box.Text += checkLetter_tb.Text.ToUpper();
                        _game.password.incorrectLetters += checkLetter_tb.Text.ToUpper();
                        if (!_game.currentPlayer.vowelBought)
                            _game.TakeEffectNegative();
                    }
                }

                if (!_game.currentPlayer.vowelBought)
                {
                    checkLetter_button.Enabled = false;
                    StartTurn();
                }
                else
                {
                    _game.currentPlayer.vowelBought = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            checkLetter_tb.Clear();
        }

        private void showPassword_button_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Czy jesteś pewny ujawnienia hasła?", "Pokaż hasło", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                _game.password.ShowPassword();
                UpdatePassword();
            }
        }

        private void UpdatePassword()
        {
            password_tb.Text = _game.password.LettersToString();
            newPassword_button.Enabled = _game.password.CheckIfShown();
        }

        private void newGame_button_Click(object sender, EventArgs e)
        {
            NewGame ng = new NewGame();
            ng.ShowDialog();
            try
            {
                ObservableCollection<Player> players = new ObservableCollection<Player>();
                foreach (string name in ng.players)
                {
                    players.Add(new Player(name));
                }
                _game = GetNewGame(players, ng.password, ng.vowelPrice);
                ng.Close();
                wheelResult_label.Text = string.Empty;
                showPassword_button.Enabled = true;
                StartTurn();
            }
            catch { }
        }

        private void newPassword_button_Click(object sender, EventArgs e)
        {
            NewPassword nw = new NewPassword();
            nw.ShowDialog();
            try
            {
                Password newPassword = new Password(nw.password);
                _game.password = newPassword;
                UpdatePassword();
                nw.Close();
                wheelResult_label.Text = string.Empty;
                showPassword_button.Enabled = true;
                incorrectLetters_box.Clear();
                StartTurn();
            }
            catch { }
        }

        private void about_button_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }
    }
}