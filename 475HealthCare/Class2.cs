namespace _475HealthCare {
    class HMO : HealthPlan {
        private string planType;
        static private int annualCharge;
        static private int deductionAmount;
        public HMO(int annualCharge1, int deductionAmount1)        {
            planType = "HMO";
            annualCharge = annualCharge1;
            deductionAmount = deductionAmount1;
        }

        public override string GetPlan() {
            string plan = planType;
            return plan;
        }

        public override int getAnnualCharge() {
            return annualCharge;
        }
        public override int getDeductionAmount() {
            return deductionAmount;
        }
    }
}