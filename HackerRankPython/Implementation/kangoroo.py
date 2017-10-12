import sys

class Kangoroo():    
    def __init__(self):
        pass

    def processKangoroo(self, x1, v1, x2, v2):    
        if v1 < 0 or v2 < 0 or v1 > 10000 or v2 > 10000 or x1 < 0 or x1 > 10000 or x2 < 0 or x2 > 10000:
            return "NO"
        lastDistance = abs(x1 - x2)

        while x1 < sys.maxsize:
            x1 = x1 + v1
            x2 = x2 + v2

            if abs(x1 - x2) >= lastDistance:
                return "NO"
            else:
                lastDistance = abs(x1 - x2)

            if (x1 == x2):
                return "YES"

        return "NO"

    def process(self):
        x1, v1, x2, v2 = input().strip().split(' ')
        x1, v1, x2, v2 = [int(x1), int(v1), int(x2), int(v2)]
        result = self.processKangoroo(x1, v1, x2, v2)
        print(result);

    def __del__(self):
        pass
