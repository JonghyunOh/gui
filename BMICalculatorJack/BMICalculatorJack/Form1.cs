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

            ValidationFigures(unitFlag, height, weight);
            
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
                this.resultBox.ForeColor = Color.Red;
            } else if (result >= 25.0f && result <= 29.9) {
                resultStr = "Overwieight";
                this.resultBox.ForeColor = Color.Orange;
            }
            else if (result >= 18.9f && result <=29.9)
            {
                resultStr = "Normal";
                this.resultBox.ForeColor = Color.Green;
            }
            else
            {
                resultStr = "Underweight";
                this.resultBox.ForeColor = Color.Gray;
            }

                this.resultBox.Text = "your figure is " + result + " and " + resultStr;
        }

        private void ValidationFigures(Boolean unit, float pHeight, float pWeight)
        {
            if (unit)
            {
                //imperial validation
                //over than 4ft, cannot be less than 70 pounds,
                //it supposed to be kg.
                if (pHeight > 4.0f && pWeight < 70.0f)
                {
                    this.ImperialRadioBtn.Checked = false;
                    this.metricRadioBtn.Checked = true;
                    this.weightBox.Text = "" + pWeight / 0.45f;
                }

            } else
            {
                //metric validation
                //120cm person cannot be over than 400kg,
                //it supposed to be pounds.
                if (pHeight > 120 && pWeight > 400)
                {
                    this.ImperialRadioBtn.Checked = true;
                    this.metricRadioBtn.Checked = false;
                    this.weightBox.Text = "" + pWeight * 0.45f;
                }
            }
        }

        
    }
}
