import math

n = eval(input("Enter the total number of elements to Permutations:"))
M = eval(input("input an unrank number:"))
pai_list = [0 for j in range(0, n + 1)]
# for j in range(1, n + 1):
#     pai_list[j] = 0
P = M
for j in range(n, 0, -1):
    R = P % j
    P = math.floor(P / j)               # compute the largest integer not greater than P/j
    if P % 2 == 1:
        k = 0
        Dir = 1
    else:
        k = n + 1
        Dir = -1
    C = 0
    while C != R + 1:
        k += Dir
        if pai_list[k] == 0:
            C += 1
    pai_list[k] = j
un_rank = pai_list
print(un_rank)
