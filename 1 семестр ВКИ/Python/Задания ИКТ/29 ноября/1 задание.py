#1.	Дано натуральное число N и последовательность a1, a2, …, aN целых чисел,
# заданных случайным образом из диапазона от -19 до 205 включительно, если
# максимальный и минимальный элементы стоят на нечетных местах, найти сумму
# положительных элементов массива, в противном случае – произведение отрицательных.
# Задачу решить для N=10.

import random
a1 = []
N = 10
mina1 = 0
maxa1 = 0

#simpolosh = 0
#elifumnoshotric = 0

for i in range(N):
    a1.append(random.randint(-19, 205))
    if a1[i] < a1[mina1]:
        mina1 = i
    if a1[i] > a1[maxa1]:
        maxa1 = i
print(a1)
print(a1[mina1],a1[maxa1])
if maxa1 % 2 != 0 and mina1 % 2 != 0: #проверка на четн
    polosh = 0
    for i in range(N):
        if a1[i]>0:
            polosh+=a1[i]
    print(polosh)
else:
    prois = 1
    for i in range(N):
        if a1[i]<0:
            prois*=a1[i]

    print(prois)









#print(a1)
