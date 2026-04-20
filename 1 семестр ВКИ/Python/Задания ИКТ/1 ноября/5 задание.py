#5.	Составьте программу вывода на экран всех
# простых чисел, не превосходящих заданного
# N. Решение оформить в виде отдельной функции.

# x = [ ] #массив
# n = int(input('Введите n: '))
# for i in range(n+1): #в и последоват + 1
#     x.append(0) #вызыв элемента
# for i in range(2, n+1):
#     if x[i] == 0: #если элемент прост число
#         print(i, end=' ')
#         x1 = 2*i
#         while x1 <= n:
#             x[x1] = 1
#             x1 += i
x = [] #массив
n = int(input('Введите n: '))
def tyktyk(x):
    return x
for i in range(1, n+1):
    count=0
    for x4 in range(1,i+1):
        if i%x4 == 0: #если элемент прост число
            count +=1
    if count ==2:
        x.append(i)
print(x)