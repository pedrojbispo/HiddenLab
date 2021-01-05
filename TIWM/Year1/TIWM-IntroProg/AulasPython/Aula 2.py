
def E_Primo(num):
    for i in range(2,int(num/2)+1):
        if num%i == 0:
            return False
    
    return True

opc = ""
while opc != "0":
    print("\n\n-- MENU --\n")
    print("1) Verificar par ou impar")
    print("2) Verificar Primo")
    print("3) Fatorial")
    print("4) Fibonacci")
    print("5) Fibonacci Primos")
    print("6) Into. Listas")
    print("7) Temperaturas 5 localidades")
    print("8) Temperaturas N localidades")
    print("9) Into. Dicionarios")
    print("10) Temperaturas 5 localidades (DICIO)")
    print("11) Temperaturas N localidades (DICIO)")

    print("\n0) Sair")
    opc = input("Opção: ")

    if opc == "1":
        val = int(input("Qual o valor? "))
        if val%2 == 0:
            print("O número", val, "é par")
        else:
            print("O número", val, "é impar")

    elif opc == "2":
        val = int(input("Qual o valor? "))
        primo = True
        flag = 0

        for i in range(2,int(val/2)+1):
            flag+=1
            if val%i == 0:
                primo = False
                break
        
        if primo == True:
            print("O número",val,"é primo")
        else:
            print("O número",val,"não é primo")
        
        print("Flag ->",flag)

    elif opc == "3":
        val = int(input("Qual o valor? "))
        resultado = 1

        for i in range(1,val+1):
            resultado = resultado * i
            
        print(str(val)+"! =",resultado)

    elif opc == "4":

        num1 = 1
        num2 = 1
        
        print(num1, end="\t")
        print(num2, end="\t")

        for i in range(13):
                
            numX = num1 + num2
            print(numX, end="\t")
            num1 = num2
            num2 = numX

    elif opc == "5":
        val = int(input("Quantos números? "))

        contador = 0
        num1 = 1
        num2 = 1

        while contador < val:
                
            numX = num1 + num2
            if(E_Primo(numX)):
                print(numX, end="\t")
                contador+=1
            
            num1 = num2
            num2 = numX

    elif opc == "6":
        #criar uma lista
        alunos = ["Denilson", "Diogo", "Pedro", "Ana"]
        print(alunos) #apresenar a lista
        
        #Apresentar determinada posição da lista
        print(alunos[0])
        print(alunos[3])

        #Adicionar valores à lista
        alunos.append("Eduardo")
        print(alunos)

    elif opc == "7":
        localidades = ["Valongo","Porto","Guarda", "Vila Real", "Maia"]
        temperaturas = [20, 19, 17, 20, 21]
        
        for i in range(5):
            print(localidades[i] + ": " + str(temperaturas[i]) + "ºC")

        #Apresentar a localidade com a tempe mais alta
        posMax = 0
        for i in range(5):
            if(temperaturas[i] > temperaturas[posMax]):
                posMax = i

        print("\n\n" + localidades[posMax] + " registou a temperatuda mais elevada com " + str(temperaturas[posMax]) + "ºC")
        
        #Apresentar a localidade com a temp mais baixa
        posMin = 0
        for i in range(5):
            if(temperaturas[i] < temperaturas[posMin]):
                posMin = i

        print(localidades[posMin] + " registou a temperatuda mais baixa com " + str(temperaturas[posMin]) + "ºC")
        
        soma = 0
        for i in range(5):
            soma = soma + temperaturas[i]

        media = soma/len(temperaturas)        
        print("A média de temperaturas é: " + str(media))

    elif opc == "8":
        temp = []
        loc = []

        n = int(input("Quantas localidades quer adicionar?"))

        for i in range(n):
            loc.append(input(str(i+1)+"º Localidade: "))
            temp.append(int(input("Temperatura registada em " + loc[i] + ": ")))
            
            #s = input("Temperatura registada em " + loc[i] + ": ")
            #val = int(s)
            #temp.append(val)
        
        print("\n\n")
        for i in range(n):
            print(loc[i] + ": " + str(temp[i]) + "ºC")

    elif opc == "9":
        #criar uma dicionario
        alunos = {"Denilson":15, "Diogo":13, "Pedro":20, "Ana":10}
        print(alunos) #apresenar dicionario

        print(alunos["Denilson"])
        #print(alunos[0]) ERRO!!!

        alunos.update({"Alex":8})

        print("\n\n")
        for i in alunos:
            print(i + " - " + str(alunos[i]))

        d = {"Carla":11,"Antonio":16}
        alunos.update(d)

        print("\n\n")
        for i in alunos:
            print(i + " - " + str(alunos[i]))

        del alunos["Alex"]
        print("\n\n")
        for i in alunos:
            print(i + " - " + str(alunos[i]))


        print("\n\n")
        for i in alunos:
            print(i + " - " + str(alunos[i]))

    elif opc == "10":

        dadosLoc = {
            "Valongo":20,
            "Porto":19,
            "Guarda":17,
            "Vila Real":20, 
            "Maia":21 }

        #Apresentar
        print()
        for i in dadosLoc:
            print(i + ": " + str(dadosLoc[i]) + "ºC")

        #Max
        #Primeira Versão
        posMax = list(dadosLoc.keys())[0]
        for i in dadosLoc:
            if(dadosLoc[i] > dadosLoc[posMax]):
                posMax = i

        print("\n\n" + posMax + " registou a temperatuda mais elevada com " + str(dadosLoc[posMax]) + "ºC")
        
        #Segunda Versão
        posMax = ""
        for i in dadosLoc:
            if(posMax == ""):
                posMax = i
            elif(dadosLoc[i] > dadosLoc[posMax]):
                posMax = i

        print("\n\n" + posMax + " registou a temperatuda mais elevada com " + str(dadosLoc[posMax]) + "ºC")


        #Min
        posMin = ""
        for i in dadosLoc:
            if(posMin == ""):
                posMin = i
            elif(dadosLoc[i] < dadosLoc[posMin]):
                posMin = i

        print("\n\n" + posMin + " registou a temperatuda mais baixa com " + str(dadosLoc[posMin]) + "ºC")

        #Media
        soma = 0
        for i in dadosLoc:
            soma  = soma + dadosLoc[i]
        
        media = soma/len(dadosLoc)         
        print("\n\nA média de temperaturas é: " + str(media))

    elif opc == "11":
        dados = {}
        
        n = int(input("Quantas localidades quer adicionar?"))

        for i in range(n):
            cidade = input(str(i+1)+"º Localidade: ")
            valTemp = int(input("Temperatura registada em " + cidade + ": "))

            dados.update({cidade: valTemp})

        print()
        for i in dados:
            print(i + ": " + str(dados[i]) + "ºC")

    elif opc == "12":
        d = {"ASD": ["sss", 1.2, 55]}

        print(d["ASD"][0])

