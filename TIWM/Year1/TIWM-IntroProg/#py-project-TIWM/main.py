#Gestao de Turma
#
# Methods: Add, Show, Remove, Modify
# Files <- Dict{lst:lst}, Turmas, Alunos, Notas da turma
# Calculo das Notas, Media
# Aprovação dos aulos, Media > 10
# Alunos: ID, Nome, Idade, DataNasc, Altura, Peso, Nacionalidade, Turma, Displina, Nota_Displina
#
import add

op = " "
CMD = open("assets/CMD.txt", "r", encoding="utf8")
print(CMD.read(), "\n")
CMD.close()
while op != "0":
    print("Menu")
    print("\t1- Adicionar...")
    print("\t2- Mostrar...")
    print("\t3- Editar...")
    print("\t4- Remover...")
    print("\t0- Exit")
    op = input("Opção: ")

    if (op == "1"):
        add.add()
        add.yolo()
