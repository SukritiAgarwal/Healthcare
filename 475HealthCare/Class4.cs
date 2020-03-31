namespace _475HealthCare
{
    class PPO : HealthPlan
    {
        static private string planType;
        static private int annualCharge;
        static private int deductionAmount;
        public override string GetPlan()
        {
            return planType;
        }

        public PPO(int annualCharge1, int deductionAmount1)
        {
            planType = "PPO";
            annualCharge = annualCharge1;
            deductionAmount = deductionAmount1;
        }

        public override int getAnnualCharge()
        {
            return annualCharge;
        }
        public override int getDeductionAmount()
        {
            return deductionAmount;
        }
    }
}
