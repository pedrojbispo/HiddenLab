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
            print("\t\t3- Associar Aluno a uma turma")
            print("\t\t4- Disciplina")
            print("\t\t5- Notas")
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                lturma = database.Turma()
                lturma.letra = input("Qual é a Letra da Turma: ")
                database.turma.append(lturma)
                print("Turma: ",database.turma[0].letra)
                time.sleep(3)
                bin.clear()

            elif subop == "2":

                laluno = database.Alunos()
                laluno.nome = input("Qual é o Nome do aluno: ")
                laluno.aturma = input("Qual é a Turma do aluno: ")
                database.aluno.append(laluno)
                print(database.aluno[0].aturma,database.aluno[0].nome)
                time.sleep(3)
                bin.clear()

            elif subop == "3":

                #Turma|Aluno
                time.sleep(3)
                bin.clear()

            elif subop == "4":

                for i in database.disciplina:
                    nota1=int(input("Introduza a primeira nota: "))
                    nota2 = int(input("Introduza a segunda nota: "))
                    nota_final=(nota1+nota2)/2

                    isAproved=True
                    if nota1<6 or nota2 <6 or nota_final<9.5:
                        isAproved=False
                    else:
                        isAproved=True

                    database.disciplina.update({})



                time.sleep(3)
                bin.clear()

            elif subop == "0":
                print("Voltando para o menu")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu")
                time.sleep(3)
                bin.clear()
