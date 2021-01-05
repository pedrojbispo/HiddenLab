############## KEEP SAFE COVID-19 Class: ##############
import os

def LerFicheiro(fichName):

    if os.path.isfile(fichName):
        f = open(fichName,"r")
        linha = f.readline()

        while linha != "":
            vL = linha.split('|')
            mascTemp = Mascara(vL[0], int(vL[1]), int(vL[2]), int(vL[3]))
            listaMascaras.append(mascTemp)
            linha = f.readline()

        f.close()

def GuardarFicheiro(fichName):
    f = open(fichName,"w")
    for i in listaMascaras:
        f.write(i.StringFicheiro())
    f.close()

def MostarMascaras():
    cont = 1
    print()
    for i in listaMascaras:
        print(str(cont) + "-> " + str(i))
        cont+=1
    print()

class Mascara():
    def __init__(self, nome = "", numHoras = 0, numLav = 0, numLavMax = 0):
        self.nome = nome
        self.numHoras = numHoras
        self.numLav = numLav
        self.numLavMax = numLavMax

    def AdicionarLavagem(self):
        self.numLav += 1

    def StringFicheiro(self):
        return self.nome + "|" + str(self.numHoras) + "|" + str(self.numLav) + "|" + str(self.numLavMax) + "\n"

    def __str__(self):
        return self.nome + ": " + str(self.numHoras) + " | " + str(self.numLav) + " | " + str(self.numLavMax)


opc = ""
dados = {}
listaMascaras = []
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

                listaMascaras[opcM-1].AdicionarLavagem()
                print("Máscara actualizada com sucesso!!!")
                print(listaMascaras[opcM-1].nome + " -> " + str(listaMascaras[opcM-1].numLav) + " lavagens")
            
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
            mascTemp = Mascara()
            print("\n\n--- Adicionar Máscara ---")
            mascTemp.nome = input("Nome/ID da máscara:")
            mascTemp.numHoras = int(input("Número de Horas eficaz:"))
            mascTemp.numLav = int(input("Número de Lavagens:"))
            mascTemp.numLavMax = int(input("Número de Lavagens Máximo:"))

            listaMascaras.append(mascTemp)

        elif opcG == "2":
            MostarMascaras()
            remov = int(input("Qual a máscara que pretende remover? "))
            listaMascaras.pop(remov-1)


GuardarFicheiro(caminho)




