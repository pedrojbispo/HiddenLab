import database
import bin
import loader
import time


class Mostrar:
    def __init__(self):
        subop = ""
        while subop != "0":
            loader.banner()
            print("=" * 70, "\n")
            print("\tSubMenu - Mostrar")
            print("\t\t1- Mostar Turmas")
            print("\t\t2- Mostar Turma...")
            print("\t\t3- Mostar Aluno")
            print("\t\t4- Mostar Alunos")
            print("\t\t5- Mostar Media do Aluno por disciplina")
            print("\t\t6- Mostar Medias de todos os Alunos de uma turma por disciplina")
            print("\t\t0- Menu")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                print("YO")
            elif subop == "2":
                print("YO")
            elif subop == "3":
                print("YO")
            elif subop == "4":
                print("YO")
            elif subop == "5":
                print("YO")
            elif subop == "6":
                print("YO")
            elif subop == "0":
                print("Voltando para o Menu")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu")
                time.sleep(3)
                bin.clear()