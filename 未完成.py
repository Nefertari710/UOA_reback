n = eval(input("Please input:"))
u_list = input("please input a list:")
v_list = [0 for j in range(0, n)]
for i in range(1, n):
    if u_list[i - 1] > v_list[i - 1]:
        u_list[i] = u_list[i - 1]
    else:
        u_list[i] = v_list[i - 1]
R = 0
for j in range(n, -1, -1):
    t = u_list[i]
    R +=
rank = R
