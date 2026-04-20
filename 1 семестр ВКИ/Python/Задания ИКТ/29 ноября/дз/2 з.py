#2. Дана последовательность целых чисел a1, a2, …, aN.
# Элементы последовательности – случайные числа из диапазона от -34 до 92
# включительно. Если в данной последовательности ни одно четное число
# не расположено после нечетного, то посчитать количество всех
# отрицательных членов последовательности, в противном случае – всех
# положительных. Задачу решить для N = 5. Решение задачи оформить в виде функций.

# 2
from random import randint


def check_spisok():
    N = 5  # int(input())
    spisok = []
    nechet_sovpad = 1  # 1 чётное ,0 нечёт, 2 для решения условия с тем что складывать
    sum = 0

    for i in range(N):  # заполняем список random ислами
        chislo = randint(-34, 92)
        spisok.append(chislo)

    for i in range(N):
        if spisok[i] % 2 == 1:
            nechet_sovpad = 0
        elif spisok[i] % 2 == 0 and nechet_sovpad == 0:
            nechet_sovpad = 2
            break

    if nechet_sovpad == 2:
        for i in range(N):
            if spisok[i] > 0:
                sum += spisok[i]

    else:
        for i in range(N):
            if spisok[i] < 0:
                sum += spisok[i]

    return sum


print('сумма = ', check_spisok())