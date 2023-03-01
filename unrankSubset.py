from scipy.special import comb

k = eval(input("please input k:"))
m = eval(input("please input m:"))

R = m
origin_list = [0 for i in range(k + 1)]
for i in range(k, 0, -1):
    p = i - 1
    while comb(p, i) <= R:
        p += 1
    R -= comb(p-1, i)
    origin_list[i] = p
unrank_m = origin_list
print(unrank_m)
