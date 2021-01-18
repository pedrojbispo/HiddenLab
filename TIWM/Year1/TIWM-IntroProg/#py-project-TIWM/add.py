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
                lturma = database.Turma()
                lturma.letra = input("Qual é a Letra da Turma: ")
                database.turma.append(lturma)

                time.sleep(3)
                bin.clear()

            elif subop == "2":

                laluno = database.Alunos()
                associaraluno = database.AlunoTurma()
                lturma=database.Turma()
                laluno.nome = input("Qual é o Nome do aluno: ")

                laluno.nome=associaraluno.aluno
                if database.turma != 0:

                    database.MostrarTurmas()
                    lturma.letra=input("Qual a letra da turma onde quer adicionar: ")
                    lturma.letra=associaraluno.turma

                database.turma.append(lturma.letra)
                database.turma.append(laluno.nome)



                time.sleep(3)
                bin.clear()

            elif subop == "3":
                ldisciplina = database.Alunos()
                ldisciplina.disciplina = input("Qual é a disciplina que quer adicionar: ")

                database.turma.append(ldisciplina.disciplina)
                print("Turma: " ,database.turma[1], "Aluno: ",database.turma[2], "Disciplina: ",database.turma[3])
                time.sleep(3)
                bin.clear()

            elif subop == "4":

                for i in database.turma:
                    nota1=database.Alunos()
                    nota2 = database.Alunos()
                    nota3 = database.Alunos()
                    notafinal = database.Alunos()
                    aprovado = database.Alunos()

                    nota1.m1=int(input("Introduza a primeira nota: "))
                    nota2.m2 = int(input("Introduza a segunda nota: "))
                    nota3.m3 = int(input("Introduza a terceira nota: "))
                    notafinal.notafinal=(nota1.m1+nota2.m2+nota3.m3)/3

                    aprovado.aprovado=True
                    if nota1.m1 < 6 or nota2.m2 < 6 or nota3.m3 < 6 or notafinal.notafinal < 9.5:
                        aprovado.aprovado=False
                    else:
                        aprovado.aprovado=True

                    database.turma.append(nota1.m1)
                    database.turma.append(nota2.m2)
                    database.turma.append(nota3.m3)
                    database.turma.append(notafinal.notafinal)
                    database.turma.append(aprovado.aprovado)





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
