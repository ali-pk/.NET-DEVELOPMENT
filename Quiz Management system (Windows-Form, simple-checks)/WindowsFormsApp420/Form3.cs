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

namespace WindowsFormsApp420
{
    public partial class Form3 : Form
    {
        private int counter;
        public int no=1;
        public SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ok\Documents\databaseez.mdf;Integrated Security=True;Connect Timeout=30");
        public Form3()
        {
            InitializeComponent();
            Connection();
            int n = qn(no);
            timer.Start();
        }
        public SqlConnection Connection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            return con;
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label4.Text = Form1.username;
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            counter++;
            lab.Text = counter.ToString();
            if (counter == 120)
            {
                lab.Text = "0";
                timer.Stop();
                MessageBox.Show("Time is up, Answer fast next time.You Scored: " + label3.Text);
                this.Close();
                Form1 F1 = new Form1();
                F1.ShowDialog();
            }
        }
        public int marks;
        public int markz;
        int sst(int markz)
        {
            String qry0 = "update info SET score = '" + markz + "' where username = '" + label4.Text + "'";
            SqlCommand cmd0 = new SqlCommand(qry0, con);
            Connection();
            int st = cmd0.ExecuteNonQuery();
            return st;
        }
        int mrk(int marks)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("SELECT score from info where username='" + label4.Text + "'", con);
            SqlDataReader s = cmd.ExecuteReader();
            while (s.Read())
            {
                marks = Convert.ToInt32(s.GetValue(0).ToString());
                markz = marks;
            }
            return markz;
        }
        int qn(int no)
        {
            Connection();
            SqlCommand cmd = new SqlCommand("SELECT questions from QnA where Num = '" + no + "'", con);
            SqlDataReader s = cmd.ExecuteReader();
            while (s.Read())
            {
                label00.Text = s.GetValue(0).ToString();
            }
            Connection();
            SqlCommand cmd1 = new SqlCommand("SELECT a,b,c,d FROM QnA where questions='" + label00.Text + "'", con);
            SqlDataReader s1 = cmd1.ExecuteReader();
            while (s1.Read())
            {
                radioButton1.Text = s1.GetValue(0).ToString();
                radioButton2.Text = s1.GetValue(1).ToString();
                radioButton3.Text = s1.GetValue(2).ToString();
                radioButton4.Text = s1.GetValue(3).ToString();
            }
            return no;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int markz = mrk(marks);
            Connection();
            SqlCommand cmd11 = new SqlCommand("SELECT answer from QnA where questions='" + label00.Text + "'", con);
            SqlDataReader s2 = cmd11.ExecuteReader();
            if (s2.Read())
            //while (s2.Read())  //Connection issues, solved with if
            {
                if (radioButton1.Checked == true)
                {
                    if (radioButton1.Text == s2.GetValue(0).ToString())
                    {
                        if (no == 6)
                        {
                            no += 1;
                            markz += 1;
                            label3.Text = markz.ToString();
                            int st = sst(markz);
                            MessageBox.Show("Right Answer! You Scored: "+label3.Text);
                            radioButton1.Checked = false;
                            timer.Stop();
                            Form1 F1 = new Form1();
                            F1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            no += 1;
                            markz += 1;
                            label3.Text = markz.ToString();
                            int st = sst(markz);
                            MessageBox.Show("Right Answer!");
                            int n = qn(no);
                            radioButton1.Checked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrond Answer! Choose Again.");
                    }
                }
                else if (radioButton2.Checked == true)
                {
                    if (radioButton2.Text == s2.GetValue(0).ToString())
                    {
                        if (no == 6)
                        {
                            no += 1;
                            markz += 1;
                            label3.Text = markz.ToString();
                            int st = sst(markz);
                            MessageBox.Show("Right Answer! You Scored: " + label3.Text);
                            radioButton2.Checked = false;
                            timer.Stop();
                            Form1 F1 = new Form1();
                            F1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            no += 1;
                            markz += 1;
                            label3.Text = markz.ToString();
                            int st = sst(markz);
                            MessageBox.Show("Right Answer!");
                            int n = qn(no);
                            radioButton2.Checked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrond Answer! Choose Again.");
                    }
                }
                else if (radioButton3.Checked == true)
                {
                    if (radioButton3.Text == s2.GetValue(0).ToString())
                    {
                        if (no == 6)
                        {
                            no += 1;
                            markz += 1;
                            label3.Text = markz.ToString();
                            int st = sst(markz);
                            MessageBox.Show("Right Answer! You Scored: " + label3.Text);
                            radioButton3.Checked = false;
                            timer.Stop();
                            Form1 F1 = new Form1();
                            F1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            no += 1;
                            markz += 1;
                            label3.Text = markz.ToString();
                            int st = sst(markz);
                            MessageBox.Show("Right Answer!");
                            int n = qn(no);
                            radioButton3.Checked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrond Answer! Choose Again.");
                    }
                }
                else if (radioButton4.Checked == true)
                {
                    if (radioButton4.Text == s2.GetValue(0).ToString())
                    {
                        if (no == 6)
                        {
                            no += 1;
                            markz += 1;
                            label3.Text = markz.ToString();
                            int st = sst(markz);
                            MessageBox.Show("Right Answer! You Scored: " + label3.Text);
                            radioButton4.Checked = false;
                            timer.Stop();
                            Form1 F1 = new Form1();
                            F1.ShowDialog();
                            this.Close();
                        }
                        else
                        {
                            no += 1;
                            markz += 1;
                            label3.Text = markz.ToString();
                            int st = sst(markz);
                            MessageBox.Show("Right Answer!");
                            int n = qn(no);
                            radioButton4.Checked = false;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Wrond Answer! Choose Again.");
                    }
                }
            }
        }
    }
}
