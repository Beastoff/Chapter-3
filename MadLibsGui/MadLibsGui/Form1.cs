using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGui
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Color2_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtPickNum1.Text) - Convert.ToDouble(txtPickNum2.Text);

            label9.Text = "The " + txtColor.Text + " Dragon is the " + txtWordEST.Text +
                " Dragon of all. It has " + num + " " + txtBodyPartPlural.Text +
                ", and a " + txtAnimal.Text + " shaped like a " + txtNoun.Text +
                ", although it will feast on nearly anything.";
        }
    }
}
