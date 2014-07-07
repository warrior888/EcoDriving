using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowCanIGetThere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Test test = new Test();
            var pros = test.getRootNode("Pruószkowska - center", 32.5, 10.5);

            var niem = test.AddNode(pros, "Niemodlinska - proskowska", 32.8, 10.9);
            var spych = test.AddNode(niem, "spychalskiego - niemodlinska", 32.1, 10.4);
            var krapk = test.AddNode(spych, "Krapkowicka - spychalskiego", 33, 10.7);
            var krapkniem = test.AddNode(niem, "Krapkowicka - Niemodlinska", 33.2, 10.5);
            var krappreos = test.AddNode(pros, "proszkowska - krapkowicka", 33, 10.7);
            var wroc = test.AddNode(niem, "wroclawska - niem", 32.9, 11.1);
        }
    }
}
