using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _31Savage
{
    public partial class InterfaceEnregPlayersForm : Form
    {
        private string nb3players = "3 players";
        private string nb4players = "4 players";
        private string nb5players = "5 players";
        private string nb6players = "6 players";
        private int nbPlayer;

        public InterfaceEnregPlayersForm()
        {
            InitializeComponent();
            listBox_nbPlayer.Items.Add(nb3players);
            listBox_nbPlayer.Items.Add(nb4players);
            listBox_nbPlayer.Items.Add(nb5players);
            listBox_nbPlayer.Items.Add(nb6players);
        }

        private void listBox_nbPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedPlayerNb = (string)listBox_nbPlayer.SelectedItem;
            if (selectedPlayerNb == nb3players)
                nbPlayer = 3;
            else if (selectedPlayerNb == nb4players)
                nbPlayer = 4;
            else if (selectedPlayerNb == nb5players)
                nbPlayer = 5;
            else if (selectedPlayerNb == nb6players)
                nbPlayer = 6;
            else
                nbPlayer = 1;
            
        }
    }
}
