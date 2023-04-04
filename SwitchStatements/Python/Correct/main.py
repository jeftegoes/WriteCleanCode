from customer import Customer
from customer_type import CustomerType
from monthly_statement_factory import MonthlyStatementFactory
from monthly_usage import MonthlyUsage


factory = MonthlyStatementFactory()
customer = factory.generate(CustomerType.PAY_AS_YOU_GO)
customer.generate_statement()