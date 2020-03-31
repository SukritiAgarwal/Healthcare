using System;

namespace _475HealthCare {
    class Factory {
        public static void Main(String[] args) {
            Console.WriteLine("Health Care Plan:");
            Console.WriteLine("Choose the Health care plan that you want to apply:");
            Console.WriteLine("1. HMO");
            Console.WriteLine("2. PPO");
            Console.WriteLine("3. Obama Care");
            Console.WriteLine("Choose your option and press enter");
            int userInput = Convert.ToInt32(Console.ReadLine());
            HealthPlan plan = null;
            switch (userInput){
                case 1:
                    plan = NewHMO();
                    Console.WriteLine($"The plan you chose is {plan.GetPlan()}");
                    Console.WriteLine($"The annual charge would be { plan.getAnnualCharge()}.");
                    Console.WriteLine($"The deduction amount would be {plan.getDeductionAmount()}.");
                    break;
                case 2:
                    plan = NewPPO();
                    Console.WriteLine($"The plan you chose is {plan.GetPlan()}");
                    Console.WriteLine($"The annual charge would be {plan.getAnnualCharge()}.");
                    Console.WriteLine($"The deduction amount would be {plan.getDeductionAmount()}.");
                    break;
                case 3:
                    plan = NewObamaCare();
                    Console.WriteLine($"The plan you chose is {plan.GetPlan()}");
                    Console.WriteLine($"The annual charge would be {plan.getAnnualCharge()}.");
                    Console.WriteLine($"The deduction amount would be {plan.getDeductionAmount()}.");
                    break;
                default:
                    break;
            }
            Console.WriteLine("Thank you!");
        }
        public static HMO NewHMO()        {
            return new HMO(1000, 99);
        }

        public static PPO NewPPO()        {
            return new PPO(9999, 100);
        }

        public static ObamaCare NewObamaCare()        {
            return new ObamaCare(1999, 600);
        }
    }
}