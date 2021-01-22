x = int(input())
y = int(input())
soma = int()
aux = int()
if x > y:
    aux = y
    y = x
    x = aux
    
for i in range (x+1,y):
    if (i % 2) == 1:
        soma = soma +  i

print(soma)