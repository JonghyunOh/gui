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
            string resultStr = "";

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

            if (result >= 30.0f)
            {
                resultStr = "Obese";
            } else if (result >= 25.0f && result <= 29.9) {
                resultStr = "Overwieight";
            }
            else if (result >= 18.9f && result <=29.9)
            {
                resultStr = "Normal";
            }else
            {
                resultStr = "Underweight";
            }

                this.resultBox.Text = "your figure is " + result + " and " + resultStr;
        }
    }
}
