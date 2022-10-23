using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Baris
{
    
    public partial class MyListView : Control
    {

        public List<string> Columns { get; set; }
        public List<List<string>> Items { get; set; }
        Brush softLine, headerBrush, textBrush;
        public int scroll { get; set; }
        public MyListView()
        {
            // Ekranda yazan stringlerin renklerini ayarladık.
            InitializeComponent();
            Columns = new List<string>();
            Items = new List<List<string>>();
            softLine = new SolidBrush(Color.Gray);
            headerBrush = new SolidBrush(Color.Red);
            textBrush = new SolidBrush(Color.Black);
        }
        /// <summary>
        /// Rectangel oluşturup mylistview in şablonu oluşturduk
        /// graphics.drawline kullanarak rectangel in kenarlarını belirledik.
        /// if ve for döngüleri kullanarak mevcut sütün sayısına göre paneli böldürdük.
        /// </summary>
        protected override void OnPaint(PaintEventArgs pe)
        {
            
            Color colorWhite = Color.FromArgb(200, 250, 250);


            SolidBrush sb = new SolidBrush(colorWhite);
            pe.Graphics.FillRectangle(sb, 0, 0, this.Width, this.Height);
            // Eğer Form1 içinde veri yoksa ekrana yazılmasını verinin olamdığını gösteren yazıyı yazdırmka için.
            if(Columns.Count <= 0)
            {
                pe.Graphics.DrawString("Veri yok!", new Font(Font.FontFamily.Name, 23), headerBrush, this.Width / 2 - 75, this.Height / 2 - 23);

            }
            ///<summary>
            ///satır sütünların doğru hizada olmasını eksiksiz şekilde yazılmasını sağlamak için kullandığımız yer.
            ///Sonraki veriye geçilmeisne yarayan kodları yazdık.
            ///</summary>
            else
            {
                float range = this.Width / Columns.Count;
                for (int i = 0; i < Columns.Count - 1; i++)
                {
                    pe.Graphics.DrawLine(new Pen(softLine), range * (i + 1), 0, range * (i + 1), (this.Height / 10) - scroll * 10);
                }
                for (int i = 0; i < Columns.Count; i++)
                {
                    pe.Graphics.DrawString(Columns[i], new Font(Font.FontFamily.Name, 13), headerBrush, range * i + 1.5f, 2f - scroll * 10);
                }
                for (int i = 0; i < Items.Count; i++)
                {
                    for (int j = 0; j < Columns.Count; j++)
                    {
                        if (Items[i].Count <= j) continue;
                        pe.Graphics.DrawString(Items[i][j], new Font(Font.FontFamily.Name, 12), textBrush, range * j + 1.5f, (this.Height / 10 * (i + 1)) - scroll * 10);
                    }
                }
            }
            pe.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), 0, 0, 0, this.Height);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), 0, this.Height - 1, this.Width, this.Height - 1);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), this.Width - 1, this.Height, this.Width - 1, 0);
            pe.Graphics.DrawLine(new Pen(new SolidBrush(Color.Black)), this.Width, 0, 0, 0);
            sb.Dispose();
        }
    }
}
