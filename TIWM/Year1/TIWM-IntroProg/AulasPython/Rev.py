
opc = ""

while opc != "0":

    print("\n<><><> MENU <><><>\n")

    print("1) Converter moeda")
    print("2) Euromilhões")
    print("3) Gestor de Turma")



    print("\n0) Sair")
    opc = input("Opção: ")

    if opc == "1":
        
        print("<><><><><> MENU <><><><><><>")
        print("<><><> Converter Moeda <><><>\n")
        
        print("1) Euro (€)")
        print("2) Dollar ($)")
        print("3) Libra (£)")
        print("4) Real (R$)")
        print("5) Kwanza (Kz)")
        
        opc1 = input("Qual a moeda de origem: ")

        if opc1 == "1":

            valor = float(input("\n\nQual o valor em euros €: "))
            
            dolar = round((valor * 1.19),2)
            gbp = valor * 0.89
            real = valor * 6.38
            kwanza = valor * 785.17

            print("\n\n" + str(valor) + " € corresponde a:")
            print(str(dolar) + " $")
            #print("{:.2f} $".format(dolar))
            print(str(gbp) + " £")
            print(str(real) + " R$")
            print(str(kwanza) + " Kz\n\n")

        elif opc1 == "2":
            valor = float(input("\n\nQual o valor em dollars $: "))
            
            #1 € - 1,19 $
            
            euro = valor/1.19
            gbp = euro * 0.89
            real = euro * 6.38
            kwanza = euro * 785.17

            euro = round(euro,2)
            gbp = round(gbp,2)
            real = round(real,2)
            kwanza = round(kwanza,2)

            print("\n\n" + str(valor) + " $ corresponde a:")
            print(str(euro) + " €")
            print(str(gbp) + " £")
            print(str(real) + " R$")
            print(str(kwanza) + " Kz\n\n")
    
    elif opc == "2":
        #dicio
        dados = {}
        dadosP = {"numeros": [1, 5, 17, 28, 31],
        "estrelas": [1 , 10]}

        #5 num e 2 Est
        print("<><><><><> MENU <><><><><><>")
        print("<><><><> EUROMILHÕES <><><>\n")

        lnt = []
        lnt.append(int(input("1º número:")))
        lnt.append(int(input("2º número:")))
        lnt.append(int(input("3º número:")))
        lnt.append(int(input("4º número:")))
        lnt.append(int(input("5º número:")))
        
        let = []
        let.append(int(input("1ª estrela:")))
        let.append(int(input("2ª estrela:")))

        lnt.sort()
        let.sort()

        dados.update({"numeros": lnt})
        dados.update({"estrelas": let})
        
        print("A chave introduzida foi:\n")

        for i in dados:
            for j in dados[i]:
                print(str(j),end=" ")
            
            if i == "numeros":
                print("+", end=" ")
            else:
                print("\n")

        #Comparar com premiada
        #dizer prémio
        num = 0
        est = 0
        for i in dados["numeros"]:
            for j in dadosP["numeros"]:
                if i == j:
                    num = num + 1        
        
        for i in dados["estrelas"]:
            for j in dadosP["estrelas"]:
                if i == j:
                    est = est + 1

        if num == 2 and est == 0:
            print("-----  13º Prémio  -----")
        elif num == 2 and est == 1:
            print("-----  12º Prémio  -----")
        elif num == 1 and est == 2:
            print("-----  11º Prémio  -----")
        elif num == 3 and est == 0:
            print("-----  10º Prémio  -----")
        elif num == 3 and est == 1:
            print("-----  9º Prémio  -----")  
        elif num == 2 and est == 2:
            print("-----  8º Prémio  -----")  
        elif num == 4 and est == 0:
            print("-----  7º Prémio  -----")  
        elif num == 3 and est == 2:
            print("-----  6º Prémio  -----")  
        elif num == 4 and est == 1:
            print("-----  5º Prémio  -----")
        elif num == 4 and est == 2:
            print("-----  4º Prémio  -----")
        elif num == 5 and est == 0:
            print("-----  3º Prémio  -----")
        elif num == 5 and est == 1:
            print("-----  2º Prémio  -----")
        elif num == 5 and est == 2:
            print("-----  1º Prémio  -----")
        else:
            print("-----  Sem Prémio  -----")

    elif opc == "3":
        alunos = {}
        f = open("txtRev.txt","r",encoding="utf-8")

        linha = f.readline()

        while linha != "":
            lsplit = linha.split('|')

            alunos.update({lsplit[0]:[lsplit[1],int(lsplit[2]),int(lsplit[3]),int(lsplit[4])]})

            linha = f.readline()

        f.close()

        print("\n<><><><><> MENU <><><><><><>")
        print("<><><> Gestor de Turma <><><>\n")
        
        print("1) Mostar Alunos")
        print("2) Mostar Aluno")
        print("3) Melhor nota")
        print("4) Média das notas")
        print("5) Melhor Aluno")
        print("6) Alunos Reprovados")
        
        opc1 = input("Opção: ")

        if opc1 == "1":
            for i in alunos:
                print("\n" + i + " " + alunos[i][0])
                print("Nota 1º teste: " + str(alunos[i][1]))
                print("Nota 2º teste: " + str(alunos[i][2]))
                print("Nota Final: " + str(alunos[i][3]) + "\n")

        elif opc1 == "2":
            nAluno = input("\nNúmero de aluno: ")
            try:
                print("\n" + nAluno + " " + alunos[nAluno][0])
                print("Nota 1º teste: " + str(alunos[nAluno][1]))
                print("Nota 2º teste: " + str(alunos[nAluno][2]))
                print("Nota Final: " + str(alunos[nAluno][3]) + "\n")
            except:
                print("\nNúmero de aluno não definindo!!!")