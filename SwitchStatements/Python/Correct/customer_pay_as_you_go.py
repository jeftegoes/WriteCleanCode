from customer import Customer
from monthly_statement import MonthlyStatement
from monthly_usage import MonthlyUsage


class CustomerPayAsYouGo(Customer):
    def generate_statement(self, monthly_usage: MonthlyUsage) -> MonthlyStatement:
        call_cost = 0.12 * monthly_usage.call_minutes
        sms_cost = 0.12 * monthly_usage.sms_count
        total_cost = call_cost + sms_cost
        
        return MonthlyStatement(call_cost, sms_cost, total_cost)