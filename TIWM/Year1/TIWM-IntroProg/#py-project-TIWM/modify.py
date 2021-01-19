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
            print("\t\t1- Pauta")
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                if not database.listaturmas:
                    print("Lista Vazia")
                else:
                    print("to-do")
                    time.sleep(3)
                    bin.clear()
            elif subop == "0":
                bin.clear()
                print("Voltando para o Menu")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu")
                time.sleep(3)
                bin.clear()