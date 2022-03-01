using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.InteropServices;
namespace PrivateTyper
{
    public partial class Form1 : Form
    {
        public PrivateFontCollection pfc = new PrivateFontCollection();
        public bool encoded = true;
        public bool enableHover = true;
        public Form1(){
            InitializeComponent();
            InitializeFont();
            foreach( Control c in this.Controls){UseCustomFont(c);}
        }
        public void InitializeFont(){
            int fontLength = PrivateTyper.Properties.Resources.myfont.Length;
            byte[] fontdata = PrivateTyper.Properties.Resources.myfont;
            System.IntPtr data = Marshal.AllocCoTaskMem(fontLength);
            Marshal.Copy(fontdata, 0, data, fontLength);
            pfc.AddMemoryFont(data, fontLength);
            Marshal.FreeCoTaskMem(data);
        }
        private void Form1_Load(object sender, EventArgs e){
            PrivateFontCollection pfc = new PrivateFontCollection();
        }
        public void UseCustomFont(Control ctrl){
            if(ctrl is TextBox || ctrl is Label || ctrl is ComboBox||ctrl is Button || ctrl is RichTextBox){
                ctrl.Font = new Font(pfc.Families[0], ctrl.Font.Size+2);
            }
        }
        public void EncodeOrDecode(bool toDo){
            if (encoded){richTextBoxOutput.Font = new Font("Times New Roman", richTextBoxOutput.Font.Size);}
            else{richTextBoxOutput.Font = new Font(pfc.Families[0], richTextBoxOutput.Font.Size);}
            encoded = !encoded;
        }
        private void richTextBoxOutput_MouseEnter(object sender, EventArgs e){
            if (enableHover) { EncodeOrDecode(true); }
        }
        private void richTextBoxOutput_MouseLeave(object sender, EventArgs e){
            if (enableHover) { EncodeOrDecode(false); }
        }
        private void textBoxInput_KeyDown(object sender, KeyEventArgs e){
            if (e.KeyCode == Keys.Space|| e.KeyCode == Keys.Return){
                richTextBoxOutput.AppendText(textBoxInput.Text);
                textBoxInput.Text = "";
                e.Handled = true;
            }
            if(e.KeyCode == Keys.Delete){
                richTextBoxOutput.Text = richTextBoxOutput.Text.Substring(0, richTextBoxOutput.Text.Length - 1);
            }
        }
        private void checkBoxHoverEnabled_CheckedChanged(object sender, EventArgs e){
            enableHover = checkBoxHoverEnabled.Checked;
        }
    }
}
