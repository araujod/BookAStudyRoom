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
    public partial class ShowHistory : Form
    {
        public ShowHistory()
        {
            InitializeComponent();
            dropFields.selectedIndex = 0;
        }

        private void ShowHistory_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roombookingDataSet.BookedRoom_table' table. You can move, or remove it, as needed.
            this.bookedRoom_tableTableAdapter.Fill(this.roombookingDataSet.BookedRoom_table);

        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            String[] fields = {"id","user_id", "room_id", "date_booked" };
            SqlConnection conn = DBUtils.GetDBConnection();
            
            string sql = "SELECT * FROM BookedRoom_table where "+ fields[ dropFields.selectedIndex] + " like '%"+txtValue.Text+"%'";
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
