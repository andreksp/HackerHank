

import sys

class BonAppetit():    
    def __init__(self):
        pass

    def processBonAppetit(self, n, k, b, ar):                
        sum = 0
    
        for i in range(0, len(ar)):
            if i != k:
                sum += ar[i]
            
        bActual = sum / 2 
        rest = b - bActual
    
        return int(rest);

    def process(self):
        n, k = input().strip().split(' ')
        n, k = [int(n), int(k)]
        ar = list(map(int, input().strip().split(' ')))
        b = int(input().strip())
        result = bonAppetit(n, k, b, ar)
        if  result != 0:
            print(result)
        else:
            print("Bon Appetit")

    def __del__(self):
        pass
