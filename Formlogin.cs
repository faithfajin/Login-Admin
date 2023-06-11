using Login_dan_Register_Project_PBO_A;

namespace DesktopApp
{
    public partial class Formlogin : Form
    {
        public Formlogin()
        {
            InitializeComponent();
        }

        //string CnS = "Host=localhost:5432;Username=postgres;Password=faith010304;Database=postgres";


        private void Formlogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Selemat datang ", "login berhasil");
            new dashboard().Show();
            this.Hide();
            //using (NpgsqlConnection connection = new NpgsqlConnection(CnS))
            //{
            //    connection.Open();
            //    {
            //        if (txtPassword.Text != string.Empty || txtUsername.Text != string.Empty)
            //        {

            //            NpgsqlCommand command = new NpgsqlCommand("select * from table_admin where username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'", connection);
            //            NpgsqlDataReader dr = command.ExecuteReader();
            //            if (dr.Read())
            //            {
            //                MessageBox.Show("Selemat datang ", "login berhasil");
            //                dashboard form2 = new dashboard();
            //                form2.Show();
            //                this.Hide();
            //            }
            //            else
            //            {
            //                dr.Close();
            //                MessageBox.Show("Silahkan periksa kembali username and password ", "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }

            //        }
            //        else
            //        {
            //            MessageBox.Show("Silahkan isi username dan password.", "Gagal login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //}


        }


        private void checkBoxTampilkanPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTampilkanPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

    }
}
