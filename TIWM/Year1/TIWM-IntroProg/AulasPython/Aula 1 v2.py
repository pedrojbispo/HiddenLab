#Escrever info no ecrã
print("Python VS Covid-19")

nome = ""
nome = input("Qual o seu nome: ") #Ler info utilizador

print("O nome é " + nome)
print("O nome é", nome)

idade = int(input("Qual a sua idade:"))

# operadores: = + - * / %
# operadores lógicos: < > <= >= == !=

if idade < 40:
    print("O utilizador/a é novo/a!!!")
elif idade < 60:
    print("O utilizador/a é adulto/a!!!")
else:
    print("O utilizador/a é velho/a!!!")

txt = ""
for i in range(idade, 0, -1):
    if i > 1:
        txt = txt + str(i) + " | "
        print(i, end=" | ")
    else:
        txt = txt + str(i)
        print(i)



print(txt)



