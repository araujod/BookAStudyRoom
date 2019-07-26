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
    public partial class Admin : Form
    {
        ManageUser userForm = new ManageUser();
        ManageRooms roomsForm = new ManageRooms();
        ShowHistory historyForm = new ShowHistory();
        bool userFormOpen = false;
        bool roomsFormOpen = false;
        bool historyFormOpen = false;

        public Admin()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if(userFormOpen) userForm.Close();
            if (roomsFormOpen) roomsForm.Close();
            if (historyFormOpen) historyForm.Close();
            this.Close();
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            if (roomsFormOpen) roomsForm.Hide();
            if (historyFormOpen) historyForm.Hide();
            userFormOpen = true;
            userForm.TopLevel = false;
            pnlContent.Controls.Add(userForm);
            userForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            userForm.Dock = DockStyle.Fill;
            userForm.Show();
        }

        private void btnRooms_Click(object sender, EventArgs e)
        {
            if (userFormOpen) userForm.Hide();
            if (historyFormOpen) historyForm.Hide();
            roomsFormOpen = true;
            roomsForm.TopLevel = false;
            pnlContent.Controls.Add(roomsForm);
            roomsForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            roomsForm.Dock = DockStyle.Fill;
            roomsForm.Show();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (userFormOpen) userForm.Hide();
            if (roomsFormOpen) roomsForm.Hide();
            historyFormOpen = true;
            historyForm.TopLevel = false;
            pnlContent.Controls.Add(historyForm);
            historyForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            historyForm.Dock = DockStyle.Fill;
            historyForm.Show();
        }
    }
}
