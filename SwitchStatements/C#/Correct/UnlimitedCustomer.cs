namespace SwitchStatements
{
    public class UnlimitedCustomer : Customer
    {
        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var monthlyStatement = new MonthlyStatement();

            monthlyStatement.TotalCost = 54.90f;

            return monthlyStatement;
        }
    }
}