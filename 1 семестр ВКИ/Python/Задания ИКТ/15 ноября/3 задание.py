#3.	Дано натуральное число N и последовательность a1, a2, …, aN целых чисел.
# Элементы последовательности – случайные числа из диапазона от -200 до 140 включительно.
# Найти индекс максимального элемента. Задачу решить для N = 10. Решение оформить в виде функции.


import random
a1 = []
N = 10
indexbolsh = 0
for i in range(N):
    a1.append(random.randint(-200, 140))
    print ( a1[i], end=" " )
def tyktyk(a1):
    if a1[i] > a1[indexbolsh]:
        indexbolsh = i
    print (tyktyk(a1))

