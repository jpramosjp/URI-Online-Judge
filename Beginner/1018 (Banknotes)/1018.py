n = int(input())
print(int(n))
print(int(n/100),"nota(s) de R$ 100,00")
n = n %100
print(int(n/50),"nota(s) de R$ 50,00")
n = n %50
print(int(n/20),"nota(s) de R$ 20,00")
n = n %20
print(int(n/10),"nota(s) de R$ 10,00")
n = n %10
print(int(n/5),"nota(s) de R$ 5,00")
n = n %5
print(int(n/2),"nota(s) de R$ 2,00")
n = n %2
print(int(n),"nota(s) de R$ 1,00")