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
                bin.clear()
                bin.Mostraturma()
                if not database.listaturmas:
                    print("Lista Vazia")
                else:
                    remov = int(input("Qual a turma que pretende remover? "))
                    database.listaturmas.pop(remov - 1)
                time.sleep(3)
                bin.clear()

            elif subop == "2":
                bin.clear()
                bin.Mostraaluno()
                if not database.listaalunos:
                    print("Lista Vazia")
                else:
                    remov = int(input("Qual a aluno que pretende remover? "))
                    database.listaalunos.pop(remov - 1)
                time.sleep(3)
                bin.clear()

            elif subop == "3":
                bin.clear()
                bin.Mostradisciplina()
                if not database.listadisciplinas:
                    print("Lista Vazia")
                else:
                    remov = int(input("Qual a displina que pretende remover? "))
                    database.listadisciplinas.pop(remov - 1)
                time.sleep(3)
                bin.clear()

            elif subop == "4":
                bin.clear()
                bin.Mostrapauta()
                if not database.listaalunos:
                    print("Lista Vazia")
                else:
                    remov = int(input("Qual a pauta que pretende remover? "))
                    database.listapauta.pop(remov - 1)
                time.sleep(3)
                bin.clear()

            elif subop == "0":
                bin.clear()
                bin.GuardarFicheiro(bin.caminho)
                print("Voltando para o Menu...")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu.")
                time.sleep(3)
                bin.clear()