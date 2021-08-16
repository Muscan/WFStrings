
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
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblDisplayedFunctionResult = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.txtInputChar = new System.Windows.Forms.TextBox();
            this.combo1st = new System.Windows.Forms.ComboBox();
            this.combo2nd = new System.Windows.Forms.ComboBox();
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
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(12, 112);
            this.txtInput1.MaxLength = 255;
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.Size = new System.Drawing.Size(146, 27);
            this.txtInput1.TabIndex = 1;
            this.txtInput1.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
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
            "Delete an element from a position",
            "Binary search"});
            this.combo2nd.Location = new System.Drawing.Point(424, 58);
            this.combo2nd.Name = "combo2nd";
            this.combo2nd.Size = new System.Drawing.Size(233, 28);
            this.combo2nd.TabIndex = 14;
            this.combo2nd.Text = "Select an array from the drop down";
            this.combo2nd.SelectedIndexChanged += new System.EventHandler(this.combo2nd_SelectedIndexChanged);
            // 
            // Strings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 547);
            this.Controls.Add(this.combo2nd);
            this.Controls.Add(this.combo1st);
            this.Controls.Add(this.txtInputChar);
            this.Controls.Add(this.lbl4);
            this.Controls.Add(this.lblDisplayedFunctionResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.txtInput1);
            this.Controls.Add(this.lblStringsIO);
            this.Name = "Strings";
            this.Text = "0";
            this.Load += new System.EventHandler(this.Strings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStringsIO;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblDisplayedFunctionResult;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.TextBox txtInputChar;
        private System.Windows.Forms.ComboBox combo1st;
        private System.Windows.Forms.ComboBox combo2nd;
    }
}

