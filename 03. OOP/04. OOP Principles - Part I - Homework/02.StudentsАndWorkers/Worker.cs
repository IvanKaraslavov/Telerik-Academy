namespace StudentsАndWorkers
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Enter a positive number");
                }
                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Enter a positive number");
                }
                this.workHoursPerDay = value;
            }
        }
        public decimal MoneyPerHour()
        {
            return this.WeekSalary / (5 *  this.WorkHoursPerDay); 
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Worker's first name: {0}\n", this.FirstName);
            sb.AppendFormat("Worker's last name: {0}\n", this.LastName);
            sb.AppendFormat("Worker's week salary: {0}\n", this.WeekSalary);
            sb.AppendFormat("Worker's work hours per day: {0}\n", this.WorkHoursPerDay);
            sb.AppendFormat("Worker's money per day: {0:F2}\n", MoneyPerHour());
            return sb.ToString();
        }
    }
}
