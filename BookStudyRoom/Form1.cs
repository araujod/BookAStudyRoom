using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStudyRoom
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Equals("Admin"))
            {
                if (txtPswd.Text.Equals("Admin"))
                {
                    txtName.Text = "";
                    txtPswd.Text = "";
                    Admin admin = new Admin();
                    admin.ShowDialog(this);
                }
            }
        }
    }
}
