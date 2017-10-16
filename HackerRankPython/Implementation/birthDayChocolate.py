

import sys

class BirthdayChocolate():    
    def __init__(self):
        pass

    def processBirthdayChocolate(self, n, s, d, m):                
        sum = 0;
        total = 0
    
        for i in range(0, len(s)):
            sum = 0
        
            for j in range(i, min(len(s), i + m)):
                sum += s[j]
                if sum > d:
                    break
                
            if sum == d:
                total += 1
        return total
        

    def process(self):
        n = int(input().strip())
        s = list(map(int, input().strip().split(' ')))
        d, m = input().strip().split(' ')
        d, m = [int(d), int(m)]
        result = self.processBirthdayChocolate(n, s, d, m)
        print(result)

    def __del__(self):
        pass
