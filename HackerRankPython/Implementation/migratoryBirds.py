import sys
from collections import OrderedDict

class MigratoryBirds():    
    def __init__(self):
        pass

    def processMigratoryBirds(self, n, ar): 
        total = dict()
        for item in ar:
            if not item in total:
                total[item] = 0

            total[item] += 1
        
        listSorteByValueDesc = sorted(total.items(), key=lambda t: t[1], reverse=True)

        kMax, vMax = listSorteByValueDesc[0]

        filteredList = {k:v for (k,v) in total.items() if v == vMax}

        modaKeyPair = sorted(filteredList.items(), key=lambda t: t[0])

        k1, v1 = modaKeyPair[0]

        return k1;

    def process(self):
        n = int(input().strip())
        ar = list(map(int, input().strip().split(' ')))
        result = self.processMigratoryBirds(n, ar)
        print(result)


    def __del__(self):
        pass
