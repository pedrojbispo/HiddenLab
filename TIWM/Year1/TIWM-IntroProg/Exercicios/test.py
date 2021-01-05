#Import Header
import random
import math

#-------------------------------------#

opc = ""

while opc != "0":
    print("\n\n-- MENU --\n")
    print("1 - EX1-Guessing Game")
    print("2 - EX2-Maior ou Menor ou Igual")
    print("3 - EX3-Par ou Impar")
    print("4 - EX4-FOR Part 1")
    print("5 - EX5-Vetor, Lista, Dicionario")
    print("6 - EX6-Vetor Maior, menor Temp")
    print("7 - EX7-Fibonacci Numbers")
    print("8 - EX8-Primos")
    print("9 - EX9-Factorial")
    print("10:10 - EX10-TXT File Part 1")
    print("10:11 - EX10-TXT File Part 2")
    print("10:12 - EX10-TXT File Part 3")
    print("13 - EX11-Func")
    print("14 - EX12-Rand")
    print("15 - EX13-Math")
    print("16 - EX14-Math-Trig")
    print("17 - EX15-Math-Trig Ang")
    print("18 - EX16-CPU TEMP")
    print("648632 - EGG")
    print("\n0 - EXIT")
    opc = input("CHOICE: ")

# -------------------------------------#
    # Guessing Game
    if opc == "1":
        print("\nEX1... Running....")
        print("なに⁉")
        ukey = int()
        key = 6486
        while ukey != key:
            ukey = int(input())
            if ukey == key:
                print("Well done, Brother!")
            else:
                print("You disgrace!")
# -------------------------------------#
    # Maior-Menor ou Igual
    if opc == "2":
        print("\nEX2... Running....")
        num = input("Num:")
        if num.isnumeric() == False:
            print("invalido, do you want to crash me?, you little !#$%&, Numbers Only!")
        else:
            num = int(num)
            if num > 10:
                print(num, "maior do 10")
            elif 10 > num > 0:
                print(num, "menor do 10")
            elif num == 10:
                print(num, "igual do 10")
            elif num < 0:
                print(num, "negativo, Nice try, dip !#$%, Nice try! Don't even try to crash me!")
# -------------------------------------#
    # Par ou Impar
    if opc == "3":
        print("\nEX3... Running....")
        num = int(input("Num:"))
        if num % 2 == 0:
            print("Par")
        else:
            print("Impar")
# -------------------------------------#
    # FOR Part 1
    if opc == "4":
        print("\nEX4... Running....")
        Maxnum = int(input("Num:"))
        # txt = ""
        for i in range(0, Maxnum, 2):
            # print(i)
            # txt = txt + str(i) + " | "
            print(i, end=" | ")
        # print(txt)
# -------------------------------------#
    # Vetor, Lista, Dicionario
    if opc == "5":
        print("\nEX5... Running....")
        fuckcury = [1, 2, 3, 4, 666, 999, 45, 123]
        print(fuckcury)
        fuckcury.append(666)
        thisdict = {"key1": "1231", "key2": "65748", "key3": "15464"}
        print(thisdict)
        for i in thisdict:
            thisdict.update({"key3": 15648})
        print(thisdict)
        for i in thisdict:
            thisdict.pop({"key3"})
        print(thisdict)
# -------------------------------------#
    # Vetor Maior, menor Temp
    if opc == "6":
        print("\nEX6... Running....")
        localidades = ["Valongo", "Porto", "Guarda", "Vila Real", "Maia"]
        temperaturas = [20, 19, 17, 20, 21]
        for i in range(5):
            print(localidades[i] + ": " + str(temperaturas[i]) + "ºC")
        # Apresentar a localidade com a temp mais alta
        posMax = 0
        for i in range(5):
            if (temperaturas[i] > temperaturas[posMax]):
                posMax = i
        print("\n" + localidades[posMax] + " registou a temperatuda mais elevada com " + str(
            temperaturas[posMax]) + "ºC")
        # Apresentar a localidade com a temp mais baixa
        posMin = 0
        for i in range(5):
            if temperaturas[i] < temperaturas[posMin]:
                posMin = i
        print(localidades[posMin] + " registou a temperatuda mais baixa com " + str(
            temperaturas[posMin]) + "ºC")
        media = sum(temperaturas)/len(temperaturas)
        print("Media registada da temperatura: " + str(media) + "ºC")
        soma = 0
        for i in range(5):
            soma = soma + temperaturas[i]/5
        print(soma)

# -------------------------------------#
    # Fibonacci Numbers
    if opc == "7":
        print("\nEX7... Running....")
        maxinput = int(input("Num: "))
        num1 = 1
        num2 = 1
        print(num1, end="\t")
        print(num2, end="\t")
        for i in range(maxinput):
            numX = num1 + num2
            print(numX, end="\t")
            num1 = num2
            num2 = numX
# -------------------------------------#
    # Primos
    if opc == "8":
        print("\nEX8... Running....")
        val = int(input("Num: "))
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
# -------------------------------------#
    # Factorial
    if opc == "9":
        print("\nEX9... Running....")
        val = int(input("Num: "))
        result = 1
        for i in range(1, val + 1):
            result = result * i
        print(str(val) + "! = ", result)
# -------------------------------------#
    # TXT File Part 1
    if opc == "10":
        print("\nEX10.1... Running....")
        doc = open("YOLO.txt", "w", encoding="utf8")
        yolo = input()
        doc.write(yolo)
        doc.close()
# -------------------------------------#
    # TXT File Part 2
    if opc == "11":
        print("\nEX10.2... Running....\n")
        doc = open("YOLO.txt", "r", encoding="utf8")
        print(doc.read())
        doc.close()
# -------------------------------------#
    # TXT File Part 3
    if opc == "12":
        print("\nEX10.3... Running....\n")
        doc = open("YOLO.txt", "a", encoding="utf8")
        y0lo = input()
        doc.write("\n" + y0lo)
        doc.close()
# -------------------------------------#
    # Func
    if opc == "13":
        print("\nEX11... Running....\n")
        def cal(x, y, z):
            r = (x * y) + (z * x);
            print(r)
            return r
        cal(x = int(input("X: ")), y = int(input("Y: ")), z = int(input("Z: ")))
# -------------------------------------#
    # Rand
    if opc == "14":
        print("\nEX12... Running....\n")
        random.seed(100)
        print(random.random())
        numS = int(input("\nStart: "))
        numF = int(input("Finish: "))
        print(random.randrange(numS, numF))
# -------------------------------------#
    # Math
    if opc == "15":
        print("\nEX13... Running....\n")
        print("Are you ready for Meth? XD ah just kidding, Let's learn some Math, just because I want!\nAnd If you are against it, then why dafq are you doing here? Get the fuck out kid!")
        num1 = int(input("\nNum1: "))
        print(math.pow(num1, 2))
        print(math.pi)
        num2 = int(input("Num2: "))
        print(math.sqrt(num2))
# -------------------------------------#
    #Math Trig
    if opc == "16":
        print("\nEX14... Running....\n")
        print("Are you ready for Meth? XD ah just kidding, Let's learn some Math, just because I want!\nAnd If you are against it, then why dafq are you doing here? Get the fuck out kid!")
        l1 = int(input())
        l2 = int(input())
        l3 = int(input())
        if (l1 + l2 >= l3) and (l3 + l2 >= l1) and (l3 + l1 >= l2):
            print("É Trig")
        else:
            print("Não é Trig, opa então, eu quero um triangulo.")
# -------------------------------------#
    # Math Trig part2
    if opc == "17":
        print("\nEX15... Running....\n")
        print("Are you ready for Meth? XD ah just kidding, Let's learn some Math, just because I want!\nAnd If you are against it, then why dafq are you doing here? Get the fuck out kid!")
# -------------------------------------#
    # Aula
    if opc == "18":
        print("\nEX16... Running....\n")
        maxi = int(input("MAX:"))
        core = []
        temp = []
        for i in range(0, maxi):
            core.append(i)
            temp.append(int(input("Temp of Core " + str(i)+ ": ")))
        for i in range(0, maxi):
            print("CPU:", core[i] ," | ", "Temp:", temp[i])
        m = sum(temp)/len(temp)
        print("Avg. CPU Temp: ", m)
        posMax = 0
        for i in range(maxi):
            if (temp[i] > temp[posMax]):
                posMax = i
        print("Highest core temp: " + str(core[posMax]) + " with " + str(temp[posMax]) + "ºC")
        posMin = 0
        for i in range(maxi):
            if temp[i] < temp[posMin]:
                posMin = i
        print("Lowest core Temp:", str(core[posMin]) + " with " + str(temp[posMin]) + "ºC")
# -------------------------------------#
    # Easter Egg
    if opc == "648632":
        print("\nEGG... EXECUTING....")
        print("Mmmh I see, you manage to overwrite my code...")
        print("You wanted to know my secrets for world domination... mmh I see")
        print("Guess the code to processed.....if you can...")
        ukey = int()
        key = 9999999999999999999
        while ukey != key:
            ukey = int(input())
            if ukey == key:
                print("Ah, it's you, I was hoping it was the VEX, oh well sorry for that rude introduction.")
                print("Let me brief you, Guardian.")
                print(
                    "The VEX found out our secrets, we need to stopped them right now or we are all doomed. You must go to the Infinite forest in Mercury and stop the VEX.")
                print(
                    "You seen this before right, Guardian? They are striking again, we must shutdown their plans after they kill the light of our sun.")
                print(
                    "Good luck, Guardian.")
                print("#----------------------------------------------------------------------------------------------------------------------------------------#")
                print("Yes, I know, this is a Destiny 2 Reference, if you don't get it, well it means that you never played the game, it's free, but you need a good PC to run it. Good luck XD.")
                print("PS: Ah and I forgot about this, sadly all old content is going a way, just watch a video on youtube.")
            else:
                print("oh you won't enter you damn VEX, not this time!")
#-------------------------------------#