def fibonacci(n):
    if n <= 0:
        return 0
    elif n == 1:
        return 1
    else:
        return fibonacci(n-1) + fibonacci(n-2)

quantidade = input("Digite a quantidade de linhas da pirâmide: ")
num_linhas = int(quantidade)


for i in range(num_linhas):
    for k in range(i+1):
        fib = fibonacci(k)
        print(f"{fib} ", end="")
    print()