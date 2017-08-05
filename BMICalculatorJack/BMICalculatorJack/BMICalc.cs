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
    public partial class BMICalc : Form
    {
        public BMICalc()
        {
            InitializeComponent();
            this.ImperialRadioBtn.Checked = true;
            this.metricRadioBtn.Checked = false;
            this.resultBox.Text = "Hi!";
        }


        private void submitButton_Click(object sender, EventArgs e)
        {
            float height = 0.0f;
            float weight = 0.0f;
            float result = 0.0f;
            

            Boolean unitFlag = this.ImperialRadioBtn.Checked;

            Boolean valid = ValidationNumbers(out height, out weight);

            if (valid)
            {
                result = calculation(unitFlag, height, weight);
                displayResult(result);
            }
            
        }



        private Boolean ValidationNumbers(out float height, out float weight)
        {
            Boolean result = false;

            try
            {
                height = float.Parse(this.heightBox.Text);
                weight = float.Parse(this.weightBox.Text);
                result = true;
            }
            catch(Exception e)
            {
                height = 0.0f;
                weight = 0.0f;
                this.heightBox.Text = "";
                this.weightBox.Text = "";
                this.resultBox.Text = e.Message;
            }

            return result;

        }



        private float calculation(Boolean unitFlag, float pheight, float pweight)
        {
            float result = 0.0f;

            try
            {
                if (unitFlag)
                {
                    //Imperial
                    result = (pweight * 703) / ((pheight * 12) * (pheight * 12));
                }
                else
                {
                    //Metric
                    result = (pweight) / ((pheight / 100) * (pheight / 100));
                }

            }catch(Exception e)
            {
                this.resultBox.Text = e.Message;
            }

            return result;
            
        }



        private void displayResult(float result)
        {

            string resultStr = "";
            if (result >= 30.0f)
            {
                resultStr = "Obese";
                this.resultBox.ForeColor = Color.Red;
            }
            else if (result >= 25.0f && result <= 29.9)
            {
                resultStr = "Overwieight";
                this.resultBox.ForeColor = Color.Orange;
            }
            else if (result >= 18.9f && result <= 29.9)
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

        private void metricRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            float hBox = 0.0f;
            float wBox = 0.0f;

            Boolean valid = ValidationNumbers(out hBox, out wBox);

            if (valid && this.metricRadioBtn.Checked)
            {
                string temp = "" + (hBox / 0.0328);
                if(temp.Length > 8)
                {
                    temp = temp.Substring(0, 8);
                }               
                this.heightBox.Text = temp;

                temp = "" + (wBox / 2.20462);
                if (temp.Length > 8)
                {
                    temp = temp.Substring(0, 8);
                }
                this.weightBox.Text = temp ;
            }
        }

        private void ImperialRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            float hBox = 0.0f;
            float wBox = 0.0f;  

            Boolean valid = ValidationNumbers(out hBox, out wBox);

            if (valid && this.ImperialRadioBtn.Checked)
            {
                string temp = "" + (hBox * 0.0328);
                if (temp.Length > 8)
                {
                    temp = temp.Substring(0, 8);
                }
                this.heightBox.Text = temp;

                temp = "" + (wBox * 2.20462);
                if (temp.Length > 8)
                {
                    temp = temp.Substring(0, 8);
                }
                this.weightBox.Text = temp;
            }
        }
    }
}
