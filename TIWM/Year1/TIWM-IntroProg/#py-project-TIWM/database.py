dados = {}
listaturmas = []
listaalunos = []
listadisciplinas = []
listapauta = []


class Turmas():
    def __init__(self, listaturma=""):
        self.listaturma = listaturma

    def Adicionarturma(self):
        self.listaturma = self.listaturma

    def StringFicheiro(self):
        return self.listaturma + "\n"

    def __str__(self):
        return self.listaturma

class Alunos():
    def __init__(self, anome=""):
        self.anome = anome

    def EditarNome(self):
        self.anome = input("Nome:")

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
    def __init__(self, turma="", aluno="", disciplina="", m1=0, m2=0, m3=0, notafinal=0,aprovado=" "):
        self.turma = turma
        self.aluno = aluno
        self.disciplina = disciplina
        self.m1 = m1
        self.m2 = m2
        self.m3 = m3
        self.notafinal = notafinal
        self.aprovado = aprovado

    def EditarNotas(self):
        self.m1 = None
        self.m2 = None
        self.m3 = None
        while self.m1 == None and self.m2 == None and self.m3 == None:
            try:
                self.m1 = int(input("M1: "))
                self.m2 = int(input("M2: "))
                self.m3 = int(input("M3: "))
                if self.m1 < 0 or self.m2 < 0 or self.m3 < 0 or self.m1 > 20 or self.m2 > 20 or self.m3 > 20:
                    print("Erro: Valores introduzidos invalidos. Numeros positivos e inferiores a 20.")
                    self.m1 = None
                    self.m2 = None
                    self.m3 = None
            except ValueError:
                print("Erro: Valores introduzidos invalidos. Numeros positivos e inferiores a 20.")

    def UpdateNotas(self):
        self.notafinal = (self.m1 + self.m2 + self.m3) / 3
        if self.m1 < 6 or self.m2 < 6 or self.m3 < 6:
            self.aprovado = "Reprovado"
        elif self.notafinal < 9.5:
            self.aprovado = "Reprovado"
        else:
            self.aprovado = "Aprovado"

    def ShowAprovados(self):
        if self.aprovado == "Aprovado":
            print(self.turma + "|" + str(self.aluno) + "|" + str(self.disciplina) + "|" + str(self.m1) + "|" + str(self.m2) + "|" + str(self.m3) + "|" + str(self.notafinal) + "|" + str(self.aprovado))

    def StringFicheiro(self):
        return self.turma + "|" + str(self.aluno) + "|" + str(self.disciplina) + "|" + str(self.m1) + "|" + str(self.m2) + "|" + str(self.m3) + "|" + str(self.notafinal) + "|" + str(self.aprovado) + "\n"

    def __str__(self):
        return self.turma + "|" + str(self.aluno) + "|" + str(self.disciplina) + "|" + str(self.m1) + "|" + str(self.m2) + "|" + str(self.m3) + "|" + str(self.notafinal) + "|" + str(self.aprovado)
