num1 = 1
num2 = 1

print(num1, end="\t")
print(num2, end="\t")

for i in range(13):
    numX = num1 + num2
    print(numX, end="\t")
    num1 = num2
    num2 = numX
