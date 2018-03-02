
import sys

class StrongPassword(object):
    """Strong password from hacker hank"""
    def __init___(self):
        pass

    def minimumNumber(self, password):
        total = 0

        total += 0 if any(c.isdigit() for c in password) else 1
        total += 0 if any(c.islower() for c in password) else 1
        total += 0 if any(c.isupper() for c in password ) else 1       
        total += 0 if any(c in "!@#$%^&*()-+" for c in password ) else 1 

        if (len(password) + total < 6):
            total += 6 - (len(password) + total)

        return total

    def process(self):
        password = input().strip()
        answer = self.minimumNumber(password)
        print(answer)

    def __del__(self):
        pass


