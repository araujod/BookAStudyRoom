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
    public partial class UserHistory : Form
    {
        public UserHistory()
        {
            InitializeComponent();
            dropFields.selectedIndex = 0;

            String[] fields = { "id", "user_id", "room_id", "date_booked" };
            SqlConnection conn = DBUtils.GetDBConnection();

            string sql = "SELECT id as ID, room_id as Room_ID, date_booked as Date, time_start as TimeStart, time_end as TimeEnd, members_qtt as Members FROM BookedRoom_table where user_id= " + DBUtils.currentUserID;
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGrid1.DataSource = ds.Tables[0];

            cmd.Dispose();
            conn.Close();

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String[] fields = { "id", "room_id", "date_booked" };
            SqlConnection conn = DBUtils.GetDBConnection();

            string sql = "SELECT id as ID, room_id as Room_ID, date_booked as Date, time_start as TimeStart, time_end as TimeEnd, members_qtt as Members FROM BookedRoom_table where user_id= " + DBUtils.currentUserID+" and " + fields[dropFields.selectedIndex] + " like '%" + txtValue.Text + "%'";
            conn.Open();

            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGrid1.DataSource = ds.Tables[0];

            cmd.Dispose();
            conn.Close();
        }
    }
}