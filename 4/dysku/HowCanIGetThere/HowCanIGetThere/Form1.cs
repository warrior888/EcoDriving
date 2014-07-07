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
            var pros = test.getRootNode("Proszkowska - center", 32.5, 10.5);

            var niem = test.getRootNode(pros, "Niemodlinska - proszkowska", 32.8, 10.9);
            var spych = test.getRootNode(niem, "Spychalskiego - niemodlinska", 32.1, 10.4);
            var krapk = test.getRootNode(spych, "Krapkowicka - spychalskiego", 33, 10.7);
            var krapkniem = test.getRootNode(niem, "Krapkowicka - niemodlinska", 33.2, 10.5);
            var krapkpros = test.getRootNode(pros,"proszkowska - krapkowicka", 33,10.3);
            var wroc = test.getRootNode(niem, "Wroclawska", 32.9, 11.1);
        }
    }
}
