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
        private SqlConnection conn = DBUtils.GetDBConnection();

        private Bunifu.UI.WinForms.BunifuCheckBox[] checkBoxes = new Bunifu.UI.WinForms.BunifuCheckBox[9];
        private bool[] availableTime = new bool[9];
        private int[] time = new int[9];
        private int firstCheckBoxChose = -1;

        public BookRoom(string room_id, bool[] availability)
        {
            InitializeComponent();
            this.availableTime = availability;
            roomID = room_id;
            txtId.Text = roomID;
            

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
            FillTimeList();

            DisplayAvailable();

            txtNumber.Focus();
        }

        private void DisplayAvailable()
        {
            for (int i = 0; i < 9; i++)
            {
                checkBoxes[i].Visible = availableTime[i];
            }
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
            Bunifu.UI.WinForms.BunifuCheckBox cb = ((Bunifu.UI.WinForms.BunifuCheckBox)sender);
            int checkBoxClicked = Int32.Parse(cb.Name.Replace("cb", ""));
            
            if (e.Checked)
            {
                if (firstCheckBoxChose==-1)
                {
                    EveryoneInvisibleButMe(checkBoxClicked);

                    firstCheckBoxChose = checkBoxClicked;
                    if (checkBoxClicked > 0)
                    {
                        if (availableTime[checkBoxClicked-1]) //Enable 1h before time, if available
                        {
                            checkBoxes[checkBoxClicked - 1].Visible = true;
                        }
                    }
                    if (checkBoxClicked < 8)
                    {
                        if (availableTime[checkBoxClicked + 1]) //Enable 1h after time, if available
                        {
                            checkBoxes[checkBoxClicked + 1].Visible = true;
                        }
                    }
                }
                else //Second choosing
                {                    
                    if (firstCheckBoxChose > 0)
                    {
                        //Disable 1h before time, if available
                        if ((availableTime[firstCheckBoxChose - 1])&&(checkBoxClicked != (firstCheckBoxChose - 1))) 
                        {
                            checkBoxes[firstCheckBoxChose - 1].Visible = false;
                        }
                    }
                    if (firstCheckBoxChose < 8)
                    {
                        //Disable 1h after time, if available
                        if ( (availableTime[firstCheckBoxChose + 1]) && ((firstCheckBoxChose + 1) != checkBoxClicked))
                        {
                            checkBoxes[firstCheckBoxChose + 1].Visible = false;
                        }
                    }
                }
            }
            else
            {
                if (firstCheckBoxChose == checkBoxClicked)
                {
                    //Clean selections
                    firstCheckBoxChose = -1;
                    DisplayAvailable();
                    UnselectAll();
                }
                else
                {
                    if (firstCheckBoxChose > 0)
                    {
                        if (availableTime[firstCheckBoxChose - 1]) //Enable 1h before time, if available
                        {
                            checkBoxes[firstCheckBoxChose - 1].Visible = true;
                        }
                    }
                    if (firstCheckBoxChose < 8)
                    {
                        if (availableTime[firstCheckBoxChose + 1]) //Enable 1h after time, if available
                        {
                            checkBoxes[firstCheckBoxChose + 1].Visible = true;
                        }
                    }
                }
            }
        }

        private void UnselectAll()
        {
            for (int i = 0; i <9; i++)
            {
                checkBoxes[i].Checked = false;
            }
        }

        private void EveryoneInvisibleButMe(int indexVisible)
        {
            for(int i=0; i <9; i++)
            {
                if(i!=indexVisible)
                {
                    checkBoxes[i].Visible = false;
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            int capacity = Int32.Parse(txtCapacity.Text);
            int members = 0;
            Int32.TryParse(txtMembers.Text,out members);

            if ((members<1) ||(members > capacity))
            {
                MessageBox.Show("Enter a valid members quantity! Higher than 0 and Lower than capacity", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int startTime = -1;
            int endTime = -1;

            //Verify if there is at least one checked
            for (int i = 0; i <9; i++)
            {
                if( startTime == -1)
                {
                    if(checkBoxes[i].Checked)
                    {
                        startTime = time[i];
                    }
                }
                else  if ( endTime == -1)
                {
                    if (checkBoxes[i].Checked)
                    {
                        endTime = time[i];
                        break;
                    }
                }
            }

            String today = DateTime.Today.ToString("yyyy-MM-dd");

            if (startTime == -1)
            {
                MessageBox.Show("Please select a time!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(endTime==-1)
            {
                endTime = startTime + 1;
            }
            else
            {
                endTime++;
            }

            conn.Open();
            SqlCommand cmd;
            SqlDataAdapter adapter = new SqlDataAdapter();
            String sql = "";            

            sql = "insert into BookedRoom_table values(" + DBUtils.currentUserID + ", " + roomID + ", '" + today + "', " + startTime + ", " + endTime + ", " + members + ")";

            cmd = new SqlCommand(sql, conn);

            adapter.InsertCommand = cmd;
            int result = adapter.InsertCommand.ExecuteNonQuery();

            cmd.Dispose();
            conn.Close();
            if (result == 1)
            {
                MessageBox.Show("Study room booked", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error booking room!", "Booking", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            
        }
    }
}
