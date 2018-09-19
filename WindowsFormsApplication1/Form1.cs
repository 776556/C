using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void load_data() {
            string[] str = new string[] { "蘋果", "西瓜", "鳳梨", "香蕉" };
            listBox1.Items.AddRange(str); 
        }
        private void Clear_textBox(TextBox textBox)
        {
            textBox.Clear(); 
        }
        private void Focus_textBox(TextBox textBox)
        {
            textBox.Focus();
        }
        private void setlistBoxValue(TextBox textbox)
        {//
            listBox1.Items.Add(getTextBoxValue(textbox));       //Trim()去除前後空白 
            textBoxSetSOP(textBox1);
        }
        private String getTextBoxValue(TextBox textbox)//取textbox值
        {
            return textbox.Text.Trim();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            setlistBoxValue(textBox1);          
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

           // MessageBox.Show(e.KeyCode.ToString());
            if (getTextBoxValue(textBox1) != "" && e.KeyCode.ToString() == "Return")
            {
                setlistBoxValue(textBox1);
            
            }
            
        }
        private void ClearlistBox(ListBox listBox)//清除listBox
        {
            listBox.Items.Clear();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            ClearlistBox(listBox1);
        }
        ListboxMethod ListboxMethod;
        private void Form1_Load(object sender, EventArgs e)
        {
            load_data();
          ListboxMethod = new ListboxMethod();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int n;
            n = listBox1.Items.Count;
            MessageBox.Show("n=" + n.ToString());
        }
        //---------------------------------------------------
        List<String> LT = new List<String>();
        private void textBoxSetSOP(TextBox textBox)
        {
            Clear_textBox(textBox);
            Focus_textBox(textBox);
        }
        private void button4_Click(object sender, EventArgs e)//add List data
        {          
            LT.Add(getTextBoxValue(textBox2));
            textBoxSetSOP(textBox2);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox2.DataSource = LT;
          
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            int n;
            n = listBox2.SelectedItems.Count;
            MessageBox.Show("n=" + n.ToString());
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
     
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            ListboxMethod.listBoxChanged(listBox1, label1);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            //listBox1.Items.Remove(textBox1.Text);
            ListboxMethod.listBoxRemove(listBox1, textBox1.Text);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ListboxMethod.listBoxcilkRemove(listBox1);

          
        }

        private void button11_Click(object sender, EventArgs e)
        {           
            ListboxMethod.textBoxSelectedIndex(listBox1,textBox1.Text.ToString());
            //listBox1.SelectedIndex = -1;
            //if (listBox1.FindString(textBox1.Text.Trim()) >= 0)
            //    listBox1.SelectedIndex = listBox1.FindString(textBox1.Text.Trim());
            //else
            //    MessageBox.Show("NOT FOUND");

           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Sorted =  listBox1.Sorted ? false:true; //開啟由小到大(升序)的排序功能
            button12.Text = listBox1.Sorted ? "排序(off)" : "排序(on)"; 
           // listBox1.Sorted = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox3.Text);
            listBox1.Items.Insert(n, textBox1.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            int n;
            n = Convert.ToInt32(textBox3.Text);
            listBox1.Items.RemoveAt(n);
            listBox1.Items.Insert(n, textBox1.Text);

        }

        private void button15_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, true);
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
                listBox1.SetSelected(i, false);
            }
        }
       

    }
}
