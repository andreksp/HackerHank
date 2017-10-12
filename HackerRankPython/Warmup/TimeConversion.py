#!/bin/python3

import sys
from datetime import datetime

def timeConversion(s):
    format = '%I:%M:%S%p'
    return datetime.strptime(s, format).strftime('%H:%M:%S')

s = input().strip()
result = timeConversion(s)
print(result)
