############## KEEP SAFE COVID-19 Class: ##############
import os

def LerFicheiro(fichName):

    if os.path.isfile(fichName):
        f = open(fichName,"r")
        linha = f.readline()

        while linha != "":
            vL = linha.split('|')
            varpauta = Pauta(vL[0], (vL[1]), (vL[2]), int(vL[3]), int(vL[4]), int(vL[5]), int(vL[6]), (vL[7]))
            listapauta.append(varpauta)
            linha = f.readline()

        f.close()

def GuardarFicheiro(fichName):
    f = open(fichName,"w")
    for i in listapauta:
        f.write(i.StringFicheiro())
    f.close()

def Mostrapauta():
    cont = 1
    print()
    for i in listapauta:
        print(str(cont) + "-> " + str(i))
        cont+=1
    print()

def Mostraturma():
    cont = 1
    print()
    for i in listaturmas:
        print(str(cont) + "-> " + str(i))
        cont+=1
    print()

class Turmas():
    def __init__(self, turmaid =0, listaturma=""):
        self.turmaid = turmaid
        self.listaturma = listaturma

    def Adicionarturma(self):
        self.turmaid =+1
        self.listaturma = self.listaturma

    def StringFicheiro(self):
        return self.listaturma + "\n"

    def __str__(self):
        return self.listaturma

class Alunos():
    def __init__(self, anome=""):
        self.anome = anome

    def StringFicheiro(self):
        return self.anome + "\n"

    def __str__(self):
        return self.anome

class Disciplinas():
    def __init__(self, discnome=""):
        self.discnome = discnome

    def StringFicheiro(self):
        return self.discnome + "\n"

    def __str__(self):
        return self.discnome

class Pauta():
    def __init__(self, turma="", aluno="", disciplina="", m1=0, m2=0, m3=0, notafinal=0,aprovado=""):
        self.turma = turma
        self.aluno = aluno
        self.disciplina = disciplina
        self.m1 = m1
        self.m2 = m2
        self.m3 = m3
        self.notafinal = notafinal
        self.aprovado = aprovado

    def AdicionarNotas(self):
        self.m1 = self.m1
        self.m2 = self.m2
        self.m3 = self.m3

    def StringFicheiro(self):
        return self.turma + "|" + str(self.aluno) + "|" + str(self.disciplina) + "|" + str(self.m1) + "|" + str(self.m2) + "|" + str(self.m3) + "|" + str(self.notafinal) + "|" + str(self.aprovado) + "\n"

    def __str__(self):
        return self.turma + "|" + str(self.aluno) + "|" + str(self.disciplina) + "|" + str(self.m1) + "|" + str(self.m2) + "|" + str(self.m3) + "|" + str(self.notafinal) + "|" + str(self.aprovado)


opc = ""
dados = {}
listaturmas = []
listaalunos = []
listadisciplinas = []
listapauta = []
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
        Mostrapauta()
    elif opc == "2":
        print("########## KEEP SAFE COVID-19: ##########")
        print("############ Editar Máscaras ############")

        print("1) Add Lavagem Máscara")
        opcE = input("Opção: ")

        if opcE == "1":
            try:
                Mostrapauta()
                opcM = int(input("Qual a máscara que pretende actualizar? "))

                listapauta[opcM-1].AdicionarNotas()
                print("Máscara actualizada com sucesso!!!")
                print(listapauta[opcM-1].nome + " -> " + str(listapauta[opcM-1].numLav) + " lavagens")
            
                Mostrapauta()
            except:
                print("Opção Inválida!!!!!")

    elif opc == "3":
        print("############ Gerir Turmas, Alunos, Pauta############")
        print("1) Adicionar Turma")
        print("2) Adicionar Aluno")
        print("3) Adicionar Disciplina")
        print("4) Adicionar Pauta")
        print("########################")
        print("5) Remover Turma")
        print("5) Remover Aluno")
        print("5) Remover Disciplina")
        print("5) Remover Pauta")

        opcG = input("Opção: ")

        if opcG == "1":
            varturmas = Turmas()
            print("\n\n--- Adicionar Turma ---")
            varturmas.listaturma = input("Turma: ")
            listaturmas.append(varturmas)

        if opcG == "2":
            varalunos = Alunos()
            print("\n\n--- Adicionar Aluno ---")
            varalunos.anome = input("Nome do Aluno: ")
            listaalunos.append(varalunos)

        if opcG == "3":
            vardisc = Disciplinas()
            print("\n\n--- Adicionar Disciplina ---")
            vardisc.listadisciplinas = input("Disciplina: ")
            listadisciplinas.append(vardisc)

        if opcG == "4":
            varpauta = Pauta()
            print("\n\n--- Adicionar Pauta ---")
            Mostraturma()
            varpauta.turma = int(input("Turma: "))
            varpauta.aluno = input("Aluno: ")
            varpauta.disciplina = input("Disciplina: ")
            varpauta.m1 = int(input("M1: "))
            varpauta.m2 = int(input("M2: "))
            varpauta.m3 = int(input("M3: "))
            varpauta.notafinal = ((varpauta.m1*0.45) + (varpauta.m2*0.45) + (varpauta.m3*0.10)) / 3
            if varpauta.m1 < 6 or varpauta.m2 < 6:
                     varpauta.aprovado = "Reprovado"
            elif varpauta.notafinal >= 9.5:
                    varpauta.aprovado = "Aprovado"

            listapauta.append(varpauta)

        elif opcG == "5":
            Mostrapauta()
            remov = int(input("Qual a pauta que pretende remover? "))
            listapauta.pop(remov-1)


GuardarFicheiro(caminho)
