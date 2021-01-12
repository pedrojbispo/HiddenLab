import database
import bin
import loader
import time


class Adicionar:
    def __init__(self):
        subop = ""
        while subop != "0":
            loader.banner()
            print("=" * 70, "\n")
            print("\tSubMenu - Adicionar")
            print("\t\t1- Turma")
            print("\t\t2- Aluno")
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                print("YO")
            elif subop == "2":
                print("YO")
            elif subop == "0":
                print("Voltando para o menu")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu")
                time.sleep(3)
                bin.clear()