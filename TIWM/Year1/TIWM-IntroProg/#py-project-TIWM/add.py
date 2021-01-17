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
            print("\t\t4- Pauta")
            print("\t\t0- Exit")
            print("\n")
            print("=" * 70)
            subop = input("Opção: ")

            if subop == "1":

                ID_Turma = int(input("Qual o id da turma"))
                Letra_turma = input("Qual a letra da turma? ")
                database.turma.update({ID_Turma: [Letra_turma]})
                database.nested_pauta['turma']['ID_Turma']=ID_Turma
                database.nested_pauta['turma']['Letra_Turma'] = Letra_turma

                time.sleep(3)
                bin.clear()

            elif subop == "2":

                ID_Aluno = input("Qual o id do aluno?  ")
                Nome = input("Qual o nome do aluno? ")
                Nasc = input("Qual a sua data de nascimento? ")
                Nacionalidade = input("Qual a sua nacionalidade? ")


                database.nested_pauta['aluno']['ID_Aluno']=ID_Aluno
                database.nested_pauta['aluno']['Nome'] = Nome
                database.aluno.update({ID_Aluno: [Nome, Nasc, Nacionalidade]})
                time.sleep(3)
                bin.clear()

            elif subop == "3":

                ID_Disciplina=int(input("Qual é o id da disciplina? "))
                Nome_disciplina = input("Qual o nome da disciplina? ")


                database.nested_pauta['disciplina']['ID_Disciplina']=ID_Disciplina
                database.nested_pauta['disciplina']['Nome_disciplina'] = Nome_disciplina
                database.disciplina.update({ID_Disciplina : [Nome_disciplina]})

                time.sleep(3)
                bin.clear()

            elif subop == "4":


                M1 = int(input("Qual é a primeira nota? "))
                M2 = int(input("Qual é a segunda nota? "))
                nota_final = (M1 + M2) / 2
                if M1 < 6 or M2 < 6:
                    isAproved = False
                elif nota_final >= 9.5:
                    isAproved = True


                database.nested_pauta['disciplina']['M1'] = M1
                database.nested_pauta['disciplina']['M2'] = M2
                database.nested_pauta['disciplina']['NotaFinal'] = nota_final
                database.nested_pauta['disciplina']['isAproved'] = isAproved

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
