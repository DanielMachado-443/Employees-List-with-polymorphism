
namespace Section10_Exercicio1.Entities
{
    class OutsourceEmployee : Employee
    {
        public double AdditionalCharge { get; set; }

        public OutsourceEmployee()
        {
        }

        public OutsourceEmployee(string name, int hours, double valuePerHour, double additionalCharge) 
            : base(name, hours, valuePerHour)
        {
            AdditionalCharge = additionalCharge;
        }

        public override double Payment()
        {
            double OutsourcedPayment = base.Payment();           
            OutsourcedPayment += AdditionalCharge * 1.1;

            // return base.Payment() + 1.1 * AdditionalCharge;  <<< it could've been writen this way

            return OutsourcedPayment;
        }

    }
}
