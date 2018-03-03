import sys

class ArrayDS(object):
    """description of class"""

    def __init__(self):
        pass

    def processArrayDS(self, vector):
        print(*vector[::-1])


    def process(self):
        arr = [int(arr_temp) for arr_temp in input().strip().split(' ')]

        print(self.processArrayDS(arr))

    def __del__(self):
        pass