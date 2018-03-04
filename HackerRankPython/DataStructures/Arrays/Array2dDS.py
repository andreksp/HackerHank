import sys

class Array2dDS(object):
    """count the hourglasses"""

    def __init__(self):
        pass

    def process2DArrayDS(self, arr):
        maxHourglass = -sys.maxsize -1

        for i in range(0, len(arr) - 2):
            for j in range(0, len(arr) - 2):
                hCSum = sum([arr[i][j+z] for z in range(0, 3)]) + \
                            arr[i + 1][j + 1] + \
                            sum([arr[i+2][j+h] for h in range(0, 3)])

                if hCSum > maxHourglass:
                    maxHourglass = hCSum

        return maxHourglass


    def process(self):
        arr = []
        for arr_i in range(6):
           arr_t = [int(arr_temp) for arr_temp in input().strip().split(' ')]
           arr.append(arr_t)

        print(self.process2DArrayDS(arr));


