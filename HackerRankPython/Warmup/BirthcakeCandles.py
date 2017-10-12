#!/bin/python3

import sys

def birthdayCakeCandles(n, ar):
    maxi = max(ar);
    return len([x for x in ar if x == maxi])

n = int(input().strip())
ar = list(map(int, input().strip().split(' ')))
result = birthdayCakeCandles(n, ar)
print(result)
