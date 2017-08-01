using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMICalculatorJack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            float height = 0.0f;
            float weight = 0.0f;
            float result = 0.0f;

            height = float.Parse(this.heightBox.Text);
            weight = float.Parse(this.weightBox.Text);

            Boolean unitFlag = this.ImperialRadioBtn.Checked;
            
            if (unitFlag)
            {
                //Imperial
                result = (weight * 703) / ((height*12) * (height*12));
            }else
            {
                //Metric
                result = (weight) / ((height/100) * (height/100));
            }
            this.resultLabel.Text = "Result\n" + result;
        }
    }
}
