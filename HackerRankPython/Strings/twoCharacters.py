

import sys

class TwoCharacters():    
    def __init__(self):
        pass

    def processTwoCharacters(self, s):                
        newString = ""

        for i in range(0, len(s)):
            for j in range(i+1, len(s)):
                temp = self.RemoveChars(s[i], s[j], s)
        
                if (len(temp) > len(newString)):
                    newString = temp

        return newString

    def RemoveChars(self, c1, c2, s):    
        newString = ""
        lastChar = ' '
    
        for i in range(0, len(s)):
            if s[i] == c1 or s[i] == c2:
                if s[i] == lastChar:
                    return ""
                newString += s[i]
                lastChar = s[i];
        
        return newString  

    def process(self):
        s = input().strip()

        newString = self.processTwoCharacters(s)

        print(len(newString))

    def __del__(self):
        pass
