from abc import ABC, abstractmethod
from monthly_statement import MonthlyStatement

from monthly_usage import MonthlyUsage

class Customer(ABC):
    @abstractmethod
    def generate_statement(self, monthly_usage: MonthlyUsage) -> MonthlyStatement:
        pass
    