using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookStudyRoom
{
    public partial class Home : Form
    {
        const string ADM_LOG = "Admin";
        string ADM_PSW = StringCipher.Encrypt("Admin");
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

            if (txtName.Text.Equals(ADM_LOG))
            {
                String decrypt = StringCipher.Decrypt(ADM_PSW);
                if (txtPswd.Text.Equals(decrypt))
                {
                    txtName.Text = "";
                    txtPswd.Text = "";
                    Admin admin = new Admin();
                    admin.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Wrong Password or Login!", "Home", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (VerifyLogin())
                {
                    txtName.Text = "";
                    txtPswd.Text = "";
                    User userForm = new User();
                    userForm.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("Wrong Password or Login!", "Home", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private bool VerifyLogin()
        {
            bool result = false;
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            String sql = "";

            sql = "Select * from user_table where login='" + txtName.Text + "';";

            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();

            if (reader.HasRows)                
            {
                reader.Read();
                String encryptPswd = reader.GetString(4);
                String decryptPswd = StringCipher.Decrypt(encryptPswd);
                if (decryptPswd.Equals(txtPswd.Text))
                {
                    DBUtils.currentUserID = reader.GetInt32(0).ToString();
                    result = true;
                }
            }
            cmd.Dispose();
            conn.Close();

            return result;
        }
    }
}
