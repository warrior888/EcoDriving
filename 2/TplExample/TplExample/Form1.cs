using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TplExample
{
    public partial class Form1 : Form
    {
        private static object _lock = new object();

        private int hitsNumber;

        private int _itemToFind;

        private delegate void SetTextCallback(string text);

        public Form1()
        {
            InitializeComponent();

            itemsNumber.Text = "128000";
            threadsNumber.Text = "64";
            rangeFrom.Text = "1";
            rangeTo.Text = "16";
            toFind.Text = "8";

            _itemToFind = 8;
        }

        private void go_Click(object sender, EventArgs e)
        {
            int itemsNmb;
            int threadsNmb;
            int rangeFrm;
            int rangeT;

            int.TryParse(itemsNumber.Text, out itemsNmb);
            int.TryParse(threadsNumber.Text, out threadsNmb);
            int.TryParse(rangeFrom.Text, out rangeFrm);
            int.TryParse(rangeTo.Text, out rangeT);
            int.TryParse(toFind.Text, out _itemToFind);


            List<int> randomItems = new List<int>(itemsNmb);
            Random r = new Random(DateTime.Now.Millisecond);


            for (int i = 0; i < itemsNmb; i++)
            {
                randomItems.Add(r.Next(rangeFrm, rangeT));
            }

            hitsNumber = 0;

            randomItems.AsParallel().
                WithDegreeOfParallelism(threadsNmb).
                ForAll(HitTest);
        }

        private void HitTest(int candidate)
        {
            lock (_lock)
            {
                if (candidate == this._itemToFind)
                {

                    hitsNumber++;

                    //countFinds.Text = 
                    // 

                }
            }

            Set(hitsNumber.ToString());
        }

        private void Set(string text)
        {
            if (this.countFinds.InvokeRequired)
            {
                SetTextCallback d = Set;
                this.Invoke(d, new object[] {text});
            }
            else
            {
                this.countFinds.Text = text;
            }
        }
    }
}
