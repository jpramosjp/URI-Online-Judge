x = float(input())
percentual = float()
reajuste = float()
soma = float()
if x > 0 and x <= 400.00:
    percentual = 15
    reajuste = x * (percentual/100)
    soma = x + reajuste
elif x > 400.00 and x <= 800.00:
    percentual = 12
    reajuste = x * (percentual/100)
    soma = x + reajuste
elif x > 800.00 and x <= 1200.00:
    percentual = 10
    reajuste = x * (percentual/100)
    soma = x + reajuste
elif x > 1200.00 and x <= 2000.00:
    percentual = 7
    reajuste = x * (percentual/100)
    soma = x + reajuste
elif x > 2000.00:
    percentual = 4
    reajuste = x * (percentual/100)
    soma = x + reajuste


print("Novo salario:","{0:0.2f}".format(soma))
print("Reajuste ganho:","{0:0.2f}".format(reajuste))
print("Em percentual:","{0:0.0f}".format(percentual),"%")