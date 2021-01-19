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
            print("\t\t1- Mostrar Turmas")
            print("\t\t2- Mostrar Aluno")
            print("\t\t3- Mostrar Pauta")
            print("\t\t0- Menu")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                bin.clear()
                bin.Mostraturma()
                time.sleep(3)
                bin.clear()

            elif subop == "2":
                bin.clear()
                bin.Mostraaluno()
                time.sleep(3)
                bin.clear()

            elif subop == "3":
                bin.clear()
                bin.Mostrapauta()
                time.sleep(3)
                bin.clear()
            elif subop == "0":
                print("Voltando para o Menu...")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu.")
                time.sleep(3)
                bin.clear()