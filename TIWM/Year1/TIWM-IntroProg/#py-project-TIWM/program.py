# Gestao de Turma
#
# Methods: Add, Show, Remove, Modify
# Files <- Dict{lst:lst}, Turmas, Alunos, Notas da turma
# Dict{Turma} -> Key(Letra): Aluno[ID, Nome, Idade, DataNasc, Altura, Peso, Nacionalidade]
# Dict{Disciplina} -> Key(ID): Disc[NomeDisc]
# Dict{Pauta} -> Key(ID): Pauta[Dict{Turma}, Dict{Disciplina}, M1, M2, Nota Final, Media]
# Calculo das Notas, Media
# Aprovação dos aulos, Media > 10
# Alunos: ID, Nome, Idade, DataNasc, Altura, Peso, Nacionalidade, Turma, Displina, Nota_Displina
#
# -----------------#
import add
import show
import modify
import remove
import bin
import loader
import time
# -----------------#

# bin.LerFicheiro(bin.txtturmas)
# bin.LerFicheiro(bin.txtalunos)
# bin.LerFicheiro(bin.txtdisciplinas)
bin.LerFicheiro(bin.txtpauta)


class Menu:
    op = " "
    while op != "0":
        loader.banner()
        print("="*70, "\n")
        print("\tMenu")
        print("\t\t1- Adicionar...")
        print("\t\t2- Mostrar...")
        print("\t\t3- Editar...")
        print("\t\t4- Remover...")
        print("\t\t5- Guardar...")
        print("\t\t0- Exit")
        print("\n", "=" * 70)
        op = input("Opção: ")

        if op == "1":
            bin.clear()
            add.Adicionar()
        elif op == "2":
            bin.clear()
            show.Mostrar()
        elif op == "3":
            bin.clear()
            modify.Editar()
        elif op == "4":
            bin.clear()
            remove.Apagar()
        elif op == "5":
            # bin.GuardarFicheiro(bin.txtturmas)
            # bin.GuardarFicheiro(bin.txtalunos)
            # bin.GuardarFicheiro(bin.txtdisciplinas)
            bin.GuardarFicheiro(bin.txtpauta)
            print("Gravação dos dados completa...")
            time.sleep(3)
            bin.clear()
        elif op == "0":
            bin.clear()
            print("Programa Terminado.")
        else:
            bin.clear()
            print("Sintaxe Invalida. Por favor Escolha um numero do menu")
            time.sleep(3)
            bin.clear()

