
import sys

class BreakingRecords():    
    def __init__(self):
        pass

    def processBreakingRecords(self, s):                
        countHigherRecord = 0
        countLowerRecord = 0
        lastHigherRecord = s[0]
        lastLowerRecord = s[0]
    
        for item in s:
            if item > lastHigherRecord:
                lastHigherRecord = item
                countHigherRecord += 1
            
            if item < lastLowerRecord:
                lastLowerRecord = item
                countLowerRecord += 1
    
    
        return ( countHigherRecord, countLowerRecord)
        

    def process(self):
        n = int(input().strip())
        s = list(map(int, input().strip().split(' ')))
        result = self.processBreakingRecords(s)
        print (" ".join(map(str, result)))

    def __del__(self):
        pass
