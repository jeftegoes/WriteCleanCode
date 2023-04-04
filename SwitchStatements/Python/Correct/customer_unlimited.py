from customer import Customer
from monthly_statement import MonthlyStatement
from monthly_usage import MonthlyUsage


class CustomerUnlimited(Customer):
    def generate_statement(self, monthly_usage: MonthlyUsage) -> MonthlyStatement:
        return MonthlyStatement(0, 0, 54.90)