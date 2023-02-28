# SubsetList

print("Note: n is total number, k is k-tuple.")
n = eval(input("PLZ input n:"))                     # e.g. n = 5
k = eval(input("PLZ input k:"))                     # e.g. k = 3
v_list = [0 for i in range(k + 1)]                  # INIT the v_list e.g. [0,0,0,0]
for i in range(k):
    v_list[i] = i + 1                               # INIT the v_list e.g. [1,2,3]
v_list[k] = n + 1                                   # INIT the v_list e.g. [1,2,3,6]
print("-------" + str(v_list) + "-----------" )
flag_done = False                                   # create a final flag
while not flag_done:
    print(v_list[0:k])                              # print the list  1st: [1,2,3]
    if v_list[0] < n - k + 1:                       # first element < n - k + 1 e.g. 1 < 5 - 3 + 1 = 3
        j = 0                                       # start loop
        while v_list[j + 1] <= v_list[j] + 1:       # When j = 2 v_list[2] = 3 but v_list[j + 1] = 6 no loop, continue
            j += 1
        v_list[j] += 1                              # In the list, The last - 1 position will + 1                   
        for g in range(j):                          
            v_list[g] = g + 1                       # INIT the list no use position
    else:
        flag_done = True










