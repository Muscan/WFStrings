using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WinFormsApp1.Functions;

namespace WinFormsApp1
{
    public partial class Strings : Form
    {
        public Strings()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            //Input field 1
        }
        private void txtInput2_TextChanged(object sender, EventArgs e)
        {
            //Input field2
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            String convertButton = "";

            /*if (txtInput1.Text.Equals("") == false)
            {
                convertButton += "Extract Numbers from a String: " + ExtractNumbers(txtInput1.Text) + "\n";

                lblDisplayedFunctionResult.Text = convertButton;
                lblDisplayedFunctionResult.Visible = true;
            }
            else if (txtInput1.Text.Equals(""))
            {
                MessageBox.Show("Input field cannot be empty");
            } */
            switch(combo1st.Text)
            {
                case "Extract Numbers from a String":
                    {
                        if (txtInput1.Text.Equals("") == false)
                        {
                            convertButton += "Extract Numbers from a String: " + ExtractNumbers(txtInput1.Text) + "\n";

                            lblDisplayedFunctionResult.Text = convertButton;
                            lblDisplayedFunctionResult.Visible = true;
                        }
                        else if (txtInput1.Text.Equals(""))
                        {
                            MessageBox.Show("Input field cannot be empty");
                        }
                        break;
                    }
                case "Number of Char from a String":
                    {

                        if (txtInput1.Text.Equals("") == false)
                        {
                            if (txtInputChar.Text.Length == 1)
                            {
                                convertButton += "Result for the function: " + NrCharTxt(txtInput1.Text, txtInputChar.Text[0]) + "\n";
                                lblDisplayedFunctionResult.Text = convertButton;
                                lblDisplayedFunctionResult.Visible = true;
                            }
                            else
                            {
                                MessageBox.Show("Max or at least one character allowed");
                            }

                        }
                        else
                        {
                            MessageBox.Show("Input field cannot be empty");
                        }
                        break;
                    }
                case "Check if text contains Vowel":
                    {
                        if (txtInput1.Text.Length == 1)
                        {
                            if (IsVowel(txtInput1.Text[0]) == true)
                                convertButton += "Result for the function: " + "The char is vowel" + "\n";
                            else
                                convertButton += "Result for the function: " + "The char is not vowel" + "\n";
                            lblDisplayedFunctionResult.Text = convertButton;
                            lblDisplayedFunctionResult.Visible = true;
                        }
                        else
                        {
                            MessageBox.Show("Max or at least one character allowed");
                        }
                        break;
                    }

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //clear button
            txtInput1.Text = "";
            lblDisplayedFunctionResult.Visible = false;
           
            
            //clear input fields for string and char -- delete the comments if the function is changed
            txtInputChar.Text = "";



        }


        private void txtInputChar_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lblDisplayedFunctionResult_Click(object sender, EventArgs e)
        {
            //Result from the function conversion
        }

        private void combo1st_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo1st.Text.Equals("Number of Char from a String") == false)
            {
                txtInputChar.Visible = false;
                lbl4.Visible = false;
            }
            else
            {
                txtInputChar.Visible = true;
                lbl4.Visible = true;

            }
            //drop down

        }

        private void Strings_Load(object sender, EventArgs e)
        {

        }

        private void combo2nd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
