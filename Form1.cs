using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Furnica
{
   
    public partial class Form1 : Form
    {
        char[] array = new char[1000];
        int clicks = 0;
        int x1 = 0;
        int x2 = 0;
        int y1 = 0;
        int y2 = 0;
        int whatever = 800;
        int index = 0;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)

        {
            Pen blackPen = new Pen(Color.Black, 1);
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(blackPen, 0, 0, 0, 800);
            g.DrawLine(blackPen, 0, 0, 800, 0);
            g.DrawLine(blackPen, 800, 800, 0, 800);
            g.DrawLine(blackPen, 800, 800, 800, 0);
            for (int j=0;j<=20;j++)
            {
                g.DrawLine(blackPen, y1, y2, y1, 800);y1 = y1 + 40;
                
            }
            y1 = 0;
            y2 = 0;
            x1 = 0;
            x2 = 0;
            for (int h = 0; h <= 20; h++)
            {
                g.DrawLine(blackPen, x1, y1, 800, y1); y1 = y1 + 40;

            }
            y1 = 800;
            y2 = 0;
            x1 = 0;
            x2 = 0;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Red, 6);
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            if (clicks==0)
            {g.DrawLine(blackPen, x1, y1, x1, y1-40); y1 = y1 - 40;   ; goto end;   }

        end:
            Console.WriteLine("a");
            array[index] = 'U';
            label2.Text = Convert.ToString(array);
            index++;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Red, 6);
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            if (clicks == 0)
            { g.DrawLine(blackPen, x1, y1, x1+40, y1); x1 = x1 + 40; ; goto end; }

        end:
            Console.WriteLine("a");
            array[index] = 'R';
            label2.Text = Convert.ToString(array);
            index++;
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Red, 6);
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            if (clicks == 0)
            { g.DrawLine(blackPen, x1, y1, x1, y1+40); y1 = y1 + 40; ; goto end; }

        end:
            Console.WriteLine("a");
            array[index] = 'J';
            label2.Text = Convert.ToString(array);
            index++;
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Red, 6);
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            if (clicks == 0)
            { g.DrawLine(blackPen, x1, y1, x1-40, y1); x1 = x1 - 40; ; goto end; }


        end:
            Console.WriteLine("a");
            array[index] = 'L';
            label2.Text =  Convert.ToString(array);
            index++;
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            
            for (int i=0;i<=index;i++)
            {
                System.Threading.Thread.Sleep(200);
                if (array[index] == 'J') { button3.PerformClick(); }
                if (array[index] == 'U') { button1.PerformClick(); }
                if (array[index] == 'R') { button2.PerformClick(); }
                if (array[index] == 'L') { button4.PerformClick(); }
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            
            y1 = 0;
            y2 = 0;
            x1 = 0;
            x2 = 0;
            panel1.Invalidate();
            clicks = 0;
            Label3_Click(sender, e);
            x1 = 0;
            x2 = 0;
            y1 = 800;
            y2 = 0;
            index = 0;
            
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            y1 = 0;
            y2 = 0;
            x1 = 0;
            x2 = 0;
            panel1.Invalidate();
            clicks = 0;
            Label3_Click(sender, e);
            x1 = 0;
            x2 = 0;
            y1 = 800;
            y2 = 0;
            index = 0;
            label2.Text = Convert.ToString('\0');
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {
            Pen blackPen = new Pen(Color.Black, 1);
            SolidBrush sb = new SolidBrush(Color.Red);
            Graphics g = panel1.CreateGraphics();
            g.DrawLine(blackPen, 0, 0, 0, 800);
            g.DrawLine(blackPen, 0, 0, 800, 0);
            g.DrawLine(blackPen, 800, 800, 0, 800);
            g.DrawLine(blackPen, 800, 800, 800, 0);
            for (int j = 0; j <= 20; j++)
            {
                g.DrawLine(blackPen, y1, y2, y1, 800); y1 = y1 + 40;

            }
            y1 = 0;
            y2 = 0;
            x1 = 0;
            x2 = 0;
            for (int h = 0; h <= 20; h++)
            {
                g.DrawLine(blackPen, x1, y1, 800, y1); y1 = y1 + 40;

            }
            y1 = 800;
            y2 = 0;
            x1 = 0;
            x2 = 0;
        }
    }
}
