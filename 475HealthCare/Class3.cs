namespace _475HealthCare
{
    class ObamaCare : HealthPlan
    {
        static private string planType;
        static private int annualCharge;
        static private int deductionAmount;
        public override string GetPlan()
        {
            return planType;
        }

        public ObamaCare(int annualCharge1, int deductionAmount1)
        {
            planType = "Obama Care";
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
