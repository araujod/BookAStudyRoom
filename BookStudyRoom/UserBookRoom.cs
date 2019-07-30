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
    public partial class UserBookRoom : Form
    {
        SqlConnection conn;
        DataGridViewCellStyle ON = new DataGridViewCellStyle();
        DataGridViewCellStyle OFF = new DataGridViewCellStyle();
        public UserBookRoom()
        {
            InitializeComponent();
            conn = DBUtils.GetDBConnection();
            dropFields.selectedIndex = 0;
            ON.ForeColor = Color.Green;            
            OFF.ForeColor = Color.Red;
            this.dataGrid1.GridColor = Color.Black;
            this.dataGrid1.BorderStyle = BorderStyle.FixedSingle;
            this.dataGrid1.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            this.dataGrid1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.dataGrid1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String[] fields = { "id", "number", "building", "capacity","resources" };
            
            conn.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            String sql = "";
            if (txtValue.Text.Trim().Length > 0)
            {
                sql = "Select * from room_table where " + fields[dropFields.selectedIndex] + " = '" + txtValue.Text + "';";
            }
            else
            {
                sql = "Select * from room_table ";
            }

            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();

            dataGrid1.Rows.Clear();
            while (reader.Read())
            {
                dataGrid1.Rows.Add();
                dataGrid1.Rows[dataGrid1.Rows.Count - 1].Cells[0].Value = reader.GetInt32(0).ToString();
                dataGrid1.Rows[dataGrid1.Rows.Count - 1].Cells[1].Value = reader.GetString(1);
                for(int i = 2; i<11;i++)
                {
                    dataGrid1.Rows[dataGrid1.Rows.Count - 1].Cells[i].Style = ON;
                    dataGrid1.Rows[dataGrid1.Rows.Count - 1].Cells[i].Value = "ON";
                }                
            }

            cmd.Dispose();
            conn.Close();
        }        

        private void dataGrid1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                string roomID = dataGrid1.Rows[e.RowIndex].Cells[0].Value.ToString();
                BookRoom bookRoom = new BookRoom(roomID);                
                bookRoom.ShowDialog();
            }
        }
    }
}
