#Permutation

## INIT
origin = eval(input("please input a number:"))
origin_list = [i for i in range(origin + 2)]
pai_list = [i for i in range(origin + 2)]
pai_ni_list = [i for i in range(origin + 2)]
direction_list = [i for i in range(origin + 2)]   # Represent the direction
A_list = []
for i in range(1, origin + 2):
    pai_list[i] = i
    pai_ni_list[i] = i
    direction_list[i] = -1      # -1 represent left and 1 represent right
pai_list[0] = origin + 1
A_list = [i for i in range(2, origin + 1)]
# Represent Active digit : If a digit "i" comes to boundary it will be cleaned in A_list

## MAIN
Flag_Done = False
sum = 0
while not Flag_Done:
    sum += 1
    print(pai_list[1:origin + 1])           # Print the permutation
    if A_list:          # judge A_list is empty or not?
        m = max(A_list)             # Find the maximum position in the A_list（Active position）
        j = pai_ni_list[m]          # 3
        pai_list[j] = pai_list[j + direction_list[m]]
        pai_list[j + direction_list[m]] = m
        pai_ni_list[m] = pai_ni_list[m] + direction_list[m]
        pai_ni_list[pai_list[j]] = j
        if m < pai_list[j + 2 * direction_list[m]]:
            direction_list[m] = -direction_list[m]
            A_list.remove(m)
        if A_list:
            A_list = list(set(A_list + [i for i in range(m + 1, origin + 1)]))
        else:
            A_list = list(set([i for i in range(m + 1, origin + 1)]))
    else:
        Flag_Done = True
print("Total situation: " + str(sum))

