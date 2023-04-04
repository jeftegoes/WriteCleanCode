import datetime


class CustomTime:
    def __init__(self) -> None:
        pass

    @staticmethod
    def parse(self, string: str) -> datetime.time:
        if (not string):
            raise Exception()
        
        hours: int = 0
        minutes: int = 0

        try:
            time_string: int = int(string.replace(":", ""))
            hours = int(time_string / 100)
            minutes = int(time_string % 100)
        except:
            raise Exception()

        return datetime.time(minute=minutes, hour=hours)
