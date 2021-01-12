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
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                print("YO")
            elif subop == "2":
                print("YO")
            elif subop == "0":
                print("Voltando para o Menu")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu")
                time.sleep(3)
                bin.clear()