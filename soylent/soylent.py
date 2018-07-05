import math
n = int(input())  # take first integer
calories = [int(input()) for _ in range(n)]  # put every test case in list and convert to int
print("\n".join([str(math.ceil(x/400)) for x in calories]))  # print the string version after you have divided and rounded.