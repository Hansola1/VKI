x = int(input("пишем число"))
fib = [1,1]
if x>2:
    for i in range (x-2):
        fib.append(fib[i]+fib[i+1])
print(fib)