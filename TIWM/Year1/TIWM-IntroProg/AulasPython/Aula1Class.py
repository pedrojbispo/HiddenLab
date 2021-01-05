class Data():
    
    def __init__(self, dia = 0, mes = 0, ano = 0):
        self.dia = dia
        self.mes = mes
        self.ano = ano

    def MaisRecente(self, data):
        if self.ano > data.ano:
            return True
        elif self.ano < data.ano:
            return False
        else:
            if self.mes > data.mes:
                return True
            elif self.mes < data.mes:
                return False
            else:
                if self.dia > data.dia:
                    return True
                elif self.dia < data.dia:
                    return False
                else:
                    return True

    def __str__(self):
        return str(self.dia) + "/" + str(self.mes) + "/" + str(self.ano)

class Pessoa():
    def __init__(self, nome = "", altura = 0, dataNasc = Data()):
        self.nome = nome
        self.altura = altura
        self.dataNasc = dataNasc
    
    def MaiorAltura(self, pessoa):
        return self.altura > pessoa.altura

    def MaisNovo(self, pessoa):
        return self.dataNasc.MaisRecente(pessoa.dataNasc)


    def __str__(self):
        return self.nome + " - " + str(self.altura) + " - " + str(self.dataNasc)


## EXE 1 Registar e Mostrar uma Pessoa
p1 = Pessoa()

p1.nome = input("Nome: ")
p1.altura = int(input("Altura:"))

print("Data de Nascimento:")
p1.dataNasc.dia = int(input("dia:"))
p1.dataNasc.mes = int(input("mês:"))
p1.dataNasc.ano = int(input("ano:"))

print("Registo:")
print("Nome -> " + p1.nome)
print("Altura -> " + str(p1.altura))
print("Data de Nascimento -> " + str(p1.dataNasc))

print("\n\n" + str(p1))

## EXE 2 Editar data da Pessoa p1

#p1.dataNasc.dia = 12
#p1.dataNasc.mes = 12
#p1.dataNasc.ano = 2010

print("Nova Data de Nascimento do " + p1.nome + ":")
print("Dia:", p1.dataNasc.dia)
print("Mês:", p1.dataNasc.mes)
print("Ano:", p1.dataNasc.ano)

print("\n\n" + str(p1))

## EXE 3 Criar a Pessoa p2 apresentar qual a pessoa mais alta.
#alterar const pessoa (dia mes ano)

d = Data(22,4,1990)
p2 = Pessoa("Pedro", 180, d)

print(p2)

if p1.MaiorAltura(p2) :
    print("A pessoa mais alta é o/a " + p1.nome)
else:
    print("A pessoa mais alta é o/a " + p2.nome)


if p1.MaisNovo(p2) :
    print("A pessoa mais nova é o/a " + p1.nome)
else:
    print("A pessoa mais nova é o/a " + p2.nome)




#p1 = Pessoa()
#p2 = Pessoa("João",170)

#d1 = Data()
#d2 = Data(23,11,2020)

#d1.dia = 25
#d1.mes = 12
#d1.ano = d2.ano

#print(str(d1))
#print(d2.dia,d2.mes,d2.ano,sep="/")


