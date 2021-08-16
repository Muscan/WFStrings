
namespace WinFormsApp1
{
    partial class Strings
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStringsIO = new System.Windows.Forms.Label();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDisplayedFunctionResult = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtInputChar = new System.Windows.Forms.TextBox();
            this.combo1st = new System.Windows.Forms.ComboBox();
            this.combo2nd = new System.Windows.Forms.ComboBox();
            this.lblValues = new System.Windows.Forms.Label();
            this.lblSingleCaracterArrays = new System.Windows.Forms.Label();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.txtBox4 = new System.Windows.Forms.TextBox();
            this.btnConvert2 = new System.Windows.Forms.Button();
            this.btnClear2 = new System.Windows.Forms.Button();
            this.lblArrayResult = new System.Windows.Forms.Label();
            this.lblSingleCharacter3rd = new System.Windows.Forms.Label();
            this.txtBox5 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblStringsIO
            // 
            this.lblStringsIO.AutoSize = true;
            this.lblStringsIO.Location = new System.Drawing.Point(12, 89);
            this.lblStringsIO.Name = "lblStringsIO";
            this.lblStringsIO.Size = new System.Drawing.Size(116, 20);
            this.lblStringsIO.TabIndex = 0;
            this.lblStringsIO.Text = "Insert characters";
            this.lblStringsIO.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(12, 112);
            this.txtInput2.MaxLength = 255;
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.Size = new System.Drawing.Size(146, 27);
            this.txtInput2.TabIndex = 1;
            this.txtInput2.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            // 
            // btnConvert
            // 
            this.btnConvert.Location = new System.Drawing.Point(12, 167);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(70, 29);
            this.btnConvert.TabIndex = 2;
            this.btnConvert.Text = "Convert String";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(258, 167);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(92, 29);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblDisplayedFunctionResult
            // 
            this.lblDisplayedFunctionResult.AutoSize = true;
            this.lblDisplayedFunctionResult.Location = new System.Drawing.Point(53, 210);
            this.lblDisplayedFunctionResult.Name = "lblDisplayedFunctionResult";
            this.lblDisplayedFunctionResult.Size = new System.Drawing.Size(245, 20);
            this.lblDisplayedFunctionResult.TabIndex = 4;
            this.lblDisplayedFunctionResult.Text = "Result from the Function conversion";
            this.lblDisplayedFunctionResult.Visible = false;
            this.lblDisplayedFunctionResult.Click += new System.EventHandler(this.lblDisplayedFunctionResult_Click);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(185, 89);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(165, 20);
            this.lbl4.TabIndex = 8;
            this.lbl4.Text = "Insert a single character";
            this.lbl4.Visible = false;
            // 
            // txtInputChar
            // 
            this.txtInputChar.Location = new System.Drawing.Point(185, 112);
            this.txtInputChar.MaxLength = 10;
            this.txtInputChar.Name = "txtInputChar";
            this.txtInputChar.Size = new System.Drawing.Size(165, 27);
            this.txtInputChar.TabIndex = 11;
            this.txtInputChar.Visible = false;
            this.txtInputChar.TextChanged += new System.EventHandler(this.txtInputChar_TextChanged);
            // 
            // combo1st
            // 
            this.combo1st.AllowDrop = true;
            this.combo1st.FormattingEnabled = true;
            this.combo1st.Items.AddRange(new object[] {
            "Number of Char from a String",
            "Extract Numbers from a String",
            "Check if text contains Vowel"});
            this.combo1st.Location = new System.Drawing.Point(12, 58);
            this.combo1st.Name = "combo1st";
            this.combo1st.Size = new System.Drawing.Size(338, 28);
            this.combo1st.TabIndex = 13;
            this.combo1st.Text = "Select a function from the drop down";
            this.combo1st.SelectedIndexChanged += new System.EventHandler(this.combo1st_SelectedIndexChanged);
            // 
            // combo2nd
            // 
            this.combo2nd.AllowDrop = true;
            this.combo2nd.FormattingEnabled = true;
            this.combo2nd.Items.AddRange(new object[] {
            "Direct sort",
            "Bubble sort",
            "Binary search",
            "Delete an element from a position",
            "Insert an element to a specified position"});
            this.combo2nd.Location = new System.Drawing.Point(424, 58);
            this.combo2nd.Name = "combo2nd";
            this.combo2nd.Size = new System.Drawing.Size(506, 28);
            this.combo2nd.TabIndex = 14;
            this.combo2nd.Text = "Select an array from the drop down";
            this.combo2nd.SelectedIndexChanged += new System.EventHandler(this.combo2nd_SelectedIndexChanged);
            // 
            // lblValues
            // 
            this.lblValues.AutoSize = true;
            this.lblValues.Location = new System.Drawing.Point(424, 89);
            this.lblValues.Name = "lblValues";
            this.lblValues.Size = new System.Drawing.Size(90, 20);
            this.lblValues.TabIndex = 15;
            this.lblValues.Text = "Insert values";
            // 
            // lblSingleCaracterArrays
            // 
            this.lblSingleCaracterArrays.AutoSize = true;
            this.lblSingleCaracterArrays.Location = new System.Drawing.Point(576, 89);
            this.lblSingleCaracterArrays.Name = "lblSingleCaracterArrays";
            this.lblSingleCaracterArrays.Size = new System.Drawing.Size(165, 20);
            this.lblSingleCaracterArrays.TabIndex = 16;
            this.lblSingleCaracterArrays.Text = "Insert a single character";
            this.lblSingleCaracterArrays.Visible = false;
            // 
            // txtBox3
            // 
            this.txtBox3.AllowDrop = true;
            this.txtBox3.Location = new System.Drawing.Point(424, 112);
            this.txtBox3.MaxLength = 255;
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(146, 27);
            this.txtBox3.TabIndex = 17;
            this.txtBox3.TextChanged += new System.EventHandler(this.txtBox3_TextChanged);
            // 
            // txtBox4
            // 
            this.txtBox4.Location = new System.Drawing.Point(576, 112);
            this.txtBox4.MaxLength = 10;
            this.txtBox4.Name = "txtBox4";
            this.txtBox4.Size = new System.Drawing.Size(165, 27);
            this.txtBox4.TabIndex = 18;
            this.txtBox4.Visible = false;
            // 
            // btnConvert2
            // 
            this.btnConvert2.Location = new System.Drawing.Point(424, 167);
            this.btnConvert2.Name = "btnConvert2";
            this.btnConvert2.Size = new System.Drawing.Size(90, 29);
            this.btnConvert2.TabIndex = 19;
            this.btnConvert2.Text = "Convert String";
            this.btnConvert2.UseVisualStyleBackColor = true;
            this.btnConvert2.Click += new System.EventHandler(this.btnConvert2_Click);
            // 
            // btnClear2
            // 
            this.btnClear2.Location = new System.Drawing.Point(811, 167);
            this.btnClear2.Name = "btnClear2";
            this.btnClear2.Size = new System.Drawing.Size(119, 29);
            this.btnClear2.TabIndex = 20;
            this.btnClear2.Text = "Clear";
            this.btnClear2.UseVisualStyleBackColor = true;
            this.btnClear2.Click += new System.EventHandler(this.btnClear2_Click);
            // 
            // lblArrayResult
            // 
            this.lblArrayResult.AutoSize = true;
            this.lblArrayResult.Location = new System.Drawing.Point(482, 210);
            this.lblArrayResult.Name = "lblArrayResult";
            this.lblArrayResult.Size = new System.Drawing.Size(245, 20);
            this.lblArrayResult.TabIndex = 21;
            this.lblArrayResult.Text = "Result from the Function conversion";
            this.lblArrayResult.Visible = false;
            // 
            // lblSingleCharacter3rd
            // 
            this.lblSingleCharacter3rd.AutoSize = true;
            this.lblSingleCharacter3rd.Location = new System.Drawing.Point(747, 89);
            this.lblSingleCharacter3rd.Name = "lblSingleCharacter3rd";
            this.lblSingleCharacter3rd.Size = new System.Drawing.Size(165, 20);
            this.lblSingleCharacter3rd.TabIndex = 22;
            this.lblSingleCharacter3rd.Text = "Insert a single character";
            this.lblSingleCharacter3rd.Visible = false;
            // 
            // txtBox5
            // 
            this.txtBox5.Location = new System.Drawing.Point(747, 112);
            this.txtBox5.MaxLength = 10;
            this.txtBox5.Name = "txtBox5";
            this.txtBox5.Size = new System.Drawing.Size(183, 27);
            this.txtBox5.TabIndex = 23;
            this.txtBox5.Visible = false;
            // 
            // Strings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 547);
            this.Controls.Add(this.txtBox5);
            this.Controls.Add(this.lblSingleCharacter3rd);
            this.Controls.Add(this.lblArrayResult);
            this.Controls.Add(this.btnClear2);
            this.Controls.Add(this.btnConvert2);
            this.Controls.Add(this.txtBox4);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.lblSingleCaracterArrays);
            this.Controls.Add(this.lblValues);
            this.Controls.Add(this.combo2nd);
            this.Controls.Add(this.combo1st);
            this.Controls.Add(this.txtInputChar);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblDisplayedFunctionResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput2);
            this.Controls.Add(this.lblStringsIO);
            this.Name = "Strings";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Strings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStringsIO;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDisplayedFunctionResult;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtInputChar;
        private System.Windows.Forms.ComboBox combo1st;
        private System.Windows.Forms.ComboBox combo2nd;
        private System.Windows.Forms.Label lblValues;
        private System.Windows.Forms.Label lblSingleCaracterArrays;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.TextBox txtBox4;
        private System.Windows.Forms.Button btnConvert2;
        private System.Windows.Forms.Button btnClear2;
        private System.Windows.Forms.Label lblArrayResult;
        private System.Windows.Forms.Label lblSingleCharacter3rd;
        private System.Windows.Forms.TextBox txtBox5;
    }
}

