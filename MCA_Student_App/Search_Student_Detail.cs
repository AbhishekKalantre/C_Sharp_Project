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

namespace MCA_Student_App
{
    public partial class frm_Search_Student_Detail : Form
    {
        public frm_Search_Student_Detail()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=.;Integrated Security=True;Encrypt=False ");

        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        void Clear_Controls()
        {
            tb_Roll_no.Text = "";
            tb_Name.Text = "";
            tb_Mobile_No.Text = "";
            dtp_DOB.Text = "";
           
            tb_Name.Focus();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            Con_Open();
            SqlCommand Cmd = new SqlCommand("Select * From Student_Details Where Roll_no = @Rno", Con);
            Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_no.Text;
            SqlDataReader Dr = Cmd.ExecuteReader();
            if (Dr.Read())
            {
                tb_Name.Text = Dr.GetString(Dr.GetOrdinal("Name"));
                tb_Mobile_No.Text = (Dr["Mobile_No"].ToString());
                dtp_DOB.Text = (Dr["D.O.B."].ToString());
                cmb_Course.Text = Dr.GetString(Dr.GetOrdinal("Course"));
            }
            else
            {
                MessageBox.Show("Invalid Roll No.", "Roll No Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                tb_Roll_no.Clear();
            }
            Con_Close();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Roll_no.Text !="" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && dtp_DOB.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();
                Cmd.Connection = Con;
                Cmd.CommandText = "Insert Into Student_Details Values(@Rno,@Nm, @Mno,@DOB,@Cou)";
                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_no.Text;
                Cmd.Parameters.Add("Nm", SqlDbType.NVarChar).Value = tb_Name.Text;
                Cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                Cmd.Parameters.Add("DOB",SqlDbType.Date).Value = dtp_DOB.Text;
                Cmd.Parameters.Add("Cou", SqlDbType.NVarChar).Value = cmb_Course.Text;
                Cmd.ExecuteNonQuery();
                MessageBox.Show("Data Insert SuccessFully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Data Incomplete", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Con_Close();
            Clear_Controls();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();

        }

        private void btn_Student_list_Click(object sender, EventArgs e)
        {
            frm_Student_list obj = new frm_Student_list();
            obj.Show();
            this.Hide();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure Do You Want To Logout??", "Logging Out", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
            Frm_Login obj = new Frm_Login();
            obj.Show();
            this.Hide();
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are You Sure Do You Want To Close??", "Close", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_add_student_detail obj = new frm_add_student_detail();
            obj.Show();
            this.Hide();
        }
        private void Only_Number(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void Only_Char(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
