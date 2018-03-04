
class Node(object):
   def __init__(self, data=None, next_node=None):
       self.data = data
       self.next = next_node
 
class PrintElement(object):
    def print_list(head):
        temp = head
    
        while temp != None:
            print(temp.data)
            temp = temp.next
