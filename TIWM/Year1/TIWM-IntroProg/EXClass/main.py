class Data():

    def __init__(self, dia=0, mes=0, ano=0):
        self.dia = dia
        self.mes = mes
        self.ano = ano
    def Show1(self):
        print(self.dia, self.mes, self.ano)
    def Show2(self):
        return str(self.dia) + "/" + str(self.mes) + "/" + str(self.ano)
    def __str__(self):
        return str(self.dia) + "|" + str(self.mes) + "|" + str(self.ano)

class Pessoa():
    def __init__(self,nome= "",altura = 0,dataNasc= Data()):
        self.nome = nome
        self.altura = altura
        self.dataNasc = dataNasc

    def Show3(self):
        print(str(self.nome) + "|" + str(self.altura) + "|" + str(self.dataNasc))
    def __str__(self):
        return str(self.nome) + "|" + str(self.altura) + "|" + str(self.dataNasc)

p1 = Pessoa()
p2 = Pessoa("João",170)
p1.nome = input("Nome: ")
p1.altura = int(input("Altura: "))
p1.dataNasc.dia = input("dia: ")
p1.dataNasc.mes = input("mes: ")
p1.dataNasc.ano = input("ano: ")

print("Result")
print(p1.nome)
print(p1.altura)
print(p1.dataNasc)

print("Result2")
print()

#d1 = Data()
#d2 = Data(23,11,2020)

#d1.dia = 25
#d1.mes = 12
#d1.ano = 2020

a = 0

#print((str(d1)))
#print(d2.dia,d2.mes,d2.ano,sep="/")

#d2.Show1()
#d2.Show2()
#print("d2:" + d2.Show2())
