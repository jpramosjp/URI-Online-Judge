acmPar = int() 
acmImpar = int()
acmPositivo = int()
acmNegativo = int()

for i in range (5):
    x = int(input())
    if x > 0:
        acmPositivo += 1
    elif x < 0:
        acmNegativo +=1
    if (x % 2) == 0:
        acmPar += 1
    else:
        acmImpar +=1
print(acmPar, "valor(es) par(es)")
print(acmImpar, "valor(es) impar(es)")
print(acmPositivo, "valor(es) positivo(s)")
print(acmNegativo, "valor(es) negativo(s)")
  
