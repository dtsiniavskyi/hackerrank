import math
import os
import random
import re
import sys

def isWeird(n):
    if n%2==1 or (n%2==0 and 6 <= n <=20):
        return True
    
    if n%2==0 and (2 <= n <=5 or n>20):
        return False
    
    return False

n = int(input().strip())
if isWeird(n):
    print('Weird')
else:
    print('Not Weird')