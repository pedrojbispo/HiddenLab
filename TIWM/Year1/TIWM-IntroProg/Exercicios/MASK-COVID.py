############## KEEP SAFE COVID-19: ##############
# Adicionar máscaras (Horas de eficiência, Nome/Id, Número de Lavagens, Número Lavagens MAX) (Utilizar Dicionários ou Listas)
# Adicionar Lavagem
# Editar os dados das máscaras
# Remover máscara do sistema
# Apresentar informação das máscaras registadas  

#region Dicas
# dados -> {"nome/ID": [Num. Horas, Num. Lav., Num Lav MAX]}
# 
## Criar:
# dados = {}
# id = "azul05" ou input("nome/ID da máscara")
# 
# l = [0, 0, 0]
# l[0] = 30 ou int(input("Número de horas: "))
# l[1] = 4
# l[2] = 25
# 
# dados.update({id: l})
# 
## Ler:
# print(
# 
# dados -> {"azul05": [30, 4, 25], "azul07": [0, 0, 25], "vermelha01": [40, 5, 10]}
# 
# dados["azul05"] -> [30, 4, 25]
# 
# dados["azul05"][1] -> 4 
#endregion 

#region Dica ficheiro
#  f = open("dadosKSC.ksc","w")
#
# f.write("Eu sou a primeira linha\n")
# f.write("Eu sou a 2a linha\n")
#
# f.close()
#
# f = open("dadosKSC.txt","r")
# print(f.readline())
# f.close()
#endregion

import os
opc = ""
dados = {}

file = "dadosKSC.txt"
if os.path.isfile(file):
    f = open(file, "r")
    line = f.readline()
    while line != "":
        vline = line.split('|')
        dados.update({vline[0]: [vline[1], vline[2], int(vline[3])]})
        print(vline)
        print(dados)
        line = f.readline()
    f.close()

while opc != "0":
    print("########## KEEP SAFE COVID-19: ##########")
    print("\n\n-- MENU --\n")
    print("1) Adicionar Máscara")
    print("2) Editar Máscara")
    print("3) Remover Mascara")
    print("4) Apresentar a(s) Mascara(s) registada(s)")

    print("\n0) Sair")
    opc = input("Opção: ")

    if opc == "1":
        print("\n\n--- Adicionar Máscara ---")
        nome = input("Nome/ID da máscara:")

        l = [0, 0, 0]

        l[0] = int(input("Número de Horas eficaz:"))
        l[1] = int(input("Número de Lavagens:"))
        l[2] = int(input("Número de Lavagens Máximo:"))

        dados.update({nome: l})
        print("\nMascara Adicionada com sucesso!")

f = open("dadosKSC.txt", "w")
for i in dados:
    f.write(i + " | " + str(dados[i][0]) + " | " + str(dados[i][1]) + " | " + str(dados[i][2]), "\n")
f.close()
