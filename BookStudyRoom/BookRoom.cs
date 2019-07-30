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
    public partial class BookRoom : Form
    {
        public String roomID = "";
        
        private Bunifu.UI.WinForms.BunifuCheckBox[] checkBoxes = new Bunifu.UI.WinForms.BunifuCheckBox[9];
        private bool[] availableTime = new bool[9];
        private int[] time = new int[9];

        public BookRoom(string room_id, bool[] availability)
        {
            InitializeComponent();
            this.availableTime = availability;
            roomID = room_id;
            txtId.Text = roomID;
            SqlConnection conn = DBUtils.GetDBConnection();

            conn.Open();
            SqlCommand cmd;
            SqlDataReader reader;
            String sql = "";

            sql = "Select * from room_table where id=" + roomID + ";";

            cmd = new SqlCommand(sql, conn);

            reader = cmd.ExecuteReader();

            if (reader.HasRows)
            {
                reader.Read();                
                txtNumber.Text = reader.GetString(1);
                txtBuilding.Text = reader.GetString(2);
                txtCapacity.Text = reader.GetDecimal(3).ToString();
                txtResources.Text = reader.GetString(4);
            }
            cmd.Dispose();
            conn.Close();

            FillCheckBoxList();

           for(int i=0;i<9; i++)
            {
                checkBoxes[i].Visible = availableTime[i];

            }

            txtNumber.Focus();
        }

        private void FillCheckBoxList()
        {
            checkBoxes[0] = cb0;
            checkBoxes[1] = cb1;
            checkBoxes[2] = cb2;
            checkBoxes[3] = cb3;
            checkBoxes[4] = cb4;
            checkBoxes[5] = cb5;
            checkBoxes[6] = cb6;
            checkBoxes[7] = cb7;
            checkBoxes[8] = cb8;
        }

        private void FillTimeList()
        {
            for(int i = 0; i < 9; i++)
            {
                time[i] = 9 + i;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb0_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {

        }
    }
}
