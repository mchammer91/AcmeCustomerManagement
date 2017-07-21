using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    using System.Diagnostics.Eventing.Reader;

    using Core.Common;

    public class Customer
    {
        public int CustomerId { get; set; }

        public string EmailAddress { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public OperationResult ValidateEmail()
        {
            OperationResult op = new OperationResult();
            if (string.IsNullOrWhiteSpace(this.EmailAddress))
            {
                op.Success = false;
                op.AddMessage("Email address is null");
            }

            if (op.Success)
            {
                bool isValidFormat = true;
                // code to validate format of the email
                if (!isValidFormat)
                {
                    op.AddMessage("Email address is not in a correct format");
                }
            }

            if (op.Success)
            {
                bool isRealDomain = true;
                // code to validate domain of the email
                if (!isRealDomain)
                {
                    op.AddMessage("Email address does not include a valid domain");
                }
            }
            
            return op;
        }

        public decimal CalculatePercentOfGoalSteps(string goalSteps, string actualSteps)
        {

            if (string.IsNullOrWhiteSpace(goalSteps)) throw new ArgumentException("Goal steps must be entered", goalSteps);
            if (string.IsNullOrWhiteSpace(actualSteps)) throw new ArgumentException("Goal steps must be entered", actualSteps);

            decimal goalStepCount = 0;
            if (!decimal.TryParse(goalSteps, out goalStepCount)) throw new ArgumentException("Goal steps must be numeric", goalSteps);

            decimal actualStepCount = 0;
            if (!decimal.TryParse(actualSteps, out actualStepCount)) throw new ArgumentException("Actual steps must be numeric", actualSteps);

            return CalculatePercentOfGoalSteps(goalStepCount, actualStepCount);
        }

        public decimal CalculatePercentOfGoalSteps(decimal goalSteps, decimal actualSteps)
        {
            if (goalSteps <= 0) throw new ArgumentException("Goal steps must be greater than 0", goalSteps.ToString());
            return (actualSteps / goalSteps) * 100;
        }
    }
}
