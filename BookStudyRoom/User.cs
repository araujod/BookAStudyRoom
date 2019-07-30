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
    public partial class User : Form
    {
        UserBookRoom userBookForm = new UserBookRoom();
        UserProfile userProfileForm = new UserProfile();
        UserHistory userHistoryForm = new UserHistory();
        bool userBookFormOpen = false;
        bool userProfileFormOpen = false;
        bool userHistoryFormOpen = false;

        public User()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (userProfileFormOpen) userProfileForm.Hide();
            if (userHistoryFormOpen) userHistoryForm.Hide();
            userBookFormOpen = true;
            userBookForm.TopLevel = false;
            pnlContent.Controls.Add(userBookForm);
            userBookForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            userBookForm.Dock = DockStyle.Fill;
            userBookForm.Show();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {

            if (userBookFormOpen) userBookForm.Hide();
            if (userHistoryFormOpen) userHistoryForm.Hide();
            userProfileFormOpen = true;
            userProfileForm.TopLevel = false;
            pnlContent.Controls.Add(userProfileForm);
            userProfileForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            userProfileForm.Dock = DockStyle.Fill;
            userProfileForm.Show();

        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (userBookFormOpen) userBookForm.Hide();
            if (userProfileFormOpen) userProfileForm.Hide();
            userHistoryFormOpen = true;
            userHistoryForm.TopLevel = false;
            pnlContent.Controls.Add(userHistoryForm);
            userHistoryForm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            userHistoryForm.Dock = DockStyle.Fill;
            userHistoryForm.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (userBookFormOpen) userBookForm.Close();
            if (userProfileFormOpen) userProfileForm.Close();
            if (userHistoryFormOpen) userHistoryForm.Close();
            this.Close();
        }
    }
}
