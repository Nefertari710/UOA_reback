from scipy.special import comb                          # import Permutation and combination

R = 0
k = eval(input("PLZ input a k"))                        # input k
origin_list = input("PLZ input a list:").split(" ")     # input target list e.g.[3,4,7]

# Use this main function can compute the Rank(list[])
for i in range(k):
    R += R + int(comb(eval(origin_list[i]) - 1, i))
print("Rank(" + str(origin_list) + ")=" + str(R))       # If you want to verify please use A4_subsetList
