############## KEEP SAFE COVID-19: ##############
# Adicionar máscaras (Horas de eficiência, Nome/Id, Número de Lavagens, Número Lavagens MAX) (Utilizar Dicionários ou Listas)
# Adicionar Lavagem
# Editar os dados das máscaras
# Remover máscara do sistema
# Apresentar informação das máscaras registadas  

#region Dicas
# dados -> {"nome/ID": [Num. Horas, Num. Lav., Num Lav MAX]}
# 
## Criar:
# dados = {}
# id = "azul05" ou input("nome/ID da máscara")
# 
# l = [0, 0, 0]
# l[0] = 30 ou int(input("Número de horas: "))
# l[1] = 4
# l[2] = 25
# 
# dados.update({id: l})
# 
## Ler:
# print(
# 
# dados -> {"azul05": [30, 4, 25], "azul07": [0, 0, 25], "vermelha01": [40, 5, 10]}
# 
# dados["azul05"] -> [30, 4, 25]
# 
# dados["azul05"][1] -> 4 
#endregion 

#region Dica ficheiro
#  f = open("dadosKSC.ksc","w")
#
# f.write("Eu sou a primeira linha\n")
# f.write("Eu sou a 2a linha\n")
#
# f.close()
#
# f = open(v)
# print(f.readline())
# f.close()
#endregion
import os

def LerFicheiro(fichName):

    if os.path.isfile(fichName):
        f = open(fichName,"r")
        linha = f.readline()

        while linha != "":
            vL = linha.split('|')
            dados.update({vL[0]: [int(vL[1]), int(vL[2]), int(vL[3])]})
            linha = f.readline()

        f.close()

def GuardarFicheiro(fichName):
    f = open(fichName,"w")
    for i in dados:
        f.write(i+"|"+str(dados[i][0])+"|"+str(dados[i][1])+"|"+str(dados[i][2])+"\n")
    f.close()

def MostarMascaras():
    cont = 1
    print()
    for i in dados:
        print(str(cont) + "-> " + i + ":\t" + str(dados[i][0]) + "\t|\t" + str(dados[i][1]) + "\t|\t" + str(dados[i][2]))
        cont+=1
    print()

opc = ""
dados = {}
caminho = "dadosKSC.txt"

LerFicheiro(caminho)

while opc != "0":
    print("########## KEEP SAFE COVID-19: ##########")
    print("\n\n-- MENU --\n")
    print("1) Mostar Máscaras")
    print("2) Editar Máscara")
    print("3) Gerir Máscaras")

    print("\n0) Sair")
    opc = input("Opção: ")

    if opc == "1":
        MostarMascaras()
    elif opc == "2":
        print("########## KEEP SAFE COVID-19: ##########")
        print("############ Editar Máscaras ############")

        print("1) Add Lavagem Máscara")
        opcE = input("Opção: ")

        if opcE == "1":
            try:
                MostarMascaras()
                opcM = int(input("Qual a máscara que pretende actualizar? "))
                l = list(dados)
                key = l[opcM-1]

                for i in dados:
                    if i == key:
                        dados[i][1] += 1
                        #dados[i][1]=dados[i][1] + 1
                        print("Máscara actualizada com sucesso!!!")
                        print(i + " -> " + str(dados[i][1]) + " lavagens")
            
                MostarMascaras()
            except:
                print("Opção Inválida!!!!!")

    elif opc == "3":
        print("########## KEEP SAFE COVID-19 ##########")
        print("############ Gerir Máscaras ############")
        print("1) Adicionar Máscara")
        print("2) Remover Máscara")    
        
        opcG = input("Opção: ")

        if opcG == "1":
            print("\n\n--- Adicionar Máscara ---")
            nome = input("Nome/ID da máscara:")

            l = [0, 0, 0]

            l[0] = int(input("Número de Horas eficaz:"))
            l[1] = int(input("Número de Lavagens:"))
            l[2] = int(input("Número de Lavagens Máximo:"))

            dados.update({nome: l})
        elif opcG == "2":
            MostarMascaras()
            remov = int(input("Qual a máscara que pretende remover? "))
            l = list(dados)

            del dados[l[remov]]

GuardarFicheiro(caminho)




