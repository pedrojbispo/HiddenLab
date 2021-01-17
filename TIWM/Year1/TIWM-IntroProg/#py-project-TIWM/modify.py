import database
import bin
import loader
import time


class Editar:
    def __init__(self):
        subop = ""
        while subop != "0":
            loader.banner()
            print("=" * 70, "\n")
            print("\tSubMenu - Editar")
            print("\t\t1- Turma")
            print("\t\t2- Aluno")
            print("\t\t3- Disciplina")
            print("\t\t4- Pauta") 
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                editar_turma=int(input("Qual a turma que quer editar? "))
            elif subop == "2":
                editar_aluno=int(input("Qual o aluno que quer editar? "))
            elif subop == "3":
                editar_disciplina=int(input("Qual a disciplina que quer editar? "))  
            elif subop == "4":
                editar_pauta=int(input("Qual a pauta que quer editar? "))
            elif subop == "0":
                print("Voltando para o Menu")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu")
                time.sleep(3)
                bin.clear()