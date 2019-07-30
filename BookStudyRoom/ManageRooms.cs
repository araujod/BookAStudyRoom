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
    public partial class ManageRooms : Form
    {
        SqlConnection conn;
        public ManageRooms()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection();
            dropFields.selectedIndex = 0;
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
             // TODO: This line of code loads data into the 'roombookingDataSet.room_table' table. You can move, or remove it, as needed.
            this.room_tableTableAdapter.Fill(this.roombookingDataSet.room_table);            

        }

        private void dataGrid1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid1.SelectedRows.Count > 0)
            {
                txtId.Text = dataGrid1.SelectedRows[0].Cells[0].Value.ToString();
                txtNumber.Text = dataGrid1.SelectedRows[0].Cells[1].Value.ToString();
                txtBuilding.Text = dataGrid1.SelectedRows[0].Cells[2].Value.ToString();
                txtCapacity.Text = dataGrid1.SelectedRows[0].Cells[3].Value.ToString();
                txtResources.Text = dataGrid1.SelectedRows[0].Cells[4].Value.ToString();
            }
            else
            {
                txtBuilding.Text = "";
                txtId.Text = "";
                txtCapacity.Text = "";
                txtNumber.Text = "";
                txtResources.Text = "";
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtBuilding.Text = "";
            txtId.Text = "";
            txtCapacity.Text = "";
            txtNumber.Text = "";
            txtResources.Text = "";            
            txtValue.Text = "";
            dropFields.selectedIndex = 0;
        }

        private bool checkFields(bool add = true)
        {
            if (txtBuilding.Text.Length > 0)
            {
                if (txtCapacity.Text.Length > 0)
                {
                    if (txtNumber.Text.Length>0)
                    {
                        if (txtResources.Text.Length > 0)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Please Enter the resources!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Room Number is Incorrect", "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter the room capacity", "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Please enter the room building!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                sql = "insert into room_table values('" + txtNumber.Text + "', '" + txtBuilding.Text + "', " + txtCapacity.Text + ", '" + txtResources.Text + "')";

                cmd = new SqlCommand(sql, conn);

                adapter.InsertCommand = cmd;
                int result = adapter.InsertCommand.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();

                this.room_tableTableAdapter.Fill(this.roombookingDataSet.room_table);
                
                if (dataGrid1.RowCount > 0)
                {
                    int lastRow = dataGrid1.RowCount - 1;
                    dataGrid1.Rows[lastRow].Selected = true;
                    dataGrid1.FirstDisplayedScrollingRowIndex = lastRow;
                }
                
                if (result > 0)
                {
                    MessageBox.Show("Room Added!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error adding room!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUpd_Click(object sender, EventArgs e)
        {
            if (checkFields(false))
            {
                conn.Open();
                SqlCommand cmd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";

                sql = "update room_table set number='" + txtNumber.Text + "', building='" + txtBuilding.Text + "', capacity=" + txtCapacity.Text + ", resources='" + txtResources.Text + "' where id='" + txtId.Text + "';";

                cmd = new SqlCommand(sql, conn);

                adapter.UpdateCommand = cmd;
                int result = adapter.UpdateCommand.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();

                this.room_tableTableAdapter.Fill(this.roombookingDataSet.room_table);

                if (result > 0)
                {
                    MessageBox.Show("Room Updated!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Update failed!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want to delete the Room?", "Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                && (txtId.Text.Length > 0))
            {
                conn.Open();
                SqlCommand cmd;
                SqlDataAdapter adapter = new SqlDataAdapter();
                String sql = "";

                sql = "delete room_table where id=" + txtId.Text;

                cmd = new SqlCommand(sql, conn);

                adapter.DeleteCommand = cmd;
                int result = adapter.DeleteCommand.ExecuteNonQuery();

                cmd.Dispose();
                conn.Close();

                this.room_tableTableAdapter.Fill(this.roombookingDataSet.room_table);

                if (result > 0)
                {
                    MessageBox.Show("Room Deleted!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Deletion failed!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Operation canceled!", "Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (viewRows.Count() > 0)
            {
                row = viewRows.First();
                rowIndex = row.Index;
                dataGrid1.Rows[rowIndex].Selected = true;
                dataGrid1.FirstDisplayedScrollingRowIndex = rowIndex;
            }
            else
            {
                MessageBox.Show("No value find, please try again!", "Find Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
