
#!/bin/python3

import sys

def palindromeIndex(s):   
    iTemp = ''
    rTemp = ''    
    
    for i in range(0, len(s)):
        r = len(s) - i - 1
        
        if i <= r:
            if s[i] != s[r]:

                for j in range(0, len(s)):
                    if j != i:
                        iTemp = iTemp + s[j]
                
                print(''.join(iTemp))
                if IsPalindrome(''.join(iTemp)):
                    return i
                
                for j in range(0, len(s)):
                    if j != i:
                        rTemp = rTemp + s[j]
                        
                if IsPalindrome(''.join(rTemp)):
                    return r

                
                
def IsPalindrome(s):
    for i in range(0, len(s)):
        r = len(s) - i - 1        
        if i <= r:
            if s[i] != s[r]:
                return False
        else:
            break
            
    return True
            

q = int(input().strip())
for a0 in range(q):
    s = input().strip()
    result = palindromeIndex(s)
    print(result)
