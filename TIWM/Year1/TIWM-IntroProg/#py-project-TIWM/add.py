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
            print("\t\t3- Disciplina")
            print("\t\t4- Notas")
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                bin.clear()
                varturmas = database.Turmas()
                varturmas.listaturma = input("Turma: ")
                database.listaturmas.append(varturmas)
                time.sleep(3)
                bin.clear()

            elif subop == "2":
                bin.clear()
                varalunos = database.Alunos()
                varalunos.anome = input("Nome do Aluno: ")
                database.listaalunos.append(varalunos)
                time.sleep(3)
                bin.clear()

            elif subop == "3":
                bin.clear()
                vardisc = database.Disciplinas()
                vardisc.discnome = input("Disciplina: ")
                database.listadisciplinas.append(vardisc)
                time.sleep(3)
                bin.clear()

            elif subop == "4":
                bin.clear()
                varpauta = database.Pauta()
                bin.Mostraturma()
                varpauta.turma = input("Turma: ")
                varpauta.aluno = input("Aluno: ")
                varpauta.disciplina = input("Disciplina: ")
                varpauta.m1 = int(input("M1: "))
                varpauta.m2 = int(input("M2: "))
                varpauta.m3 = int(input("M3: "))
                varpauta.notafinal = (varpauta.m1 + varpauta.m2 + varpauta.m3) / 3
                if varpauta.m1 < 6 or varpauta.m2 < 6:
                    varpauta.aprovado = "Reprovado"
                elif varpauta.notafinal >= 9.5:
                    varpauta.aprovado = "Aprovado"

                database.listapauta.append(varpauta)
                time.sleep(3)
                bin.clear()

            elif subop == "0":
                bin.clear()
                bin.GuardarFicheiro(bin.caminho)
                print("Voltando para o menu...")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu.")
                time.sleep(3)
                bin.clear()
