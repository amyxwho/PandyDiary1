using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PandySocial : Form
    {
        public PandySocial()
        {
            InitializeComponent();
        }

        public void readData(List<int> data)
        {
            int score = 0;
            for (int i = 0; i < data.Count; i++)
            {
                socialChart.Series["Social"].Points.AddXY(i, data.ElementAt(i));
                score += data.ElementAt(i);
            }
            if (data.Count == 0) { score = 0; }
            else { score = score / data.Count; }
            socialScore.Text = score.ToString(); 
        }

    }
}
