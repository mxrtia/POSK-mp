using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mikroprocesor
{
    public partial class Form1 : Form
    {

        static private bool czyDalej = true;
        static private string[] rozkaz = new string[4];
        static private byte[] rejDoc = new byte[4];
        static private byte[] rejZr = new byte[4];
        static private bool[][] stala = new bool[4][];
        static private bool[] staleCheck = new bool[4];
        private static byte iloscRozkazow = 0;
        private static byte indeksRozkazu = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void register1_TextChanged(object sender, EventArgs e)
        {
            //register1.Text = Procesor.rejestrJakoTekst(Procesor.AH);
        }

        private void register1b_TextChanged(object sender, EventArgs e)
        {
            //register1b.Text = Procesor.rejestrJakoTekst(Procesor.AL);
        }
        private void register2_TextChanged(object sender, EventArgs e)
        {
            //register2.Text = Procesor.rejestrJakoTekst(Procesor.BH);
        }
        private void register2b_TextChanged(object sender, EventArgs e)
        {
            //register2b.Text = Procesor.rejestrJakoTekst(Procesor.BL);
        }

        private void register3_TextChanged(object sender, EventArgs e)
        {
            //register3.Text = Procesor.rejestrJakoTekst(Procesor.CH);
        }

        private void register3b_TextChanged(object sender, EventArgs e)
        {
            //register3b.Text = Procesor.rejestrJakoTekst(Procesor.CL);
        }

        private void register4_TextChanged(object sender, EventArgs e)
        {
            //register4.Text = Procesor.rejestrJakoTekst(Procesor.DH);
        }

        private void register4b_TextChanged(object sender, EventArgs e)
        {
            //register4b.Text = Procesor.rejestrJakoTekst(Procesor.DL);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            register1.Text = Procesor.rejestrJakoTekst(Procesor.AH);
            register1b.Text = Procesor.rejestrJakoTekst(Procesor.AL);
            register2.Text = Procesor.rejestrJakoTekst(Procesor.BH);
            register2b.Text = Procesor.rejestrJakoTekst(Procesor.BL);
            register3.Text = Procesor.rejestrJakoTekst(Procesor.CH);
            register3b.Text = Procesor.rejestrJakoTekst(Procesor.CL);
            register4.Text = Procesor.rejestrJakoTekst(Procesor.DH);
            register4b.Text = Procesor.rejestrJakoTekst(Procesor.DL);
            

        }

        private void Funkcja_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Funkcja.SelectedItem.ToString())
                {
                    case "MOV":
                        comboBox2.Enabled = true;

                        if (checkBox1.Checked)
                        {
                            comboBox3.Enabled = false;
                            textBox1.Enabled = true;

                        }
                        else
                        {
                            comboBox3.Enabled = true;
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "0000000000000000";
                        checkBox1.Enabled = true;
                        checkBox1.Checked = false;

                        break;

                    case "ADD":
                        comboBox2.Enabled = false;

                        if (checkBox1.Checked)
                        {
                            comboBox3.Enabled = false;
                            textBox1.Enabled = true;

                        }
                        else
                        {
                            comboBox3.Enabled = true;
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "0000000000000000";
                        checkBox1.Enabled = true;
                        checkBox1.Checked = false;

                        break;
                    
                    case "SUB":
                        comboBox2.Enabled = false;

                        if (checkBox1.Checked)
                        {
                            comboBox3.Enabled = false;
                            textBox1.Enabled = true;

                        }
                        else
                        {
                            comboBox3.Enabled = true;
                            textBox1.Enabled = false;
                        }
                        textBox1.Text = "0000000000000000";
                        checkBox1.Enabled = true;
                        checkBox1.Checked = false;
                        break;

                    default:
                        break;
                }


            }
            catch (NullReferenceException)
            {

            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox3.Enabled)
            {
                comboBox3.Enabled = false;
                //rejestrZrListBox1.ClearSelected();
                textBox1.Enabled = true;

            }
            else
            {
                comboBox3.Enabled = true;
                //rejestrZrListBox1.SelectedIndex = 0;
                textBox1.Text = "00000000";
                textBox1.Enabled = false;
            }
        }

        public void ZerowanieRejestrow_Click(object sender, EventArgs e)
        {
            register1.Text = Procesor.zerujUstawienia(Procesor.AH);
            register1b.Text = Procesor.zerujUstawienia(Procesor.AL);
            register2.Text = Procesor.zerujUstawienia(Procesor.BH);
            register2b.Text = Procesor.zerujUstawienia(Procesor.BL);
            register3.Text = Procesor.zerujUstawienia(Procesor.CH);
            register3b.Text = Procesor.zerujUstawienia(Procesor.CL);
            register4.Text = Procesor.zerujUstawienia(Procesor.DH);
            register4b.Text = Procesor.zerujUstawienia(Procesor.DL);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Funkcja1.Visible = true;
            comboBox4.Visible = true;
            comboBox5.Visible = true;
            textBox2.Visible = true;
            label7.Visible = true;
            label6.Visible = true;
            label5.Visible = true;
            label4.Visible = true;
            checkBox2.Visible = true;
            button2.Visible = true;
            radioButton5.Visible = true;
            radioButton6.Visible = true;
            //radioButton3.Visible = true;
            //radioButton4.Visible = true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Funkcja2.Visible = true;
            comboBox6.Visible = true;
            comboBox7.Visible = true;
            textBox3.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
            label11.Visible = true;
            checkBox3.Visible = true;
            button3.Visible = true;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Funkcja3.Visible = true;
            comboBox8.Visible = true;
            comboBox9.Visible = true;
            textBox4.Visible = true;
            label12.Visible = true;
            label13.Visible = true;
            label14.Visible = true;
            label15.Visible = true;
            checkBox4.Visible = true;
            button4.Visible = true;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Funkcja4.Visible = true;
            comboBox10.Visible = true;
            comboBox11.Visible = true;
            textBox5.Visible = true;
            label16.Visible = true;
            label17.Visible = true;
            label18.Visible = true;
            label19.Visible = true;
            checkBox5.Visible = true;
        }

        private void Rozpocznij_Click(object sender, EventArgs e)
        {

        }
    }
}
