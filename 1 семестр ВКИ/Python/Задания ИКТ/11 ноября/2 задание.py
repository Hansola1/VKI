#Написать функцию, определяющую верно ли, что все цифры целого числа нечетные.

x =int(input('целое число '))
def nechet(x):
    x1 = 0
    x2 = 0
    while (x>0):
        h = x % 10

        if h%2 != 0:
            x1 = x1+1

        x2=x2+1
        x = x//10

    if (x1==x2):
        return True
    else:
        return False


print(nechet(x))


