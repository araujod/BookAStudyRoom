using System;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BookStudyRoom
{
    public partial class UserProfile : Form
    {
        SqlConnection conn;
        String userDefaulLogin="";
        public UserProfile()
        {
            InitializeComponent();
            
            SqlConnection conn = DBUtils.GetDBConnection();

            conn.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            String sql = "";

            sql = "Select * from user_table where id=" + DBUtils.currentUserID + ";";

            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();
                txtId.Text = DBUtils.currentUserID;
                txtName.Text =reader.GetString(1);
                txtLogin.Text = reader.GetString(2);
                txtPhone.Text = reader.GetString(3);
                userDefaulLogin = txtLogin.Text;
            }
            cmd.Dispose();
            conn.Close();

            txtName.Focus();
        }

        private bool checkLoginExist()
        {
            bool result = false;
            if (!userDefaulLogin.Equals(txtLogin.Text))            
            { 
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                SqlCommand cmd;
                SqlDataReader reader;
                String sql = "";

                sql = "Select * from user_table where login='" + txtLogin.Text + "';";

                cmd = new SqlCommand(sql, conn);

                reader = cmd.ExecuteReader();

                result = reader.HasRows;
                cmd.Dispose();
                conn.Close();
            }
            return result;
        }
        private bool checkFields(bool add = true)
        {
            if (txtName.Text.Length > 0)
            {
                if (txtLogin.Text.Length > 0)
                {
                    if (txtPhone.Text.Length == 10)
                    {
                        if (txtPswd.Text.Length > 0)
                        {
                            if (txtPswd.Text == txtCPswd.Text)
                            {

                                if ((!checkLoginExist()) || (!add))
                                {
                                    return true;
                                }
                                else
                                {
                                    MessageBox.Show("Login not available! Choose another one", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                MessageBox.Show("Confirm Password is different!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Please Enter a Password!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Phone Number is Incorrect", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a login!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter a name!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return false;
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                SqlCommand cmd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";
                String encryptPswd = StringCipher.Encrypt(txtPswd.Text);

                sql = "update user_table set name='" + txtName.Text + "', login='" + txtLogin.Text + "', phone='" + txtPhone.Text + "', password='" + encryptPswd + "' where id='" + txtId.Text + "';";

                cmd = new SqlCommand(sql, conn);

                adapter.UpdateCommand = cmd;
                int result = adapter.UpdateCommand.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();               

                if (result > 0)
                {
                    MessageBox.Show("User Updated!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
