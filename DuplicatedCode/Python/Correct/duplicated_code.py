import datetime
from custom_time import CustomTime


class DuplicatedCode:
    def __init__(self) -> None:
        pass

    def admit_guest(self, name: str, admission_datetime: str):
        time: datetime.time = CustomTime.parse(admission_datetime)

        if (time.hour < 10):
            pass


    def update_admission(self, admission_id: int, name: str, admission_datetime: str):
        time: datetime.time = CustomTime.parse(admission_datetime)

        if (time.hour < 10):
            pass
