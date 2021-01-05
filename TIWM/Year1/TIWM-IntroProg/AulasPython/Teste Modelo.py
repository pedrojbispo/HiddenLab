
opc = ""
localidades = {}
localidades.update({"Maia": [9, 15, 100]})
localidades.update({"Porto": [10, 15, 75]})
localidades.update({"VNGaia": [10, 16, 60]})


while opc != "0":
    print("-----------------------------------------------\n")
    print("Menu:")
    print("\t1) Adicionar Registo")
    print("\t2) Remover Registo")
    print("\t3) Mostrar Registos")
    print("\t4) Cidade com a temperatura mais alta")
    print("\t5) Cidade com a temperatura mais baixa")
    print("\t6) Média das Temperaturas")
    print("\t7) Em que cidades vai chover")
    print("\t0) Sair")
    print("\n-----------------------------------------------")

    opc = input("\nOpção: ")

    if opc == "1":
        nl = input("Nome da Localidade: ")
        tmin = int(input("Temperatura MIN: "))
        tmax = int(input("Temperatura MAX: "))
        pp = int(input("Prob. de Precipitação: "))

        localidades.update({nl: [tmin, tmax, pp]})

    elif opc == "2":
        try:
            for i in localidades:
                print(i + ":")
                print("\tTemp. MIN:", localidades[i][0], "ºC")
                print("\tTemp. MAX:", localidades[i][1], "ºC")
                print("\tProb. Prec:", localidades[i][2], "%")

            rm = input("Localidade a remover: ")

            del localidades[rm]
        except:
            print("404 - Not Found!!!")

    elif opc == "3":
        for i in localidades:
            print(i + ":")
            print("\tTemp. MIN:", localidades[i][0], "ºC")
            print("\tTemp. MAX:", localidades[i][1], "ºC")
            print("\tProb. Prec:", localidades[i][2], "%")

    elif opc == "4":
        lmax = list(localidades.keys())[0]

        for i in localidades:
            if localidades[lmax][1] < localidades[i][1]:
                lmax = i

        print(lmax + " é a localidade com a temperatura mais alta:")
        print("\tTemp. MIN:", localidades[lmax][0], "ºC")
        print("\tTemp. MAX:", localidades[lmax][1], "ºC")
        print("\tProb. Prec:", localidades[lmax][2], "%")

    elif opc == "5":
        lmin = list(localidades.keys())[0]

        for i in localidades:
            if localidades[lmin][0] > localidades[i][0]:
                lmin = i

        print(lmin + " é a localidade com a temperatura mais baixa:")
        print("\tTemp. MIN:", localidades[lmin][0], "ºC")
        print("\tTemp. MAX:", localidades[lmin][1], "ºC")
        print("\tProb. Prec:", localidades[lmin][2], "%")   

    elif opc == "6":
        soma = 0
        for i in localidades:
            soma = soma + localidades[i][0] + localidades[i][1]
        
        media = soma / (2*len(localidades))
        
        print("\n\nA temperatura média registada foram",media,"ºC.\n\n")

    elif opc == "7":
        print("\n\nVai chover nas seguintes localidades:\n")
        for i in localidades:
            if localidades[i][2] >= 75:
                print("\t- " + i)
        print("\n\n")

    elif opc == "0":
        print("\n\nObrigado e até à próxima!\n\n")
    else:
        print("\n\nOpção Inválida\n\n")
