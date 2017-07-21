using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACM.Win
{
    using BL;
    public partial class PedometerWin : Form
    {
        public PedometerWin()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            var result = customer.CalculatePercentOfGoalSteps(this.GoalTextBox.Text, this.StepsTextBox.Text);

            this.ResultLabel.Text = "You reached " + result + " % of your goal";
        }
    }
}
