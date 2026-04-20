#2.	Дана матрица размера N x M. Удалить строку, содержащую минимальный элемент матрицы.


from random import randint

N = int(input('Сколько строк в матрицы: '))
M = int(input('Сколько столбцов в матрицы: '))
matrix = [[randint(-100,100) for j in range(M)] for i in range(N)]
min_strok = 0
min_stolb = 0

for i in range(N):
    for j in range(M):
        print("%4d" %matrix[i][j], end=" ")

        if matrix[i][j] < matrix[min_strok][min_stolb]:
            min_strok = i
            min_stolb = j
    print()
print("matrix[%d][%d]=%d" %(min_strok, min_stolb, matrix[min_strok][min_stolb]))
print()
matrix.pop(min_strok)  # Удаляем строку
N = N-1
for i in range(N):
    for j in range(M):
        print("%4d" %matrix[i][j], end=" ")


    print()




