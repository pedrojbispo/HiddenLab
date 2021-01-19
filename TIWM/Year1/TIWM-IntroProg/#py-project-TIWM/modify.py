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
            print("\t\t2- Aluno")
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                bin.clear()
                bin.Mostrapauta()
                if not database.listapauta:
                    print("Lista Vazia")
                else:
                    pautaid = int(input("Qual é a pauta que quer editar? "))
                    database.listapauta[pautaid - 1].EditarNotas()
                    database.listapauta[pautaid - 1].UpdateNotas()
                    bin.clear()
                    bin.Mostrapauta()
                    time.sleep(3)
                    bin.clear()

            elif subop == "2":
                bin.clear()
                bin.Mostraaluno()
                if not database.listaalunos:
                    print("Lista Vazia")
                else:
                    alunoid = int(input("Qual é a Aluno que quer editar? "))
                    database.listaalunos[alunoid - 1].EditarNome()
                    bin.clear()
                    time.sleep(3)
                    bin.Mostraaluno()
                    bin.clear()

            elif subop == "0":
                bin.clear()
                print("Voltando para o Menu...")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu.")
                time.sleep(3)
                bin.clear()
