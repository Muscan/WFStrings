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
using static WinFormsApp1.Arrays;
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
            switch (combo1st.Text)
            {
                case "Extract Numbers from a String":
                    {
                        if (txtInput2.Text.Equals("") == false)
                        {
                            convertButton += "Extract Numbers from a String: " + ExtractNumbers(txtInput2.Text) + "\n";

                            lblDisplayedFunctionResult.Text = convertButton;
                            lblDisplayedFunctionResult.Visible = true;
                        }
                        else if (txtInput2.Text.Equals(""))
                        {
                            MessageBox.Show("Input field cannot be empty");
                        }
                        break;
                    }
                case "Number of Char from a String":
                    {

                        if (txtInput2.Text.Equals("") == false)
                        {
                            if (txtInputChar.Text.Length == 1)
                            {
                                convertButton += "Result for the function: " + NrCharTxt(txtInput2.Text, txtInputChar.Text[0]) + "\n";
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
                        if (txtInput2.Text.Length == 1)
                        {
                            if (IsVowel(txtInput2.Text[0]) == true)
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
            txtInput2.Text = "";
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

        //Select an array section drop down
        private void combo2nd_SelectedIndexChanged(object sender, EventArgs e)

        {
            if (combo2nd.Text.Equals("Direct sort") == true || combo2nd.Text.Equals("Bubble sort") == true)
            {
                txtBox4.Visible = false;
                txtBox5.Visible = false;
                lblSingleCaracterArrays.Visible = false;
                lblSingleCharacter3rd.Visible = false;
            }
            else
            {
                txtBox4.Visible = true;
                lblSingleCaracterArrays.Visible = true;
                if (combo2nd.Text.Equals("Insert an element to a specified position") == true)
                {
                    txtBox5.Visible = true;
                    lblSingleCharacter3rd.Visible = true;
                }
                else
                {
                    txtBox5.Visible = false;
                    lblSingleCharacter3rd.Visible = false;
                }
            }

        }
        //Convert button from array section
        private void btnConvert2_Click(object sender, EventArgs e)
        {
            String convertButton = "";
            //convert the input from a string to an array [] int
            //split text
            string[] wordSplitted = txtBox3.Text.Split(" ");//ex: 23 45 7 8
            int[] intFromString = new int[wordSplitted.Length];
            for(int i=0; i<wordSplitted.Length;i++)
            {
                if (wordSplitted[i].Equals("") == false)
                     intFromString[i] = Int32.Parse(wordSplitted[i]);
            }
            switch (combo2nd.Text)
            {
                case "Direct sort":
                    {
                        DirectSort(intFromString);
                        convertButton = ConvertInputIntToOutputString(intFromString);
                        lblArrayResult.Text = convertButton;
                        lblArrayResult.Visible = true;
                        break;
                    }

            }
        }
        //Inser value, text box3
        private void txtBox3_TextChanged(object sender, EventArgs e)
        {
            if(txtBox3.Text.Length >= 1) { 
            if(Char.IsDigit(txtBox3.Text[txtBox3.Text.Length-1]) == false 
                && txtBox3.Text[txtBox3.Text.Length - 1] != ' ')
                MessageBox.Show("Only digits are allowed.");
                }
        }

        private void btnClear2_Click(object sender, EventArgs e)
        {
            txtBox3.Text = "";
            txtBox4.Text = "";
            txtBox5.Text = "";
            lblArrayResult.Visible = false;
        }
    }
}
