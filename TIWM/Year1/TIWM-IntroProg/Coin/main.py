op = ""
subop = ""
while op != "0":
    print(">>>>>>>MENU<<<<<<<")
    print("1 - Converter moeda")
    print("2 - Euromilhoes")
    print("0 - Exit")
    op = input("Option: ")

    if op == "1":
        #1€ = 1,19$
        #1€ = 0,89£
        #1€ = 6,38R$
        #1€ = 786,17 Kwanza

        value = float(input("Value = "))

        dollar = value * 1.19
        gbp = value * 0.89
        real = value * 6.38
        kwanza = value * 785.17

        print("Result:", "\nEuro:", str(value), "€", "\nDollar:", str(dollar), "$", "\nGBP:", str(gbp), "£", "\nReal:", str(real), "R$", "\nKwanza:", str(kwanza), "Kz\n")

    if op == "2":
        dados = {}
        dadosP = {"nums": [1, 5, 17, 28, 31], "stars": [1, 10]}
        lit_num = []
        lit_star = []
        lit_num.append(int(input("num1: ")))
        lit_num.append(int(input("num2: ")))
        lit_num.append(int(input("num3: ")))
        lit_num.append(int(input("num4: ")))
        lit_num.append(int(input("num5: ")))
        lit_star.append(int(input("star1: ")))
        lit_star.append(int(input("star2: ")))

        lit_num.sort()
        lit_star.sort()

        dados.update({"nums": lit_num})
        dados.update({"stars": lit_star})
        for i in dados:
            for u in dados[i]:
                print(str(u), end=" ")
            if i == "nums":
                print("+", end=" ")
            else:
                print("\n")

        nums = 0
        stars = 0
        for i in dados["nums"]:
            for u in dadosP["nums"]:
                if i == u:
                    nums = nums + 1
        for i in dados["stars"]:
            for u in dadosP["stars"]:
                if i == u:
                    stars = stars + 1
        print("Equal Nums Found" + nums)
        print("Equal Stars Founds" + stars)

        if nums == 5 and stars == 2:
            print("Lucky Winner, You got Millions, enjoy your life, you b#%$#!&!")
        elif nums == 5 and stars == 1:
            print("Lucky Winner, You got Thousands, enjoy your life, you b#%$#!&!")
        elif nums == 5 and stars == 0:
            print("Lucky Winner, You got some Thousands, enjoy your life, you fool")
        elif nums == 4 and stars == 2:
            print("You managed to win some, but spend wisely, human")
        elif nums == 3 and stars == 2:
            print("")
        elif nums == 3 and stars == 1:
            print("")
        elif nums == 4 and stars == 0:
            print("")
        elif nums == 4 and stars == 1:
            print("")