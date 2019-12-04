using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MadLibsGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double num;
            num = Convert.ToDouble(txtPickNum1) - Convert.ToDouble(txtPickNum2);

            lblResult.Text = "The " + txtColor.Text + "Dragon is the " + txtWordEst +
                " Dragon of all. It has " + num + " " + txtBodyPartPlural +
                ", and a " + txtAnimal.Text + " shaped like a " + txtNoun +
                ", although it will feast on nearly anything.";
            picDragon.Visible = true;
    }
}
