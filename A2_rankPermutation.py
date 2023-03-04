# This Algorithm can find inverse pai list place
# such as: If you want find n = 4 inverse_pai_list = [0,4,1,2,3,5]
# input: 0 4 1 2 3 5
# output = 17
R = 0
pai_ni_list = input("PlZ input a inverse list: ").split()       # input an inverse list
for i in range(1, len(pai_ni_list) - 1):
    moves = 0
    for j in range(1, len(pai_ni_list) - 1):
        # pai_ni_list represent current element place such as
        # pai_ni_list = [0,2,3,4,1,5] -> represent pai_list[2] = 1 pai_list[3] = 2
        # We can gain pai_list = [0,4,1,2,3,5]
        if j < i and pai_ni_list[j] < pai_ni_list[i]:
            # position j < i and pai_list[pai_ni_list[j]] = j pai_list[pai_ni_list[i]] = i
            # pai_ni_list = [0,2,3,4,1,5] and j = 3 and i =4
            # j = 3 < i = 4 and p(3) = 4 and p(4) = 1 not moves
            moves += 1
        else:
            pass
    if R % 2 == 1:
        remainder = moves
    else:
        remainder = i - 1 - moves
    R = i * R + remainder         # R represent Rank a
pai_list = R
print(pai_list)
