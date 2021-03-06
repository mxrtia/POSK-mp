﻿using System;
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

        static private string[] rozkaz = new string[5];
        static private byte[] rejDoc = new byte[5];
        static private byte[] rejZr = new byte[5];
        static private bool[][] stala = new bool[5][];
        static private bool[] staleCheck = new bool[5];
        private static byte iloscRozkazow = 0;
        private static byte indeksRozkazu = 0;

        public Form1()
        {
            InitializeComponent();
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

        //COMBOBOXY WYBORU FUNKCJI
        private void Funkcja_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Funkcja.SelectedItem.ToString())
                {
                    case "MOV":
                        comboBox2.Enabled = true;
                        comboBox2.SelectedIndex = 0;

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

        private void Funkcja1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Funkcja1.SelectedItem.ToString())
                {
                    case "MOV":
                        comboBox4.Enabled = true;

                        if (checkBox2.Checked)
                        {
                            comboBox5.Enabled = false;
                            textBox2.Enabled = true;

                        }
                        else
                        {
                            comboBox5.Enabled = true;
                            textBox2.Enabled = false;
                        }
                        textBox2.Text = "0000000000000000";
                        checkBox2.Enabled = true;
                        checkBox2.Checked = false;

                        break;

                    case "ADD":
                        comboBox4.Enabled = false;

                        if (checkBox2.Checked)
                        {
                            comboBox5.Enabled = false;
                            textBox2.Enabled = true;

                        }
                        else
                        {
                            comboBox5.Enabled = true;
                            textBox2.Enabled = false;
                        }
                        textBox2.Text = "0000000000000000";
                        checkBox2.Enabled = true;
                        checkBox2.Checked = false;

                        break;

                    case "SUB":
                        comboBox4.Enabled = false;

                        if (checkBox2.Checked)
                        {
                            comboBox5.Enabled = false;
                            textBox2.Enabled = true;

                        }
                        else
                        {
                            comboBox5.Enabled = true;
                            textBox2.Enabled = false;
                        }
                        textBox2.Text = "0000000000000000";
                        checkBox2.Enabled = true;
                        checkBox2.Checked = false;
                        break;

                    default:
                        break;
                }                
            }
            catch (NullReferenceException)
            {

            }
        }

        private void Funkcja2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Funkcja2.SelectedItem.ToString())
                {
                    case "MOV":
                        comboBox6.Enabled = true;

                        if (checkBox3.Checked)
                        {
                            comboBox7.Enabled = false;
                            textBox3.Enabled = true;

                        }
                        else
                        {
                            comboBox7.Enabled = true;
                            textBox3.Enabled = false;
                        }
                        textBox3.Text = "0000000000000000";
                        checkBox3.Enabled = true;
                        checkBox3.Checked = false;

                        break;

                    case "ADD":
                        comboBox6.Enabled = false;

                        if (checkBox3.Checked)
                        {
                            comboBox7.Enabled = false;
                            textBox3.Enabled = true;

                        }
                        else
                        {
                            comboBox7.Enabled = true;
                            textBox3.Enabled = false;
                        }
                        textBox3.Text = "0000000000000000";
                        checkBox3.Enabled = true;
                        checkBox3.Checked = false;

                        break;

                    case "SUB":
                        comboBox6.Enabled = false;

                        if (checkBox3.Checked)
                        {
                            comboBox7.Enabled = false;
                            textBox3.Enabled = true;

                        }
                        else
                        {
                            comboBox7.Enabled = true;
                            textBox3.Enabled = false;
                        }
                        textBox3.Text = "0000000000000000";
                        checkBox3.Enabled = true;
                        checkBox3.Checked = false;
                        break;

                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        private void Funkcja3_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Funkcja3.SelectedItem.ToString())
                {
                    case "MOV":
                        comboBox8.Enabled = true;

                        if (checkBox4.Checked)
                        {
                            comboBox9.Enabled = false;
                            textBox4.Enabled = true;

                        }
                        else
                        {
                            comboBox9.Enabled = true;
                            textBox4.Enabled = false;
                        }
                        textBox4.Text = "0000000000000000";
                        checkBox4.Enabled = true;
                        checkBox4.Checked = false;

                        break;

                    case "ADD":
                        comboBox8.Enabled = false;

                        if (checkBox4.Checked)
                        {
                            comboBox9.Enabled = false;
                            textBox4.Enabled = true;

                        }
                        else
                        {
                            comboBox9.Enabled = true;
                            textBox4.Enabled = false;
                        }
                        textBox4.Text = "0000000000000000";
                        checkBox4.Enabled = true;
                        checkBox4.Checked = false;

                        break;

                    case "SUB":
                        comboBox8.Enabled = false;

                        if (checkBox4.Checked)
                        {
                            comboBox9.Enabled = false;
                            textBox4.Enabled = true;

                        }
                        else
                        {
                            comboBox9.Enabled = true;
                            textBox4.Enabled = false;
                        }
                        textBox4.Text = "0000000000000000";
                        checkBox4.Enabled = true;
                        checkBox4.Checked = false;
                        break;

                    default:
                        break;
                }


            }
            catch (NullReferenceException)
            {

            }
        }

        private void Funkcja4_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (Funkcja4.SelectedItem.ToString())
                {
                    case "MOV":
                        comboBox10.Enabled = true;

                        if (checkBox5.Checked)
                        {
                            comboBox11.Enabled = false;
                            textBox5.Enabled = true;

                        }
                        else
                        {
                            comboBox11.Enabled = true;
                            textBox5.Enabled = false;
                        }
                        textBox5.Text = "0000000000000000";
                        checkBox5.Enabled = true;
                        checkBox5.Checked = false;

                        break;

                    case "ADD":
                        comboBox10.Enabled = false;

                        if (checkBox5.Checked)
                        {
                            comboBox11.Enabled = false;
                            textBox5.Enabled = true;

                        }
                        else
                        {
                            comboBox11.Enabled = true;
                            textBox5.Enabled = false;
                        }
                        textBox5.Text = "0000000000000000";
                        checkBox5.Enabled = true;
                        checkBox5.Checked = false;

                        break;

                    case "SUB":
                        comboBox10.Enabled = false;

                        if (checkBox5.Checked)
                        {
                            comboBox11.Enabled = false;
                            textBox5.Enabled = true;

                        }
                        else
                        {
                            comboBox11.Enabled = true;
                            textBox5.Enabled = false;
                        }
                        textBox5.Text = "0000000000000000";
                        checkBox5.Enabled = true;
                        checkBox5.Checked = false;
                        break;

                    default:
                        break;
                }
            }
            catch (NullReferenceException)
            {

            }
        }

        //CHECKBOXY DLA STAŁEJ
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
                textBox1.Text = "0000000000000000";
                textBox1.Enabled = false;
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox5.Enabled)
            {
                comboBox5.Enabled = false;
                //rejestrZrListBox1.ClearSelected();
                textBox2.Enabled = true;

            }
            else
            {
                comboBox5.Enabled = true;
                //rejestrZrListBox1.SelectedIndex = 0;
                textBox2.Text = "0000000000000000";
                textBox2.Enabled = false;
            }
        }

        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox7.Enabled)
            {
                comboBox7.Enabled = false;
                //rejestrZrListBox1.ClearSelected();
                textBox3.Enabled = true;

            }
            else
            {
                comboBox7.Enabled = true;
                //rejestrZrListBox1.SelectedIndex = 0;
                textBox3.Text = "0000000000000000";
                textBox3.Enabled = false;
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox9.Enabled)
            {
                comboBox9.Enabled = false;
                //rejestrZrListBox1.ClearSelected();
                textBox4.Enabled = true;

            }
            else
            {
                comboBox9.Enabled = true;
                //rejestrZrListBox1.SelectedIndex = 0;
                textBox4.Text = "0000000000000000";
                textBox4.Enabled = false;
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBox11.Enabled)
            {
                comboBox11.Enabled = false;
                //rejestrZrListBox1.ClearSelected();
                textBox5.Enabled = true;

            }
            else
            {
                comboBox11.Enabled = true;
                //rejestrZrListBox1.SelectedIndex = 0;
                textBox5.Text = "0000000000000000";
                textBox5.Enabled = false;
            }
        }
        
        //KONIEC CHECKBOXÓW DLA STAŁEJ

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

      

        private void Rozpocznij_Click(object sender, EventArgs e)
        {

            if (Procesor.TF) Next.Enabled = true;
            else Next.Enabled = false;

            indeksRozkazu = 0;
            iloscRozkazow = 0;

            for (int i = 0; i < 4; i++)
            {
                rozkaz[i] = "";
                rejDoc[i] = 0;
                rejZr[i] = 0;
                stala[i] = new bool[8];

            }

            //PIERWSZY PRZYPADEK
            if (rbIns.Checked == true)
            {
                if (Funkcja.SelectedItem != null && textBox1.Text.Length == 0)
                    MessageBox.Show("Dodaj stałą w Rozkazie 1!");
                else
                {
                    iloscRozkazow++;
                    if (Funkcja.SelectedItem != null)
                        rozkaz[0] = Funkcja.SelectedItem.ToString();

                    if (Funkcja.SelectedItem != null && Funkcja.SelectedItem.ToString().Equals("MOV"))
                    {
                        if (comboBox2.SelectedItem.ToString().Equals("AX"))
                        {
                            rejDoc[0] = Procesor.AH;
                        }
                        if (comboBox2.SelectedItem.ToString().Equals("BX"))
                        {
                            rejDoc[0] = Procesor.BH;
                        }
                        if (comboBox2.SelectedItem.ToString().Equals("CX"))
                        {
                            rejDoc[0] = Procesor.CH;
                        }
                        if (comboBox2.SelectedItem.ToString().Equals("DX"))
                        {
                            rejDoc[0] = Procesor.DH;
                        }
                    }

                    try
                    {
                        if (Funkcja.SelectedItem != null && !checkBox1.Checked)
                        {

                            if (comboBox3.SelectedItem.ToString().Equals("AX"))
                            {
                                rejZr[0] = Procesor.AH;
                            }
                            if (comboBox3.SelectedItem.ToString().Equals("BX"))
                            {
                                rejZr[0] = Procesor.BH;
                            }
                            if (comboBox3.SelectedItem.ToString().Equals("CX"))
                            {
                                rejZr[0] = Procesor.CH;
                            }
                            if (comboBox3.SelectedItem.ToString().Equals("DX"))
                            {
                                rejZr[0] = Procesor.DH;
                            }
                        }
                        else
                        {
                            stala[0] = TextControllClass.TextToNumber(textBox1.Text);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wybierz argument dla rozkazu 1.", "Błąd");
                    }
                }
            }
            if (rbReg.Checked == true)
            {
                iloscRozkazow++;
                if (Funkcja.SelectedItem != null)
                    rozkaz[0] = Funkcja.SelectedItem.ToString();

                if (Funkcja.SelectedItem != null && Funkcja.SelectedItem.ToString().Equals("MOV"))
                {
                    if (comboBox2.SelectedItem.ToString().Equals("AX"))
                    {
                        rejDoc[0] = Procesor.AH;
                    }
                    if (comboBox2.SelectedItem.ToString().Equals("BX"))
                    {
                        rejDoc[0] = Procesor.BH;
                    }
                    if (comboBox2.SelectedItem.ToString().Equals("CX"))
                    {
                        rejDoc[0] = Procesor.CH;
                    }
                    if (comboBox2.SelectedItem.ToString().Equals("DX"))
                    {
                        rejDoc[0] = Procesor.DH;
                    }
                }

                try
                {
                    if (Funkcja.SelectedItem != null && !checkBox1.Checked)
                    {

                        if (comboBox3.SelectedItem.ToString().Equals("AX"))
                        {
                            rejZr[0] = Procesor.AH;
                        }
                        if (comboBox3.SelectedItem.ToString().Equals("BX"))
                        {
                            rejZr[0] = Procesor.BH;
                        }
                        if (comboBox3.SelectedItem.ToString().Equals("CX"))
                        {
                            rejZr[0] = Procesor.CH;
                        }
                        if (comboBox3.SelectedItem.ToString().Equals("DX"))
                        {
                            rejZr[0] = Procesor.DH;
                        }
                    }
                    else
                    {
                        stala[0] = TextControllClass.TextToNumber(textBox1.Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wybierz argument dla rozkazu 1.", "Błąd");
                }
            }

            //DRUGI PRZYPADEK

            if (rbIns.Checked == true)
            {
                if (Funkcja1.SelectedItem != null && textBox2.Text.Length == 0)
                    MessageBox.Show("Dodaj stałą w Rozkazie 2!");
                else
                {
                    iloscRozkazow++;
                    if (Funkcja1.SelectedItem != null)
                        rozkaz[1] = Funkcja1.SelectedItem.ToString();

                    if (Funkcja1.SelectedItem != null && Funkcja1.SelectedItem.ToString().Equals("MOV"))
                    {
                        if (comboBox4.SelectedItem.ToString().Equals("AX"))
                        {
                            rejDoc[1] = Procesor.AH;
                        }
                        if (comboBox4.SelectedItem.ToString().Equals("BX"))
                        {
                            rejDoc[1] = Procesor.BH;
                        }
                        if (comboBox4.SelectedItem.ToString().Equals("CX"))
                        {
                            rejDoc[1] = Procesor.CH;
                        }
                        if (comboBox4.SelectedItem.ToString().Equals("DX"))
                        {
                            rejDoc[1] = Procesor.DH;
                        }
                    }

                    try
                    {
                        if (Funkcja1.SelectedItem != null && !checkBox2.Checked)
                        {

                            if (comboBox5.SelectedItem.ToString().Equals("AX"))
                            {
                                rejZr[1] = Procesor.AH;
                            }
                            if (comboBox5.SelectedItem.ToString().Equals("BX"))
                            {
                                rejZr[1] = Procesor.BH;
                            }
                            if (comboBox5.SelectedItem.ToString().Equals("CX"))
                            {
                                rejZr[1] = Procesor.CH;
                            }
                            if (comboBox5.SelectedItem.ToString().Equals("DX"))
                            {
                                rejZr[1] = Procesor.DH;
                            }
                        }
                        else
                        {
                            stala[1] = TextControllClass.TextToNumber(textBox2.Text);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wybierz argument dla rozkazu 2.", "Błąd");
                    }
                }
            }
            if (rbReg.Checked == true)
            {
                iloscRozkazow++;
                if (Funkcja1.SelectedItem != null)
                    rozkaz[1] = Funkcja1.SelectedItem.ToString();

                if (Funkcja1.SelectedItem != null && Funkcja1.SelectedItem.ToString().Equals("MOV"))
                {
                    if (comboBox4.SelectedItem.ToString().Equals("AX"))
                    {
                        rejDoc[1] = Procesor.AH;
                    }
                    if (comboBox4.SelectedItem.ToString().Equals("BX"))
                    {
                        rejDoc[1] = Procesor.BH;
                    }
                    if (comboBox4.SelectedItem.ToString().Equals("CX"))
                    {
                        rejDoc[1] = Procesor.CH;
                    }
                    if (comboBox4.SelectedItem.ToString().Equals("DX"))
                    {
                        rejDoc[1] = Procesor.DH;
                    }
                }

                try
                {
                    if (Funkcja1.SelectedItem != null && !checkBox2.Checked)
                    {

                        if (comboBox5.SelectedItem.ToString().Equals("AX"))
                        {
                            rejZr[1] = Procesor.AH;
                        }
                        if (comboBox5.SelectedItem.ToString().Equals("BX"))
                        {
                            rejZr[1] = Procesor.BH;
                        }
                        if (comboBox5.SelectedItem.ToString().Equals("CX"))
                        {
                            rejZr[1] = Procesor.CH;
                        }
                        if (comboBox5.SelectedItem.ToString().Equals("DX"))
                        {
                            rejZr[1] = Procesor.DH;
                        }
                    }
                    else
                    {
                        stala[1] = TextControllClass.TextToNumber(textBox2.Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wybierz argument dla rozkazu 2.", "Błąd");
                }
            }


            //TRZECI PRZYPADEK

            if (rbIns.Checked == true)
            {
                if (Funkcja2.SelectedItem != null && textBox3.Text.Length == 0)
                    MessageBox.Show("Dodaj stałą w Rozkazie 3!");
                else
                {
                    iloscRozkazow++;
                    if (Funkcja2.SelectedItem != null)
                        rozkaz[2] = Funkcja2.SelectedItem.ToString();

                    if (Funkcja2.SelectedItem != null && Funkcja2.SelectedItem.ToString().Equals("MOV"))
                    {
                        if (comboBox6.SelectedItem.ToString().Equals("AX"))
                        {
                            rejDoc[2] = Procesor.AH;
                        }
                        if (comboBox6.SelectedItem.ToString().Equals("BX"))
                        {
                            rejDoc[2] = Procesor.BH;
                        }
                        if (comboBox6.SelectedItem.ToString().Equals("CX"))
                        {
                            rejDoc[2] = Procesor.CH;
                        }
                        if (comboBox6.SelectedItem.ToString().Equals("DX"))
                        {
                            rejDoc[2] = Procesor.DH;
                        }
                    }

                    try
                    {
                        if (Funkcja2.SelectedItem != null && !checkBox3.Checked)
                        {

                            if (comboBox7.SelectedItem.ToString().Equals("AX"))
                            {
                                rejZr[2] = Procesor.AH;
                            }
                            if (comboBox7.SelectedItem.ToString().Equals("BX"))
                            {
                                rejZr[2] = Procesor.BH;
                            }
                            if (comboBox7.SelectedItem.ToString().Equals("CX"))
                            {
                                rejZr[2] = Procesor.CH;
                            }
                            if (comboBox7.SelectedItem.ToString().Equals("DX"))
                            {
                                rejZr[2] = Procesor.DH;
                            }
                        }
                        else
                        {
                            stala[2] = TextControllClass.TextToNumber(textBox3.Text);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wybierz argument dla rozkazu 3.", "Błąd");
                    }
                }
            }
            if (rbReg.Checked == true)
            {
                iloscRozkazow++;
                if (Funkcja2.SelectedItem != null && Funkcja2.SelectedItem != null)
                    rozkaz[2] = Funkcja2.SelectedItem.ToString();

                if (Funkcja2.SelectedItem != null && Funkcja2.SelectedItem.ToString().Equals("MOV"))
                {
                    if (comboBox6.SelectedItem.ToString().Equals("AX"))
                    {
                        rejDoc[2] = Procesor.AH;
                    }
                    if (comboBox6.SelectedItem.ToString().Equals("BX"))
                    {
                        rejDoc[2] = Procesor.BH;
                    }
                    if (comboBox6.SelectedItem.ToString().Equals("CX"))
                    {
                        rejDoc[2] = Procesor.CH;
                    }
                    if (comboBox6.SelectedItem.ToString().Equals("DX"))
                    {
                        rejDoc[2] = Procesor.DH;
                    }
                }

                try
                {
                    if (Funkcja2.SelectedItem != null && !checkBox3.Checked)
                    {

                        if (comboBox7.SelectedItem.ToString().Equals("AX"))
                        {
                            rejZr[2] = Procesor.AH;
                        }
                        if (comboBox7.SelectedItem.ToString().Equals("BX"))
                        {
                            rejZr[2] = Procesor.BH;
                        }
                        if (comboBox7.SelectedItem.ToString().Equals("CX"))
                        {
                            rejZr[2] = Procesor.CH;
                        }
                        if (comboBox7.SelectedItem.ToString().Equals("DX"))
                        {
                            rejZr[2] = Procesor.DH;
                        }
                    }
                    else
                    {
                        stala[2] = TextControllClass.TextToNumber(textBox3.Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wybierz argument dla rozkazu 3.", "Błąd");
                }
            }


            //CZWARTY PRZYPADEK

            if (rbIns.Checked == true)
            {
                if (Funkcja3.SelectedItem != null && textBox4.Text.Length == 0)
                    MessageBox.Show("Dodaj stałą w Rozkazie 4!");
                else
                {
                    iloscRozkazow++;
                    if (Funkcja3.SelectedItem != null)
                        rozkaz[3] = Funkcja3.SelectedItem.ToString();

                    if (Funkcja3.SelectedItem != null && Funkcja3.SelectedItem.ToString().Equals("MOV"))
                    {
                        if (comboBox8.SelectedItem.ToString().Equals("AX"))
                        {
                            rejDoc[3] = Procesor.AH;
                        }
                        if (comboBox8.SelectedItem.ToString().Equals("BX"))
                        {
                            rejDoc[3] = Procesor.BH;
                        }
                        if (comboBox8.SelectedItem.ToString().Equals("CX"))
                        {
                            rejDoc[3] = Procesor.CH;
                        }
                        if (comboBox8.SelectedItem.ToString().Equals("DX"))
                        {
                            rejDoc[3] = Procesor.DH;
                        }
                    }

                    try
                    {
                        if (Funkcja3.SelectedItem != null && !checkBox4.Checked)
                        {

                            if (comboBox9.SelectedItem.ToString().Equals("AX"))
                            {
                                rejZr[3] = Procesor.AH;
                            }
                            if (comboBox9.SelectedItem.ToString().Equals("BX"))
                            {
                                rejZr[3] = Procesor.BH;
                            }
                            if (comboBox9.SelectedItem.ToString().Equals("CX"))
                            {
                                rejZr[3] = Procesor.CH;
                            }
                            if (comboBox9.SelectedItem.ToString().Equals("DX"))
                            {
                                rejZr[3] = Procesor.DH;
                            }
                        }
                        else
                        {
                            stala[3] = TextControllClass.TextToNumber(textBox4.Text);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wybierz argument dla rozkazu 4.", "Błąd");
                    }
                }
            }
            if (rbReg.Checked == true)
            {
                iloscRozkazow++;
                if (Funkcja3.SelectedItem != null)
                    rozkaz[3] = Funkcja3.SelectedItem.ToString();

                if (Funkcja3.SelectedItem != null && Funkcja3.SelectedItem.ToString().Equals("MOV"))
                {
                    if (comboBox8.SelectedItem.ToString().Equals("AX"))
                    {
                        rejDoc[3] = Procesor.AH;
                    }
                    if (comboBox8.SelectedItem.ToString().Equals("BX"))
                    {
                        rejDoc[3] = Procesor.BH;
                    }
                    if (comboBox8.SelectedItem.ToString().Equals("CX"))
                    {
                        rejDoc[3] = Procesor.CH;
                    }
                    if (comboBox8.SelectedItem.ToString().Equals("DX"))
                    {
                        rejDoc[3] = Procesor.DH;
                    }
                }

                try
                {
                    if (Funkcja3.SelectedItem != null && !checkBox4.Checked)
                    {

                        if (comboBox9.SelectedItem.ToString().Equals("AX"))
                        {
                            rejZr[3] = Procesor.AH;
                        }
                        if (comboBox9.SelectedItem.ToString().Equals("BX"))
                        {
                            rejZr[3] = Procesor.BH;
                        }
                        if (comboBox9.SelectedItem.ToString().Equals("CX"))
                        {
                            rejZr[3] = Procesor.CH;
                        }
                        if (comboBox9.SelectedItem.ToString().Equals("DX"))
                        {
                            rejZr[3] = Procesor.DH;
                        }
                    }
                    else
                    {
                        stala[3] = TextControllClass.TextToNumber(textBox4.Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wybierz argument dla rozkazu 4.", "Błąd");
                }
            }


            //PIĄTY PRZYPADEK

            if (rbIns.Checked == true)
            {
                if (Funkcja4.SelectedItem != null && textBox5.Text.Length == 0)
                    MessageBox.Show("Dodaj stałą w Rozkazie 5!");
                else
                {
                    iloscRozkazow++;
                    if (Funkcja4.SelectedItem != null)
                    {
                        rozkaz[4] = Funkcja4.SelectedItem.ToString();
                    }

                    if (Funkcja4.SelectedItem != null && Funkcja4.SelectedItem.ToString().Equals("MOV"))
                    {
                        if (comboBox10.SelectedItem.ToString().Equals("AX"))
                        {
                            rejDoc[4] = Procesor.AH;
                        }
                        if (comboBox10.SelectedItem.ToString().Equals("BX"))
                        {
                            rejDoc[4] = Procesor.BH;
                        }
                        if (comboBox10.SelectedItem.ToString().Equals("CX"))
                        {
                            rejDoc[4] = Procesor.CH;
                        }
                        if (comboBox10.SelectedItem.ToString().Equals("DX"))
                        {
                            rejDoc[4] = Procesor.DH;
                        }
                    }

                    try
                    {
                        if (Funkcja4.SelectedItem != null && !checkBox5.Checked)
                        {

                            if (comboBox11.SelectedItem.ToString().Equals("AX"))
                            {
                                rejZr[4] = Procesor.AH;
                            }
                            if (comboBox11.SelectedItem.ToString().Equals("BX"))
                            {
                                rejZr[4] = Procesor.BH;
                            }
                            if (comboBox11.SelectedItem.ToString().Equals("CX"))
                            {
                                rejZr[4] = Procesor.CH;
                            }
                            if (comboBox11.SelectedItem.ToString().Equals("DX"))
                            {
                                rejZr[4] = Procesor.DH;
                            }
                        }
                        else
                        {
                            stala[4] = TextControllClass.TextToNumber(textBox5.Text);
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Wybierz argument dla rozkazu 5.", "Błąd");
                    }
                }
            }
            if (rbReg.Checked == true)
            {
                iloscRozkazow++;
                if (Funkcja4.SelectedItem != null)
                {
                    rozkaz[4] = Funkcja4.SelectedItem.ToString();
                }

                if (Funkcja4.SelectedItem != null && Funkcja4.SelectedItem.ToString().Equals("MOV"))
                {
                    if (comboBox10.SelectedItem.ToString().Equals("AX"))
                    {
                        rejDoc[4] = Procesor.AH;
                    }
                    if (comboBox10.SelectedItem.ToString().Equals("BX"))
                    {
                        rejDoc[4] = Procesor.BH;
                    }
                    if (comboBox10.SelectedItem.ToString().Equals("CX"))
                    {
                        rejDoc[4] = Procesor.CH;
                    }
                    if (comboBox10.SelectedItem.ToString().Equals("DX"))
                    {
                        rejDoc[4] = Procesor.DH;
                    }
                }

                try
                {
                    if (Funkcja4.SelectedItem != null && !checkBox5.Checked)
                    {

                        if (comboBox11.SelectedItem.ToString().Equals("AX"))
                        {
                            rejZr[4] = Procesor.AH;
                        }
                        if (comboBox11.SelectedItem.ToString().Equals("BX"))
                        {
                            rejZr[4] = Procesor.BH;
                        }
                        if (comboBox11.SelectedItem.ToString().Equals("CX"))
                        {
                            rejZr[4] = Procesor.CH;
                        }
                        if (comboBox11.SelectedItem.ToString().Equals("DX"))
                        {
                            rejZr[4] = Procesor.DH;
                        }
                    }
                    else
                    {
                        stala[4] = TextControllClass.TextToNumber(textBox5.Text);
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Wybierz argument dla rozkazu 5.", "Błąd");
                }
            }


            staleCheck[0] = checkBox1.Checked;
            staleCheck[1] = checkBox2.Checked;
            staleCheck[2] = checkBox3.Checked;
            staleCheck[3] = checkBox4.Checked;
            staleCheck[4] = checkBox5.Checked;

            int ileRazy = 0;
            if (Procesor.TF) ileRazy = 1;
            else ileRazy = iloscRozkazow;

            for (int i = 0; i < ileRazy; i++)
            {
                switch (rozkaz[i])
                {
                    case "MOV":
                        if (!staleCheck[i]) Procesor.MOV(rejDoc[i], rejZr[i]);
                        else Procesor.MOV(rejDoc[i], stala[i]);
                        break;

                    case "ADD":
                        if (!staleCheck[i]) Procesor.ADD(rejZr[i]);
                        else Procesor.ADD(stala[i]);
                        break;

                    case "SUB":
                        if (!staleCheck[i]) Procesor.SUB(rejZr[i]);
                        else Procesor.SUB(stala[i]);
                        break;

                    default:
                        break;
                }
                switch (rejDoc[i])
                {
                    case Procesor.AH:
                        if (Procesor.jestOF()) of1.Text = "1";
                        else of1.Text = "0";
                        break;

                    case Procesor.BH:
                        if (Procesor.jestOF()) of2.Text = "1";
                        else of2.Text = "0";
                        break;

                    case Procesor.CH:
                        if (Procesor.jestOF()) of3.Text = "1";
                        else of3.Text = "0";
                        break;
                    case Procesor.DH:
                        if (Procesor.jestOF()) of4.Text = "1";
                        else of4.Text = "0";
                        break;

                    default:
                        break;
                }

                indeksRozkazu++;
            }


            register1.Text = Procesor.rejestrJakoTekst(Procesor.AH);
            register1b.Text = Procesor.rejestrJakoTekst(Procesor.AL);
            register2.Text = Procesor.rejestrJakoTekst(Procesor.BH);
            register2b.Text = Procesor.rejestrJakoTekst(Procesor.BL);
            register3.Text = Procesor.rejestrJakoTekst(Procesor.CH);
            register3b.Text = Procesor.rejestrJakoTekst(Procesor.CL);
            register4.Text = Procesor.rejestrJakoTekst(Procesor.DH);
            register4b.Text = Procesor.rejestrJakoTekst(Procesor.DL);

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procesor posiada cztery 16-bitowe rejestry: AX, BX, CX i DX." + "\n" + "\n" + "Użytkownik może wybrać z listy rozkaz, a następnie określić, czy ma on zostać wykonany dla danego argumentu, czy dla konkretnej stałej." + "\n" + "\n" + "Mikroprocesor może wykonać maksymalnie pięć rozkazów jednocześnie, przy czym użytkownik musi użyć minimalnie jednego rozkazu, aby mikroprocesor rozpoczął pracę prawidłowo." + "\n" + "\n" + "Użytkownik może wybrać, czy mikroprocesor ma pracować w trybie pracy krokowej lub całościowej (domyślnie jest to praca całościowa) oraz jaki ma być jego tryb adresowania (natychmiastowy lub rejestrowy).", "Instrukcja");
        }

        private void Next_Click(object sender, EventArgs e)
        {
            switch (rozkaz[indeksRozkazu])
            {
                case "MOV":
                    if (!staleCheck[indeksRozkazu]) Procesor.MOV(rejDoc[indeksRozkazu], rejZr[indeksRozkazu]);
                    else Procesor.MOV(rejDoc[indeksRozkazu], stala[indeksRozkazu]);
                    break;

                case "ADD":
                    if (!staleCheck[indeksRozkazu]) Procesor.ADD(rejZr[indeksRozkazu]);
                    else Procesor.ADD(stala[indeksRozkazu]);
                    break;

                case "SUB":
                    if (!staleCheck[indeksRozkazu]) Procesor.SUB(rejZr[indeksRozkazu]);
                    else Procesor.SUB(stala[indeksRozkazu]);
                    break;

                default:
                    break;
            }
            switch (rejDoc[indeksRozkazu])
            {
                case Procesor.AH:
                    if (Procesor.jestOF()) of1.Text = "1";
                    else of1.Text = "0";
                    break;

                case Procesor.BH:
                    if (Procesor.jestOF()) of2.Text = "1";
                    else of2.Text = "0";
                    break;

                case Procesor.CH:
                    if (Procesor.jestOF()) of3.Text = "1";
                    else of3.Text = "0";
                    break;
                case Procesor.DH:
                    if (Procesor.jestOF()) of4.Text = "1";
                    else of4.Text = "0";
                    break;

                default:
                    break;
            }
            indeksRozkazu++;
            if (indeksRozkazu >= iloscRozkazow)
            {
                indeksRozkazu = 0;
                iloscRozkazow = 0;
                radioButton6.Checked = false;
                Next.Enabled = false;
                //checkBoxRozkaz1.Enabled = true;
                //Next.Enabled = true;
            }

            register1.Text = Procesor.rejestrJakoTekst(Procesor.AH);
            register1b.Text = Procesor.rejestrJakoTekst(Procesor.AL);
            register2.Text = Procesor.rejestrJakoTekst(Procesor.BH);
            register2b.Text = Procesor.rejestrJakoTekst(Procesor.BL);
            register3.Text = Procesor.rejestrJakoTekst(Procesor.CH);
            register3b.Text = Procesor.rejestrJakoTekst(Procesor.CL);
            register4.Text = Procesor.rejestrJakoTekst(Procesor.DH);
            register4b.Text = Procesor.rejestrJakoTekst(Procesor.DL);
            textBox1.Text = "0000000000000000";
            textBox2.Text = "0000000000000000";
            textBox3.Text = "0000000000000000";
            textBox4.Text = "0000000000000000";
        }

        private void RadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (Procesor.TF)
            {
                Procesor.TF = false;

            }
            else
            {
                Procesor.TF = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (of1.Visible == false)
            {
                OF.Visible = true;
                of1.Visible = true;
                of2.Visible = true;
                of3.Visible = true;
                of4.Visible = true;
            }
            /*else
            {
                OF.Visible = false;
                of1.Visible = false;
                of2.Visible = false;
                of3.Visible = false;
                of4.Visible = false;
            }*/
            
        }

        private void RbReg_CheckedChanged(object sender, EventArgs e)
        {
            comboBox3.Enabled = true;
            comboBox5.Enabled = true;
            comboBox7.Enabled = true;
            comboBox9.Enabled = true;
            comboBox11.Enabled = true;
        }

        private void RbIns_CheckedChanged(object sender, EventArgs e)
        {
            
            comboBox3.Enabled = false;
            comboBox5.Enabled = false;
            comboBox7.Enabled = false;
            comboBox9.Enabled = false;
            comboBox11.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;
        }
    }
}
