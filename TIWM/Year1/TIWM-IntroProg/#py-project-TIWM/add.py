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
            print("\t\t3- Disciplna")
            print("\t\t4- Pauta")
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":
                id_turma =+ 1
                turma=input("Qual a letra da turma? ")


                database.turma.append([id_turma])
                database.turma.append([turma])


                time.sleep(5)


                bin.clear()
            elif subop == "2":
                id_aluno = input("Qual o id do aluno?  ")
                nome_aluno = input("Qual o nome do aluno? ")
                nascimento = input("Qual a sua data de nascimento? ")
                nacionalidade = input("Qual a sua nacionalidade? ")



                database.aluno.append([id_aluno])
                database.aluno.append([nome_aluno])
                database.aluno.append([nascimento])
                database.aluno.append([nacionalidade])


                time.sleep(5)

                bin.clear()

            elif subop=="3":
                id_disciplina=input("Qual o id da disciplina? ")
                nome_disciplina = input("Qual o nome da disciplna? ")

                database.disciplina.append([id_disciplina])
                database.disciplina.append([nome_disciplina])

                print(database.disciplina)
                time.sleep(5)

                bin.clear()

            elif subop=="4":
                for i in database.turma:

                    print("Turmas", (database.turma[i][0]))
                for i in database.aluno:

                    print("Alunos", database.aluno[i][1])
                for i in database.disciplina:

                    print("Disciplina", database.disciplina[i][1])


            elif subop == "0":
                print("Voltando para o menu")
                bin.clear()
            else:
                bin.clear()
                print("Sintaxe Invalida. Por favor Escolha um numero do menu")
                time.sleep(3)
                bin.clear()