using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class MetPuls : Form
    {
        public MetPuls()
        {
            InitializeComponent();
        }
        // + + CULORI
        private void MetPuls_Load(object sender, EventArgs e)
        {
            BackColor = System.Drawing.ColorTranslator.FromHtml("#EFEFEF");
        }
    }
}
