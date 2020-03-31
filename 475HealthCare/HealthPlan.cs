using System;

namespace _475HealthCare
{
    abstract class HealthPlan
    {
        public abstract string GetPlan();
        public abstract int getAnnualCharge();
        public abstract int getDeductionAmount();

    }
}
