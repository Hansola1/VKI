#Вывести на экран все пятизначные числа, сумма цифр которых <= 17 и >= 10.
#Написать вспомогательную функцию вычисления суммы цифр.


def summa5():
    s = 0
    for x in range(10000, 100000):
        s = summa(x)
        if s<=17 and s>10:
            print(x)
def summa (a):
    s = 0
    while (a > 0):
        n = a % 10
        s += n
        s = s // 10
    else:
        print ("таких чисел нет")

print(summa5)

#n = a % 17
        #s -= n

#if x<=17 and x>10:
    #print("эти числа"(x))













#print(summa5(x))



