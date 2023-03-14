import datetime

from customer import Customer


class Reservation:
    def __init__(self, customer: Customer, date_time: datetime) -> None:
        self.customer = customer
        self.date_time = date_time
        self.is_canceled: bool = False

    def cancel(self) -> bool:
        MESSAGE_ERROR = "It's too late to cancel."
        
        if (self.is_cancellation_period_over()):
            raise Exception(MESSAGE_ERROR)
            
        self.is_canceled = True
    
    def is_cancellation_period_over(self):
        return (self.customer.IsGoldCustomer() and self.less_than(24) or
                not self.customer.IsGoldCustomer() and self.less_than(48))
    
    def less_than(self, maxHours):
        return ((self.date_time - datetime.now()).TotalHours < maxHours)
    