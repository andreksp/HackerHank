
import sys
import calendar
from datetime import datetime

class DayOfTheProgrammer():    
    def __init__(self):
        pass

    def processDayOfTheProgrammer(self, year):    
        total = 0;

        if year == 1918:        
            total -= 13        

        month = 1;

        for i in range(1, 12):
            m, daysInMonth = calendar.monthrange(year,i)

            if (i == 2 and year <= 1918):
                if (year % 4 == 0):
                    daysInMonth = 29
                else:
                    daysInMonth = 28

            if (total + daysInMonth > 256):
                break;

            month += 1
            total += daysInMonth;

        newDay = 256 - total;

        newDate = datetime(year, month, newDay, 00, 00)

        return newDate.strftime('%d.%m.%Y')

    def process(self):
        year = int(input().strip())
        result = self.processDayOfTheProgrammer(year)
        print(result)

    def __del__(self):
        pass
