class BaseSort():
    def Swap(self, mylist, i, j):
        temp = mylist[i]
        mylist[i] = mylist[j]
        mylist[j] = temp

class BubbleSort(BaseSort):
    def __init__(self):
        self.__content = "a"
        pass

    #Complexity C(n) = O(n²)
    def run(self):
        myList = [4,8,2,6,1,0,3,7,9]
        temp = 0

        for i in range(0, len(myList)):
            for j in range(0, len(myList) - 1):
                if (myList[j] > myList[j + 1]):
                    self.Swap(myList, j, j+1)

        print(myList)

class SelectionSort(BaseSort):
    def __init__(self):
        pass

    #Complexity C(n) = O(n²)
    def run(self):
        myList = [4,8,2,6,1,0,3,7,9]
        temp = 0

        for i in range(0, len(myList) - 1):
            for j in range(i + 1, len(myList)):
                if (myList[i] > myList[j]):
                    self.Swap(myList, j, i)

        print(myList)

class InsertSort(BaseSort):
    def __init__(self):
        pass
    #Possui complexidade C(n) = O(n) no melhor caso e C(n) = O(n²)
    def run(self):
        myList = [4,8,2,6,1,0,3,7,9]
        temp = 0
        j = 0
        
        for i in range(1, len(myList)):
            if (myList[i] < myList[i - 1]):
                temp = myList[i]
                
                for j in range(i,-1,-1):
                    if (myList[j - 1] > temp):
                        myList[j] = myList[j - 1]
                    else:
                        break
                myList[j] = temp
        print(myList)                        
                                
        

class QuickSort(BaseSort):
    def __init__(self):
        pass
    ###Possui complexidade Avg Case: C(n) = O(n log n)  Worst Case: n²
    #https://www.youtube.com/watch?v=SLauY6PpjW4
    ###
    def quickSort(self, myList, left, right):
        
        i = left
        j = right
        
        pivot = myList[(left+right)//2]

        while (i <= j):
            while myList[i] < pivot:
                i += 1
            while myList[j] > pivot:
                j -= 1
 
            if i <= j:
                self.Swap(myList, j, i)

                i += 1
                j -= 1

            if (left < j):
                self.quickSort(myList, left, j)

            if (i < right):
                self.quickSort(myList, i, right)


    def run(self):
        myList = [15,3,2,1,9,5,7,8,6]
        temp = 0
        j = 0

        self.quickSort(myList, 0, len(myList) - 1)

        print(myList)                        
                                
        
class MergeSort():
    def __init__(self):
        pass
    #Possui complexidade C(n) = O(n log n)
    def run(self):
        myList = [4,8,2,6,1,0,3,7,9]
        print(self.mergesort(myList))

        
    def merge(self, a,b):
        """ Function to merge two arrays """
        c = []
        while len(a) != 0 and len(b) != 0:
            if a[0] < b[0]:
                c.append(a[0])
                a.remove(a[0])
            else:
                c.append(b[0])
                b.remove(b[0])
        if len(a) == 0:
            c += b
        else:
            c += a
        return c

    # Code for merge sort
    def mergesort(self, x):
        """ Function to sort an array using merge sort algorithm """
        if len(x) == 0 or len(x) == 1:
            return x
        else:
            middle = len(x)//2
            a = self.mergesort(x[:middle])
            b = self.mergesort(x[middle:])
            return self.merge(a,b)

        print(myList)                        
                                
        



"""

from Sort import *

b =  InsertSort()
b.run()



b =  SelectionSort()
b.run()

b =  QuickSort()
b.run()


b =  BubbleSort()
c = b._BubbleSort__content
b.run()

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

