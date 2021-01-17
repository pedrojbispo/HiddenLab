# turma = {"ID_Turma": ["Letra_Turma"]}
# aluno = {"ID_Aluno": ["Nome", "Nasc", "Nacionalidade"]}
# disciplina = {"ID_Disciplina": "Nome_disciplina"}
# nested_pauta = { 'turma': {"ID_Turma": "Letra_Turma"},
# 'aluno': {"ID_Aluno": ["Nome"]},
# 'disciplina': {"ID_Disciplina": ["Nome_disciplina", "M1", "M2", "NotaFinal", "isAproved"]}}

# self.notafinal = (m1 * 0.45 + m2 * 0.45 + m3 * 0.10) / 3
# self.aprovado

class Turma():
    def __init__(self, letra=""):
        self.letra = letra


class Alunos():
    def __init__(self, aturma="", nome=""):
        self.aturma = aturma
        self.nome = nome


class Disciplinas():
    def __init__(self, nome=""):
        self.nome = nome




# Data
# nested_pauta = {}
#
# disciplina = {}
# disciplina.update({0: "matematica"})
# disciplina.update({1: "Ingles"})
#
aluno = []
# aluno.update({0: "Pedro"})
# aluno.update({1: "Ze"})
#
turma = []
# turma.update({0: "a"})
# turma.update({1: "b"})
# turma.update({2: "c"})
# turma.update({3: "d"})
