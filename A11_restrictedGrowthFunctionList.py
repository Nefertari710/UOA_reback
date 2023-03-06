n = eval(input("Please input:"))
v_list = [1 for i in range(0, n)]       # init the List v_list
m_list = [2 for j in range(0, n)]       # init the List m_list
Flag_Done = False
while not Flag_Done:
    print(v_list)                       # After every change print v_list
    j = n                               # Let j begin at last element in v_list
    while True:                         # When v_list[j] != m_list[j] break loop
        j -= 1
        if v_list[j] != m_list[j]:
            break
    if j > 0:                           # Stop condition
        v_list[j] += 1
        for i in range(j + 1, n):
            v_list[i] = 1               # Let
            if v_list[j] == m_list[j]:
                m_list[i] = m_list[j] + 1
            else:
                m_list[i] = m_list[j]
    else:
        Flag_Done = True

    # If want see more detail please use below code
    # print("v_list:" + str(v_list) + ", m_list:" + str(m_list))

"""
For example: n = 3
v_list:[1, 1, 2], m_list:[2, 2, 2]
v_list:[1, 2, 1], m_list:[2, 2, 3]
v_list:[1, 2, 2], m_list:[2, 2, 3]
v_list:[1, 2, 3], m_list:[2, 2, 3]
v_list:[1, 2, 3], m_list:[2, 2, 3]
"""