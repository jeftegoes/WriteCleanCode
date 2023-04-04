from customer_type import CustomerType
from monthly_usage import MonthlyUsage


class MonthlyStatement:
    def __init__(self, call_cost = 0, sms_cost = 0, total_cost = 0) -> None:
        self.call_cost: float = call_cost
        self.sms_cost: float = sms_cost
        self.total_cost: float = total_cost