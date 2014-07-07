using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator
{
    public partial class Form1 : Form
    {
        /*private Dictionary<string, Func<double, double, double>> calculations = new Dictionary<string, Func<double, double, double>>
        {
            { "+", (a,b) => (a + b) },
            { "-", (a,b) => (a - b) },
            { "*", (a,b) => (a * b) },
            { "/", (a,b) => (a / b) },
        };*/

        private Dictionary<string, Func<double, double, double>> calculations = new Dictionary<string, Func<double, double, double>>
        {
            { "+", (a,b) => a.Add(b) },
            { "-", (a,b) => a.Subtract(b) },
            { "*", (a,b) => a.Multiply(b) },
            { "/", (a,b) => a.Divide(b) },
        };

        public Form1()
        {
            InitializeComponent();
        }

        private void calcSubmit_Click(object sender, EventArgs e)
        {
            var phrase = calc.Text;

            var split = phrase.Split(' ');

            double arg1;
            double arg2;

            // ładnie w forze
            // priorytety dzialan - mnozenie szybciej niz dodawanie

            double.TryParse(split[0], out arg1);
            double.TryParse(split[2], out arg2);

            string sign = split[1];

            double result;

            if (calculations.ContainsKey(sign))
            {
                // potrafimy obsluzyc operacje
                result = calculations[sign](arg1, arg2);

                wynik.Text = result.ToString();
            }
        }
    }
}
