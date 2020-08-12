using System.Text;

namespace Section10_Exercicio1.Entities
{
    class Employee
    {
        public string Name { get; set; }
        public int Hours { get; set; }
        public double ValuePerHour { get; set; }

        public Employee()
        {
        }

        public Employee(string name, int hours, double valuePerHour)
        {
            Name = name;
            Hours = hours;
            ValuePerHour = valuePerHour;
        }

        public virtual double Payment()
        {
            return Hours * ValuePerHour;
        }

        public override string ToString()
        {
            StringBuilder string1 = new StringBuilder();
            string1.AppendLine("\n\n   Employee info ");
            string1.Append("\n   Name: " + Name);
            string1.Append("\n   Hours of work: " + Hours);
            string1.Append("\n   Employee's value per hour: $" + ValuePerHour.ToString("F2"));
            if(this is OutsourceEmployee)
            {
                OutsourceEmployee thisEmployee = this as OutsourceEmployee; // DOWNCASTING FROM SUPERCLASS TO SUBCLASS object (OutsourceEmployee)
                double ChargeResult = thisEmployee.AdditionalCharge * 1.1;
                string1.Append("\n   Employee's earns as additional charge: $" + ChargeResult.ToString("F2"));
                string1.Append("\n   Payment: $" + Payment().ToString("F2"));
                string1.AppendLine();
                return string1.ToString();
            }
            else
            {
                string1.Append("\n   Payment: $" + Payment().ToString("F2"));
                string1.AppendLine();
                return string1.ToString();
            }            
        }
    }
}
