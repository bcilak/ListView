using System.Collections.Generic;
using System.Windows.Forms;

namespace Baris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Sütun sayısını belirledik
            myListView1.Columns.Add("AD");
            myListView1.Columns.Add("SOYAD");
            myListView1.Columns.Add("YAŞ");
            myListView1.Columns.Add("NUMARA");
            /// Sütunların altına gelcek bilgileri yazdık.
            myListView1.Items.Add(new List<string>() { "Ali", "Veli", "25", "1234567890" });
            myListView1.Items.Add(new List<string>() { "Veli", "Ali", "25", "0987654321" });
            myListView1.Items.Add(new List<string>() { "1", "2", "35", "4164646328" });
            myListView1.Items.Add(new List<string>() { "test", "2dsa", "30", "2156478916" });
            myListView1.Items.Add(new List<string>() { "test", "2dsa", "83", "6549811025" });
            myListView1.Items.Add(new List<string>() { "Ali", "Veli", "25", "1234567890" });
            myListView1.Items.Add(new List<string>() { "Veli", "Ali", "25", "0987654321" });
            myListView1.Items.Add(new List<string>() { "1", "2", "35", "4164646328" });
            myListView1.Items.Add(new List<string>() { "test", "2dsa", "30", "2156478916" });
            myListView1.Items.Add(new List<string>() { "test", "2dsa", "83", "6549811025" });
            myListView1.Items.Add(new List<string>() { "Ali", "Veli", "25", "1234567890" });
            myListView1.Items.Add(new List<string>() { "Veli", "Ali", "25", "0987654321" });
            myListView1.Items.Add(new List<string>() { "1", "2", "35", "4164646328" });
            myListView1.Items.Add(new List<string>() { "test", "2dsa", "30", "2156478916" });
            myListView1.Items.Add(new List<string>() { "Ali", "Veli", "25", "1234567890" });
            myListView1.Items.Add(new List<string>() { "Veli", "Ali", "25", "0987654321" });
            myListView1.Items.Add(new List<string>() { "1", "2", "35", "4164646328" });
            myListView1.Items.Add(new List<string>() { "test", "2dsa", "30", "2156478916" });
            myListView1.Items.Add(new List<string>() { "test", "2dsa", "83", "6549811025" });

            vScrollBar1.Minimum = 0;
            vScrollBar1.Maximum = 50;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            //Scroll için ekranı aşağı yukarı kaydırmak için gereken ilk değer ve son değeri tanımladık.
            var a = e.NewValue;
            var b = e.OldValue;
            myListView1.scroll = e.NewValue;
            Refresh();
        }
    }
}
