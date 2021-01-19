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
                bin.clear()
                bin.Mostraturma()
                time.sleep(3)
                bin.clear()

            elif subop == "2":
                bin.clear()
                varalunos = database.Alunos()
                varalunos.anome = input("Nome do Aluno: ")
                database.listaalunos.append(varalunos)
                bin.clear()
                bin.Mostraaluno()
                time.sleep(3)
                bin.clear()

            elif subop == "3":
                bin.clear()
                vardisc = database.Disciplinas()
                vardisc.discnome = input("Disciplina: ")
                database.listadisciplinas.append(vardisc)
                bin.clear()
                bin.Mostradisciplina()
                time.sleep(3)
                bin.clear()


            elif subop == "4":
                bin.clear()
                varpauta = database.Pauta()
                bin.Mostrapauta()
                varpauta.turma = input("Turma: ")
                varpauta.aluno = input("Aluno: ")
                varpauta.disciplina = input("Disciplina: ")
                varpauta.m1 = None
                varpauta.m2 = None
                varpauta.m3 = None
                while varpauta.m1 == None and varpauta.m2 == None and varpauta.m3 == None:
                    try:
                        varpauta.m1 = int(input("M1: "))
                        varpauta.m2 = int(input("M2: "))
                        varpauta.m3 = int(input("M3: "))
                        if varpauta.m1 < 0 or varpauta.m2 < 0 or varpauta.m3 < 0 or varpauta.m1 > 20 or varpauta.m2 > 20 or varpauta.m3 > 20:
                            print("Erro: Valores introduzidos invalidos. Numeros positivos e inferiores a 20.")
                            varpauta.m1 = None
                            varpauta.m2 = None
                            varpauta.m3 = None
                    except ValueError:
                        print("Erro: Valores introduzidos invalidos. Numeros positivos e inferiores a 20.")
                varpauta.notafinal = (varpauta.m1 + varpauta.m2 + varpauta.m3) / 3
                if varpauta.m1 < 6 or varpauta.m2 < 6 or varpauta.m3 < 6:
                    varpauta.aprovado = "Reprovado"
                elif varpauta.notafinal < 9.5:
                    varpauta.aprovado = "Reprovado"
                elif varpauta.notafinal >= 9.5:
                    varpauta.aprovado = "Aprovado"
                database.listapauta.append(varpauta)
                bin.clear()
                bin.Mostrapauta()
                time.sleep(3)
                bin.clear()

            elif subop == "0":
                bin.clear()
                print("Voltando para o menu...")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu.")
                time.sleep(3)
                bin.clear()
