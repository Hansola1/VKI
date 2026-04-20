#3. Дано натуральное число N и последовательность a1, a2, …,
# aN целых чисел. Элементы последовательности – случайные числа из
# диапазона от -56 до 121 включительно. Найти максимальный по модулю элемент
# и создать новый массив из элементов массива a, являющихся делителями найденного
# элемента. Задачу решить для N=10. Нахождение максимума оформить в виде функции.

"""3"""

import random


def check_spisok():
    a1 = []
    a2 = []
    N = 10
    max_index = 0

    for i in range(N):
        a1.append(random.randint(-56, 121))

    for i in range(N):
        if abs(a1[i]) > abs(a1[max_index]):  # находим ммаксимальный элемент списка
            max_index = i

    for i in range(0, max_index):
        if a1[max_index] % a1[i] == 0:
            a2.append(a1[i])

    for i in range(max_index + 1, N):
        if a1[max_index] % a1[i] == 0:
            a2.append(a1[i])

    return a2


print('делители максмиальногоэлумета = ', check_spisok())