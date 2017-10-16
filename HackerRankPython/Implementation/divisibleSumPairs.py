

import sys

class DivisibleSumPairs():    
    def __init__(self):
        pass

    def processDivisibleSumPairs(self, n, k, ar):                
        total = 0 
    
        for i in range(0, len(ar)):
            for j in range(i+1,len(ar)):
                if (ar[i] + ar[j]) % k == 0:
                    total += 1
                
        return total
        

    def process(self):
        n, k = input().strip().split(' ')
        n, k = [int(n), int(k)]
        ar = list(map(int, input().strip().split(' ')))
        result = self.processDivisibleSumPairs(n, k, ar)
        print(result)

    def __del__(self):
        pass
