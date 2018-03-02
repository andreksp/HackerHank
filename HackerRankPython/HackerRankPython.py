#!/bin/python

import sys
from Implementation.kangoroo import Kangoroo
from Implementation.breakingRecords import BreakingRecords
from Implementation.birthDayChocolate import BirthdayChocolate
from Implementation.divisibleSumPairs import DivisibleSumPairs
from Implementation.migratoryBirds import MigratoryBirds
from Implementation.dayOfTheProgrammer import DayOfTheProgrammer
from Strings.superReducedString import SuperReducedString
from Strings.camelCase import CamelCase
from Strings.twoCharacters import TwoCharacters
from Strings.strongPassword import StrongPassword
#k = Kangoroo()

#k.process()

#TwoCharacters().process()

s = StrongPassword()
s.process()

from Sort import *
"""
b =  InsertSort()
b.run()



b =  SelectionSort()
b.run()

b =  QuickSort()
b.run()
"""

b =  BubbleSort()
c = b._BubbleSort__content
b.run()

"""
m = lambda x,y: x ** y
print ([(lambda x,y: x ** y)(i,2) for i in range(10)])

print(list(map(lambda x: x // 2, [1,2,3,4,5,6])))
print( [(lambda x,y: x // y)(i,2) for i in range(7) if i > 0 ])


print (list(filter(lambda x: x % 2 == 0, [1,2,3,4,5,6])))
"""

"""
b =  MergeSort()
b.run()

"""