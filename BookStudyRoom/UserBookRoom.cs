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
                sql = "Select * from room_table where " + fields[dropFields.selectedIndex] + " like '%" + txtValue.Text + "%';";
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
                bool[] timeAvailable = GetAvailableTime(reader.GetInt32(0).ToString());
                for (int i = 2; i<11;i++)
                {
                    if (timeAvailable[i - 2])
                    {
                        dataGrid1.Rows[dataGrid1.Rows.Count - 1].Cells[i].Style = ON;
                        dataGrid1.Rows[dataGrid1.Rows.Count - 1].Cells[i].Value = "ON";
                    }
                    else
                    {
                        dataGrid1.Rows[dataGrid1.Rows.Count - 1].Cells[i].Style = OFF;
                        dataGrid1.Rows[dataGrid1.Rows.Count - 1].Cells[i].Value = "OFF";
                    }
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
                bool[] test = GetAvailableTime(roomID);
                BookRoom bookRoom = new BookRoom(roomID, test);                
                bookRoom.ShowDialog();
            }
        }
        private bool[] GetTrueArray()
        {
            bool[] res = new bool[9];
            for(int i=0; i<9; i++)
            {
                res[i] = true;
            }
            return res;
        }
        private bool[] GetAvailableTime(String roomID)
        {
            bool[] result = GetTrueArray();
            SqlConnection connection = DBUtils.GetDBConnection();
            connection.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            String sql = "";
            String today = DateTime.Today.ToString("yyyy-MM-dd");
            
            sql = "Select * from BookedRoom_table where room_id = " + roomID + " and date_booked='" + today + "';";
            
            cmd = new SqlCommand(sql, connection);

            reader = cmd.ExecuteReader();
          
            while (reader.Read())
            {
                Int16 start_time= reader.GetInt16(4);
                Int16 end_time = reader.GetInt16(5);
                
                //Time starts at 9am
                result[(start_time-9)] = false;//It means its being used
                result[(end_time - 10)] = false;//Because it can have a 2h end time.
                
            }

            cmd.Dispose();
            connection.Close();

            return result;
        }
    }
}
