using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Q445945
{
    public partial class Form1 : Form
    {
        public Form1() {
            InitializeComponent();
        }

        private void simpleButton1_Click_1(object sender, EventArgs e) {
            anotherColorPickEdit1.RemoveColorByName("Web", "Transparent");
        }

        private void simpleButton2_Click_1(object sender, EventArgs e) {
            anotherColorPickEdit1.RemoveColorsByNames("Web", new List<string>() { "Black", "Red" });
        }
    }
}
