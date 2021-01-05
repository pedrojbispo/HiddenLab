opc = ""
while opc != "0":
    print("\n\n-- MENU --\n")
    print("1) Verificar par ou impar")
    print("2) Verificar primo")
    print("3) Fatorial")
    print("4) Fibonacci")
    print("\n0) Sair")
    opc = input("Opção: ")

    if opc == "1":
        val = int(input("Qual o valor? "))
        if val % 2 == 0:
            print("O número", val, "é par")
        else:
            print("O número", val, "é impar")

    if opc == "2":
        val = int(input("Qual o valor? "))
        primo = True
        flag = 0

        for i in range(2, int(val / 2) + 1):
            flag += 1
            if val % i == 0:
                primo = False
                break

        if primo == True:
            print("O número", val, "é primo")
        else:
            print("O número", val, "não é primo")

        print("Flag ->", flag)

    if opc == "3":
        val = int(input("Qual o valor? "))
        resultado = 1

        for i in range(1, val + 1):
            resultado = resultado * i

        print(str(val) + "! = ", resultado)

    if opc == "4":

        num1 = 1
        num2 = 1

        print(num1, end="\t")
        print(num2, end="\t")

        for i in range(13):
            numX = num1 + num2
            print(numX, end="\t")
            num1 = num2
            num2 = numX
