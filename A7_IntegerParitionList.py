import math
n = eval(input("Enter the total number of elements to Permutations:"))
Pn = [0 for i in range(0, n)]
Mn = [0 for i in range(0, n)]
# partition_lamuda = 4
Pn[0], Mn[0], r = n, 1, 0
Flag_Done = False
while not Flag_Done:
    print(Pn, Mn)
    if Pn[r] > 1 or r > 0:
        if Pn[r] == 1:                  # judge Pn[r]
            s = Pn[r - 1] + Mn[r]
            k = r - 1
        else:
            s = Pn[r]                   #
            k = r
        w = Pn[k] - 1
        u = math.floor(s / w)
        v = s % w
        Mn[k] -= 1
        if Mn[k] == 0:
            k1 = k
        else:
            k1 = k + 1
        Mn[k1] = u
        Pn[k1] = w
        if v == 0:
            r = k1
        else:
            Mn[k1 + 1] = 1
            Pn[k1 + 1] = v
            r = k1 + 1
    else:
        Flag_Done = True

