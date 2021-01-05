val = int(input("Qual o valor? "))
primo = True
flag = 0

for i in range(2, int(val / 2) + 1):
    flag += 1
    if val % i == 0:
        primo = False
        break

if primo == True:
    print("O número", val, "é primo")
else:
    print("O número", val, "não é primo")

print("Flag ->", flag)