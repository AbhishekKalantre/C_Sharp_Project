using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCA_Student_App
{
    public partial class frm_add_student_detail : Form
    {
        public frm_add_student_detail()
        {
            InitializeComponent();
        }

        SqlConnection Con = new SqlConnection(@"Data Source=.;Integrated Security=True;Encrypt=False");

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
        private void Roll_no(object sender, KeyPressEventArgs e)
        {

        }
        private void Only_Name(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        private void Mobile_no(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Roll_no.Text = "";
            tb_Name.Text = "";
            tb_Mobile_No.Text = "";
            dtp_DOB.Text = "";
            cmb_Course.Text = "";
            tb_Name.Focus();

        }
        int Auto_Incr()
        {
            int Cnt = 0;

            Con_Open();

            SqlCommand cmd = new SqlCommand();

            cmd.Connection = Con;
            cmd.CommandText = "Select Count(*) from student_details";

            Cnt = Convert.ToInt32(cmd.ExecuteScalar());

            cmd.Dispose();

            if (Cnt > 0)
            {
                cmd.Connection = Con;
                cmd.CommandText = "Select Max(Roll_no) from student_details";

                Cnt = Convert.ToInt32(cmd.ExecuteScalar());
            }
            else
            {
                Cnt = 0;
            }
            Con_Close();

            return Cnt + 1;
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Roll_no.Text != "" &&  tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;

                cmd.CommandText = "Insert Into Student_Details values(@RNo,@Name,@MNo,@DOB,@Course)";

                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_no.Text;
                cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("MNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("DOB", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Data Insert Successfull","Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear_Controls();
            }
            else
            {
                MessageBox.Show("Incomplete Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Con.Close();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
           Clear_Controls();
        }

        private void btn_Student_list_Click(object sender, EventArgs e)
        {
           frm_Student_list obj =  new frm_Student_list();
           obj.Show();
            this.Hide();
        }

        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Logout??", "Logging Out", MessageBoxButtons.YesNo);

            if (Res == DialogResult.Yes)

            {
                Frm_Login obj = new Frm_Login();
                obj.Show();
                this.Hide();
            }

        }
        private void btn_close_Click(object sender, EventArgs e)

        {
            DialogResult Res = MessageBox.Show("Are You Sure Do You Want To Close this Application??", "Closing", MessageBoxButtons.YesNo);

            if (Res == DialogResult.Yes)
            {
                this.Close();
            }
        }
        private void frm_add_student_detail_Load(object sender, EventArgs e)
        {
            tb_Roll_no.Text = Convert.ToString(Auto_Incr());
          
        }

        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student_Detail obj = new frm_Search_Student_Detail();
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

        private void lbl_User_Click(object sender, EventArgs e)
        {

        }
    }
}
