using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class FormView : Form
    {
        private int _x;
        private int _y;

        public FormView()
        {
            InitializeComponent();

            _x = 50;
            _y = 50;
        }

        private void FormView_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(Brushes.BlueViolet, _x, _y, 100, 100);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //_x += 10;
            Invalidate();
        }
    }
}
