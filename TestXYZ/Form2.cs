using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChartDirector;

namespace TestXYZ
{

    public partial class Form2 : Form
    {

        public  Chart2 ch = new Chart2();

        public Form1 f1 = null;

        List<float?> GX = Form1.GX;
        List<float?> GY = Form1.GY;
        List<float?> GZ = Form1.GZ;


        public Form2(Form1 form)
        {
            f1 = form;
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ch.createChart(chartViewer, 1, -5, +5);
            chartViewer.Visible = true;
        }

        private void Form2_Leave(object sender, EventArgs e)
        {
            this.Close();
        }
        private void chartViewer_ViewPortChanged(object sender, WinViewPortEventArgs e)
        {
            for (int i = 0 ; i < GX.Count; i ++ )
            {
                if (GX[i] != null && GY[i] != null && GZ[i] != null)
                {
                    String sfx = GX[i].ToString();
                    float fx = Convert.ToSingle(sfx) - Convert.ToSingle(f1.textBox1.Text);
                    String sfy = GY[i].ToString();
                    float fy = Convert.ToSingle(sfy) - Convert.ToSingle(f1.textBox2.Text);
                    String sfz = GZ[i].ToString();
                    float fz = Convert.ToSingle(sfz) - Convert.ToSingle(f1.textBox3.Text);

                    ch.AddPointChart(chartViewer, fx, fy, fz);
                    ch.createChart(chartViewer, 1, 0, 10);
                }
            }
            ch.createChart(chartViewer, 1, 0, 10);
        }
        

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (f1.textBox1.Text != null && f1.textBox2.Text != null && f1.textBox3.Text != null)
            {
                chartViewer.updateViewPort(true, false);
            }
        }
    }
}
