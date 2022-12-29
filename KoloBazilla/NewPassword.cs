using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoloBazilla
{
    public partial class NewPassword : Form
    {
        private string _password;

        public NewPassword()
        {
            InitializeComponent();
        }

        public string password
        {
            get => _password;
            set => _password = value;
        }

        private void startRound_button_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(password_tb.Text))
            {
                password = password_tb.Text;
                Hide();
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie informacje!");
            }
        }
    }
}
