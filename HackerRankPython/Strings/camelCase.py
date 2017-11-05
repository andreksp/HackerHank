
import sys

class CamelCase():    
    def __init__(self):
        pass

    def processCamelCase(self, s):                
        total = 1

        for c in range(0, len(s)):
            total += 1 if (ord(s[c]) < 96) else 0

        return total;


    def process(self):  
        s = input().strip()
        result = self.processCamelCase(s)
        print(result)

    def __del__(self):
        pass
