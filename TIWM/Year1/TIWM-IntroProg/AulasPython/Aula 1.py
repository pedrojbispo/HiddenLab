def Exe1():
    print("Bem vindo ao PYTHON")

    val1 = 10
    val2 = 100

    res = val1 + val2 #soma dos dois valores

    print(res)
def Exe2():
    txt = "Aula 1 Exercício 2"
    print(txt)
def Exe3():
    txt1 = "Introdução"
    txt2 = "Programação"
    res = txt1 + txt2
    print(res)
    print(type(res))
def Exe4():
    val1 = 100
    if val1 < 10:
        print("O valor é menor do que 10")
    elif val1 == 10:
        print("O valor é igual a 10")
    else:
        print("O valor é maior do que 10")
def Exe5():
    val1 = 10
    val2 = 100
    if val1 < val2:
        print("O valor é menor do que " + str(val2))
    elif val1 == val2:
        print("O valor é igual a " + str(val2))
    else:
        print("O valor é maior do que " + str(val2))
def Exe6():
    val = 3
    if val%2 == 0:
        print("O valor",val,"é par") 
        #A virgula separa elementos a apresentar
    else:
        print("O valor " + str(val) + " é impar")
        #O "+" junta strings
def Exe7():
    val = 10
    while val > 0:
        print(val)
        val-=1
def Exe8():
    for val in range(10):
        print(val)
def Exe9():
    for val in range(10,0,-1):
        print(val)
def Exe10():
    for val in range(100,1000,100):
        print(val)
def Exe11():
    for val in range(500,-1,-50):
        print(val)
def Exe12():
    
    val1 = int(input("Qual o 1º Valor: "))
    val2 = int(input("Qual o 2º Valor: "))

    if val1>val2:
        for i in range(val1, val2, -1):
            print(i)
    elif val1 == val2:
        print("IGUAIS")
    else:
        for i in range(val1, val2):
            print(i)

    

Exe12()
