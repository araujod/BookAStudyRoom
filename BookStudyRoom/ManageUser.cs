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
    public partial class ManageUser : Form
    {
        SqlConnection conn;
        public ManageUser()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection();
            dropFields.selectedIndex = 0;
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roombookingDataSet.user_table' table. You can move, or remove it, as needed.
            this.user_tableTableAdapter.Fill(this.roombookingDataSet.user_table);           

        }

        private void dataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid1.SelectedRows.Count>0)
            {
                txtId.Text = dataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text = dataGrid1.SelectedRows[0].Cells[1].Value.ToString();
                txtLogin.Text = dataGrid1.SelectedRows[0].Cells[2].Value.ToString();
                txtPhone.Text = dataGrid1.SelectedRows[0].Cells[3].Value.ToString();
            }
            else
            {
                txtId.Text = "";
                txtName.Text = "";
                txtLogin.Text = "";
                txtPhone.Text = "";
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            int rowIndex = -1;

            DataGridViewRow row;
            IEnumerable<DataGridViewRow> viewRows;
            if (dropFields.selectedIndex > 0)
            {
                viewRows = dataGrid1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[dropFields.selectedIndex].Value.ToString().Contains(txtValue.Text));
            }
            else
            {
                viewRows = dataGrid1.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells[dropFields.selectedIndex].Value.ToString().Equals(txtValue.Text));
            }
            if(viewRows.Count()>0)
            {
                row = viewRows.First();
                rowIndex = row.Index;
                dataGrid1.Rows[rowIndex].Selected = true;
                dataGrid1.FirstDisplayedScrollingRowIndex = rowIndex;
            }
            else
            {
                MessageBox.Show("No value find, please try again!","Find user",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }

        private bool checkLoginExist()
        {
            bool result = false;
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

            return result;
        }
        private bool checkFields(bool add=true)
        {            
            if (txtName.Text.Length > 0)
            {
                if(txtLogin.Text.Length>0)
                {
                    if(txtPhone.Text.Length==10)
                    {
                        if (txtPswd.Text.Length > 0)
                        {
                            if (txtPswd.Text == txtCPswd.Text)
                            {
                                if (!checkLoginExist())
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                conn.Open();
                SqlCommand cmd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";

                sql = "insert into user_table values('" + txtName.Text + "', '" + txtLogin.Text + "', '" + txtPhone.Text + "', '" + txtPswd.Text + "')";

                cmd = new SqlCommand(sql, conn);

                adapter.InsertCommand = cmd;
                adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();

                this.user_tableTableAdapter.Fill(this.roombookingDataSet.user_table);
                dataGrid1.Rows[dataGrid1.RowCount-1].Selected = true;
                dataGrid1.FirstDisplayedScrollingRowIndex = dataGrid1.RowCount-1;

                MessageBox.Show("User Added!", "Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtCPswd.Text = "";
            txtId.Text = "";
            txtLogin.Text = "";
            txtName.Text = "";
            txtPhone.Text = "";
            txtPswd.Text = "";
            txtValue.Text = "";
            dropFields.selectedIndex = 0;
        }
    }
}
