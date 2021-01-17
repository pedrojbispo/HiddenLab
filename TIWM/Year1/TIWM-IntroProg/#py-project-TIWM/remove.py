import database
import bin
import loader
import time


class Apagar:
    def __init__(self):
        subop = ""
        while subop != "0":
            loader.banner()
            print("=" * 70, "\n")
            print("\tSubMenu - Remover")
            print("\t\t1- Turma")
            print("\t\t2- Aluno")
            print("\t\t3- Disciplina")
            print("\t\t4- Pauta")
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                rm_turma=int(input("Qual a turma que quer remover? "))
            elif subop == "2":
                rm_aluno=int(input("Qual o aluno que quer remover? "))
            elif subop == "3":
                rm_disciplina=int(input("Qual a disciplina que quer remover? "))
            elif subop == "4":
                rm_pauta=int(input("Qual a pauta que quer remover? "))
            elif subop == "0":
                print("Voltando para o Menu")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu")
                time.sleep(3)
                bin.clear()