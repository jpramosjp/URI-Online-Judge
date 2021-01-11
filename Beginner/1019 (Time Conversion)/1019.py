n = int(input())
print(int(n/3600),":",sep="", end="")
n = n % 3600 
print (int(n/60),":",sep="", end="")
n = n %60 
print(int(n))

