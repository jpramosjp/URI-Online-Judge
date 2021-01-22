acmP = int()
aux = float()

for i in range (6):
    x = float(input())
    if(x > 0):
        acmP += 1
        aux = aux + x


print(acmP, "valores positivos")
print("{:0.1f}".format(aux/acmP))