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
    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
            this.listViewPlayerActive.View = View.LargeIcon;

            this.listViewPlayerActive.LargeImageList = this.imageListPlayers;

            //or 

            //this.listView1.View = View.SmallIcon;

            //this.listView1.SmallImageList = this.imageList1;


            ListViewItem item = new ListViewItem();

            item.ImageIndex = 0;

            this.listViewPlayerActive.Items.Add(item);
            
            listViewPlayerActive.Show();
        }
    }
}
