#!/bin/python3

import sys

arr = list(map(int, input().strip().split(' ')))

a = sum(sorted(arr)[:4])
b = sum(sorted(arr, reverse=True)[:4])

print (str(a) + " " + str(b))
        
