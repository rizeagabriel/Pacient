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
using System.Net.NetworkInformation;

namespace Proiect
{

    
    public partial class Form1 : Form
    {
        // -------------- INIT. INTERNET SI BAZA DATE ---------------------------------------------------------------------------------------------------
        
        SqlConnection conect = new SqlConnection(@"Data Source=pacienti.database.windows.net;Initial Catalog=database;Integrated Security=False;User ID="+Properties.Resources.Cont.ToString()+";Password="+Properties.Resources.Parola.ToString()+";Connect Timeout=15;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        
        // -------------------- FUNCTIE RESET TEXT BOX  --------------------------------------------------------------------------------------------------

        private  void resetbox()
        {
            textBox1.ResetText();
            textBox2.ResetText();
            textBox3.ResetText();
            textBox4.ResetText();
            textBox5.ResetText();
        }

        public Form1()
        {
            InitializeComponent();    
        }
       
        //-----------------------  ADAUGA PACIENT   ----------------------------------------------------------------------------

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                progressBar1.PerformStep();
                if (NetworkInterface.GetIsNetworkAvailable() == false)
                {
                    MessageBox.Show("Lipsa internet !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar1.Value = 0;
                }
                else
                {
                    progressBar1.PerformStep();
                    conect.Open();
                    SqlCommand comanda = conect.CreateCommand();
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "insert into dbo.pacienti values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                    progressBar1.PerformStep();
                    try
                    {
                        comanda.ExecuteNonQuery();
                        progressBar1.PerformStep();
                        MessageBox.Show("Inserat cu succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetbox();
                    }
                    catch
                    {
                        MessageBox.Show("Date introduse gresit !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        progressBar1.Value = 0;
                    }
                    conect.Close();
                }
                progressBar1.Value = 0;
            }
            else
            {
                MessageBox.Show("Date introduse gresit !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //----------------------- INCHIDE   -----------------------------------------------------------------------------------------------------

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        //------------------- AFISARE DATE  ----------------------------------------------------------------------------------------------------

        private void button2_Click(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
            progressBar1.PerformStep();
            Form2 forma2 = new Form2();
            progressBar1.PerformStep();
            forma2.Show();
            progressBar1.Value = 0;
        }

        //---------------------- STERGE PACIENT --------------------------------------------------------------------------------------------------

        private void button4_Click(object sender, EventArgs e)
        {
            if(textBox1.Text!="" && textBox2.Text!="")
            {
                progressBar1.PerformStep();
                if (NetworkInterface.GetIsNetworkAvailable() == false)
                {
                    MessageBox.Show("Lipsa internet !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    progressBar1.Value = 0;
                }
                else
                {
                    progressBar1.PerformStep();
                    conect.Open();
                    SqlCommand comanda = conect.CreateCommand();
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "delete from dbo.pacienti where nume='" + textBox1.Text + "' AND prenume='" + textBox2.Text + "'";
                    progressBar1.PerformStep();
                    try
                    {
                        comanda.ExecuteNonQuery();
                        progressBar1.PerformStep();
                        MessageBox.Show("Sters cu succes !", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        resetbox();
                    }
                    catch
                    {
                        MessageBox.Show("Eroare !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        progressBar1.Value = 0;
                    }
                    conect.Close();
                }
                progressBar1.Value=0;
            }
            else
            {
                MessageBox.Show("Eroare Nume Pacient !", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //---------------------- DESPRE (informatii)    --------------------------------------------------------------------------------------------------

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Inserare : Numele, Prenumele, Pulsul si Tensiunea pacientului trebuiesc introduse !"+Environment.NewLine+"Afisare Date : Se va afisa o fereastra ce contine toate datele stocate"+Environment.NewLine+"Stergere pacient : Se va sterge pacientul cu Numele si Prenumele introduse !","Despre",MessageBoxButtons.OK);
        }

       //----------------------  FORM LOAD    --------------------------------------------------------------------------------------------------------

        private void Form1_Load(object sender, EventArgs e)
        {
            progressBar1.Maximum = 100;
            progressBar1.Minimum = 0;
            progressBar1.Step = 30;
        }

    }
}
