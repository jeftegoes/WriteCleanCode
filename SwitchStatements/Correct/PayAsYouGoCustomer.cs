namespace SwitchStatements
{
    public class PayAsYouGoCustomer : Customer
    {
        public override MonthlyStatement GenerateStatement(MonthlyUsage monthlyUsage)
        {
            var monthlyStatement = new MonthlyStatement();

            monthlyStatement.CallCost = 0.12f * monthlyUsage.CallMinutes;
            monthlyStatement.SmsCost = 0.12f * monthlyUsage.SmsCount;
            monthlyStatement.TotalCost = monthlyStatement.CallCost + monthlyStatement.SmsCost;

            return monthlyStatement;
        }
    }
}