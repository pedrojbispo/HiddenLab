


#print("Turma: ", database.turma[1], "Aluno: ", database.turma[2], "Disciplina: ", database.turma[3], "Nota1: ",database.turma[4],"Nota2: ",database.turma[5],"Nota3: ",database.turma[6],"NotaFInal: ",database.turma[7],"Aprovado: ",database.turma[8],)
class Pauta():
    def __init__(self, aturma="", nome="",disciplina="",m1=0,m2=0,m3=0,notafinal=0,aprovado=""):
        self.aturma = aturma
        self.nome = nome
        self.disciplina = disciplina
        self.m1 = m1
        self.m2 = m2
        self.m3 = m3
        self.notafinal = notafinal
        self.aprovado = aprovado

    def __str__(self):
        return self.aturma + ": " + str(self.aturma) + " | " + str(self.nome) + " | " + str(self.disciplina)+ " | " + str(self.m1)+ " | " + str(self.m2) +" | " + str(self.m3)+ " | " + str(self.notafinal)+ " | " + str(self.aprovado)


class Alunos():
    def __init__(self, nome=""):
        self.nome = nome
    def __str__(self):
        return self.nome

class Turma():
    def __init__(self, letra=""):
        self.letra = letra

    def __str__(self):
        return self.letra



class AlunoTurma():
    def __init__(self,turma="",aluno=""):
        self.turma=turma
        self.aluno=aluno

    def __str__(self):
        return self.turma + " : " + self.aluno



turma = []

def MostrarTurmas():
    cont = 1
    print()
    for i in turma:
        print(str(cont) + "-> " + str(i))
        cont+=1
    print()
