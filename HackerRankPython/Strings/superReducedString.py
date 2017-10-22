
import sys

class SuperReducedString():    
    def __init__(self):
        pass

    def processSuperReducedString(self, s):                
        i = 0

        while i < len(s) -1:
            if s[i] == s[i + 1]:
                s = s[:i] + s[i+2:]
                i = 0
            else:
                i += 1

        if s == "":
            return "Empty String"
        else:
            return s

    def process(self):
        s = input().strip()
        result = self.processSuperReducedString(s)
        print(result)

    def __del__(self):
        pass
