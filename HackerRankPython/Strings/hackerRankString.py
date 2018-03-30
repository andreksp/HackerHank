
import sys

class HackerRankString():    
    def __init__(self):
        pass

    def hackerrankInString(self, s):                
        target = "hackerrank"
        lastIndex = 0

        for i in range(0, len(target)):
            index = s.find(target[i], lastIndex)

            if index == -1:
                return "NO"

            lastIndex = index + 1

        return "YES"

    def hackerrankInString2(self, s):                
        target = "hackerrank"
        lastIndex = 0
        index = 0
        found = False

        for i in range(0, len(target)):

            found = False

            for j in range(lastIndex, len(s)):
                if target[i] == s[j]:
                    index = j
                    found = True
                    break

            if not found:
                return "NO"         
            
            lastIndex = index + 1;

        return "YES"

    def process(self):
        q = int(input().strip())
        for a0 in range(q):
            s = input().strip()
            result = self.hackerrankInString(s)
            print(result)

    def __del__(self):
        pass
