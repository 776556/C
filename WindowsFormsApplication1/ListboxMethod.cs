using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
    class ListboxMethod
    {
        public void listBoxChanged(ListBox listBox, Label label)
        {
            String str = "";
            foreach (var S in listBox.SelectedItems)
            {
                str += S + "\n";
            }
            str += "選擇:" + listBox.SelectedItems.Count + "項";
            str += "\n總共:" + Total_pen(listBox) + "項";
            label.Text = str;
        }
        private int Total_pen(ListBox listBox)
        {
           // int n;
          //  n = listBox1.Items.Count;
            return listBox.Items.Count;
        } 

        public void listBoxRemove(ListBox listBox, String Removeame)//輸入刪除
        {
            listBox.Items.Remove(Removeame); 
        }
        public void listBoxcilkRemove(ListBox listBox)//點選刪除
        {
            int ii = 0; 
           // foreach (String S in listBox.SelectedItems)
           // {
               // MessageBox.Show(S);
                //listBox.Items.Remove(S); 
                
           // }
            for (int i = 0; i < listBox.SelectedItems.Count; i++)
            {
           //     MessageBox.Show(listBox.SelectedItems.Count.ToString());
                //listBox.Items.Remove(listBox.SelectedItems[i].ToString());
            //    listBox.Items.Remove(listBox.SelectedItems[0].ToString());
            }
            while (listBox.SelectedIndices.Count > 0)
            {
                listBox.Items.RemoveAt(listBox.SelectedIndices[0]);
            }
            
        }
        public void textBoxSelectedIndex(ListBox listBox,String str)
        {//textBox選擇項目
            listBox.SelectedIndex = -1;
            if (listBox.FindString(str.Trim()) >= 0)
                listBox.SelectedIndex = listBox.FindString(str.Trim());
            else
                MessageBox.Show("NOT FOUND");
        
        }
        public void listBoxUPDATE(ListBox listBox,String Removeame) { 
        //listBoxRemove(listBox,Removeame);
    

        }
        public void insert() { 
            
        
        }
    }
}
