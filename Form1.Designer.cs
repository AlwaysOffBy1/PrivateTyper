namespace PrivateTyper
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.checkBoxHoverEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(8, 8);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(224, 22);
            this.textBoxInput.TabIndex = 1;
            this.textBoxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxInput_KeyDown);
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxOutput.BackColor = System.Drawing.Color.Black;
            this.richTextBoxOutput.ForeColor = System.Drawing.Color.White;
            this.richTextBoxOutput.Location = new System.Drawing.Point(8, 40);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(374, 275);
            this.richTextBoxOutput.TabIndex = 2;
            this.richTextBoxOutput.Text = "";
            this.richTextBoxOutput.MouseEnter += new System.EventHandler(this.richTextBoxOutput_MouseEnter);
            this.richTextBoxOutput.MouseLeave += new System.EventHandler(this.richTextBoxOutput_MouseLeave);
            // 
            // checkBoxHoverEnabled
            // 
            this.checkBoxHoverEnabled.AutoSize = true;
            this.checkBoxHoverEnabled.Checked = true;
            this.checkBoxHoverEnabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxHoverEnabled.Location = new System.Drawing.Point(256, 8);
            this.checkBoxHoverEnabled.Name = "checkBoxHoverEnabled";
            this.checkBoxHoverEnabled.Size = new System.Drawing.Size(76, 21);
            this.checkBoxHoverEnabled.TabIndex = 3;
            this.checkBoxHoverEnabled.Text = "Hover?";
            this.checkBoxHoverEnabled.UseVisualStyleBackColor = true;
            this.checkBoxHoverEnabled.CheckedChanged += new System.EventHandler(this.checkBoxHoverEnabled_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 325);
            this.Controls.Add(this.checkBoxHoverEnabled);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.textBoxInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
        private System.Windows.Forms.CheckBox checkBoxHoverEnabled;
    }
}

