#3.	Дана матрица размера N x M. Продублировать все столбцы,
# содержащие хотя бы один нулевой элемент. Для вычисления
# количества нулевых элементов использовать функцию.

from random import randint

N = int(input('Сколько строк в матрицы: '))
M = int(input('Сколько столбцов в матрицы: '))
matrix = [[randint(-100,100) for j in range(M)] for i in range(N)] # диапазон
stolb_c_0 = 0


for i in range(N):
    for j in range(M):
        print("%4d" %matrix[i][j], end=" ")
    print()

def stolb