from customer import Customer
from customer_pay_as_you_go import CustomerPayAsYouGo
from customer_type import CustomerType
from customer_unlimited import CustomerUnlimited
from monthly_usage import MonthlyUsage


class MonthlyStatementFactory:
    def __init__(self) -> None:
        pass

    def generate(self, customer_type: CustomerType) -> Customer:
        if (customer_type == CustomerType.PAY_AS_YOU_GO):
            return CustomerPayAsYouGo()
        elif (customer_type == CustomerType.UNLIMITED):
            return CustomerUnlimited()
        else:
            raise Exception("The current customer type is not supported")
