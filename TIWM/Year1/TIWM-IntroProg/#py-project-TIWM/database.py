dados = {}
listaturmas = []
listaalunos = []
listadisciplinas = []
listapauta = []


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
    def __init__(self, turma="", aluno="", disciplina="", m1=0, m2=0, m3=0, notafinal=0,aprovado=" "):
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
