using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bento_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // set_selectData();
            selectData();
            listBoxp_setup();
        }
        private string[,] selecrArrayData() {
            string[,] a = new string[,] { { "排骨飯", "80" }, { "雞排飯", "70" }, { "香腸飯", "60" } };
            return a;
        }
        private List<Bento> selectBentoData()
        {
            List<Bento> l = new List<Bento>();
            l.Add(new Menu() { bentoName = "排骨飯" });
           // l.Add("雞排飯");
            //l.Add();
            // l.Add("香腸飯");
            return l;
        }
        private void selectup() {
            comboBox1.DataSource = null;
            comboBox1.DataSource = newmenu;
        }
        private void selectDisplayData()
        {
            
            comboBox1.DisplayMember = "bentoName";
            comboBox1.ValueMember = "bentoName";
        }
        private void selectprm()
        {
            selectup();
            selectDisplayData();   
        }
        private void selectData()
        {
            newmenu.Add(new Menu() { bentoName = "排骨飯", bentoPrice = 100 });
            newmenu.Add(new Menu() { bentoName = "雞排飯", bentoPrice = 80 });
            newmenu.Add(new Menu() { bentoName = "雞腿飯", bentoPrice = 110 });
            selectprm();
            //return l;
        }
        //  private void set_selectData(){
        //      comboBox1.DataSource = selectBentoData();//selectData();
        //      comboBox1.DisplayMember = "bentoName";
        //      comboBox1.ValueMember = "bentoName";
        //}
          string temp_comboBox1 = "";
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // comboBox1.Text
            //MessageBox.Show(comboBox1.Text.ToString());
            setPrice();
            if (temp_comboBox1 != comboBox1.Text)
            {
                temp_comboBox1 = comboBox1.Text;
                label10.Text = "0";
                textBox1.Text = "";
            }
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try {
                if (textBox1.Text != "")
                {
                    int a = int.Parse(textBox1.Text);
                    int b = int.Parse(label5.Text);
                    label10.Text = (a * b).ToString();
                }
                else
                {
                    label10.Text = "0";
                }
            }
            catch (Exception eq) {
                msg("訂購數量請輸入數字");
                textBox1.Text = "";
            }
           
            
        }

        List<Menu> newmenu = new List<Menu>();
        private void uplistBoxData()//重新更新listBox
        {
            listBox1.DataSource = null;
            listBox1.DataSource = newmenu;
        }
        private void uplistBoxDisplayData()//設定listBox要顯示的資料欄位
        {
            listBox1.DisplayMember = "bentoName";
        }
        private void listBoxp_setup()
        {
            uplistBoxData();
            uplistBoxDisplayData();
        }
        private void comboBox_setup()
        {
            comboBox1.DataSource = null;
            comboBox1.DataSource = newmenu;// selectBentoData();//selectData();
            comboBox1.DisplayMember = "bentoName";
            comboBox1.ValueMember = "bentoName";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                 String bentoName = textBox2.Text;//便當名稱
                if (bentoName ==""){
                    msg("請輸入便當名稱");
                    return;
                }
               
                int price = int.Parse(textBox3.Text);//便當單價
                newmenu.Add(new Menu() { bentoName = bentoName, bentoPrice = price });
                comboBox_setup();
                listBoxp_setup();
                textBox2.Text = "";
                textBox3.Text = "";
                textBox2.Focus();
            }
            catch (Exception eq) {
                textBox3.Text = "";
                msg("請輸入便當價錢!");
            }
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        private void setPrice() {
            if (comboBox1.Text.ToString() != "")
            {
                Menu s = newmenu.Find(x => x.bentoName.Contains(comboBox1.Text.ToString()));//搜尋
                if(null != s){
                     label5.Text = s.bentoPrice.ToString();
                }
         
            }
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
           // Menu s = newmenu.Find(x => x.bentoName.Contains("11"));//搜尋
           // MessageBox.Show(s.bentoName.ToString()+"  "+s.bentoPrice.ToString());
           // dataGridView1.Rows[2].Cells[0].Value = "123";
            //Menu s = newmenu.Find(x => x.bentoName.Contains("排骨飯"));//搜尋

            //MessageBox.Show(s.bentoName);
            //listBox1.= "bentoName";
            //listBox1.SelectedValue = "雞腿飯";
            //listBox1.SelectedItem.Text;
            //listBox1.Items.Remove("雞腿飯");
            //comboBox1.DataSource = null;
            //comboBox1.DataSource = newmenu;// selectBentoData();//selectData();
            //comboBox1.DisplayMember = "bentoName";
            //comboBox1.ValueMember = "bentoName";
            //MessageBox.Show(((Menu)listBox1.SelectedItem).bentoName);
            //comboBox_setup();
           // comboBox1.SelectedIndex = 0;
            Menu s = l.Find(x => x.bentoName.Contains(comboBox1.Text));//搜尋
           // MessageBox.Show(s.ToString());
          
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void setDataGridViewHeaderText()
        {//設定DataGridView欄位名稱
            dataGridView1.Columns["bentoName"].HeaderText = "便當名稱";
            dataGridView1.Columns["bentoPrice"].HeaderText = "便當單價";
            dataGridView1.Columns["OrderQty"].HeaderText = "訂購數量";
            dataGridView1.Columns["TPrice"].HeaderText = "總價";
            
        }
        private void upDataGridView()//重整DataGridView
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = l;
        }
        List<Menu> l = new List<Menu>();
        private void button3_Click(object sender, EventArgs e)
        {
            //listBox2.Items.Add(comboBox1.Text + "   " + label5.Text + "元 *" + textBox1.Text + " =" + label10.Text);
          //  listBox2.Items.Add("44"); 
            //if (textBox1.Text != "")
            //{              
                try {
                    Menu s = l.Find(x => x.bentoName.Contains(comboBox1.Text));//搜尋
                    if(null==s){
                        
                        l.Add(new Menu() { bentoName = comboBox1.Text, bentoPrice = int.Parse(label5.Text), OrderQty = int.Parse(textBox1.Text), TPrice = int.Parse(label10.Text) });
                      
                    }else{
                        
                        s.OrderQty=s.OrderQty+int.Parse(textBox1.Text);
                        s.TPrice = s.TPrice + int.Parse(label10.Text);
                    }
                    upDataGridView();
                    setDataGridViewHeaderText();
                }
                catch (Exception eq) {
                    msg("請輸入訂購數量");
                }
           // }
          //  else {
                //MessageBox.Show();
             //   msg("請輸入訂購數量");
            //}
           
            
        }
        int RowIndex;
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //RowIndex = e.RowIndex; //點哪一個資料 
           // MessageBox.Show(RowIndex.ToString());
        }
        private void msg(string m) {
            MessageBox.Show(m);       
        }
        private void button4_Click(object sender, EventArgs e)
        {
           // dataGridView1.Rows.RemoveAt(RowIndex);//刪除
           // MessageBox.Show(RowIndex.ToString());
            try {
                l.RemoveAt(RowIndex);
                upDataGridView();
                setDataGridViewHeaderText();
            }
            catch (Exception eq) {
                msg("刪除失敗! 請點選項目");
            }
            
           // dataGridView1.Rows.RemoveAt(1);
        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
      
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RowIndex = e.RowIndex; //點哪一個資料 
            // MessageBox.Show(RowIndex.ToString());
            // l[RowIndex].bentoName 
            
            comboBox1.Text = l[RowIndex].bentoName.ToString();
            textBox1.Text = l[RowIndex].OrderQty.ToString();
            button5.Text = "修改[" + comboBox1.Text + "]數量";
            button5.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            //MessageBox.Show(l[1].bentoName.ToString());
            //MessageBox.Show(l[1].bentoPrice.ToString());
            //MessageBox.Show(l[1].OrderQty.ToString());
            //MessageBox.Show(l[1].TPrice.ToString());
           // l[1].bentoName = "qqqqq";
            
            try {
                //只能修改訂單數量
                l[RowIndex].OrderQty = int.Parse(textBox1.Text);
                l[RowIndex].TPrice = int.Parse(label10.Text);
                upDataGridView();
                setDataGridViewHeaderText();
            }
            catch (Exception eq) {
                msg("請先加入訂單");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_Click(object sender, EventArgs e)
        {

        }
        int listBoxRemoveIndex;
        private void listBox1_MouseClick(object sender, MouseEventArgs e)
        {
            comboBox_setup();
            listBoxRemoveIndex = listBox1.IndexFromPoint(e.X, e.Y);
           // MessageBox.Show(listBoxRemoveIndex.ToString());
            //MessageBox.Show("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //listBox1.Items.RemoveAt(listBoxRemoveIndex);
            try {
               // String lb_bentoName = ((Menu)listBox1.SelectedItem).bentoName;
                //刪除listBox項目
                newmenu.RemoveAt(listBoxRemoveIndex);
                //更新listBox項目  
                listBoxp_setup();
                //更新comboBox1項目  
                 comboBox_setup();
                 comboBox1.SelectedIndex = 0;
               // listBox1.Items.Remove(lb_bentoName);
            }
            catch (Exception eq) {
                msg(eq.ToString());
                //msg("請選擇菜單");
            }

           // comboBox1.Items.Remove();
            
        }

    }
}
