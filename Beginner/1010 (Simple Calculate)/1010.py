a,b,e = input().split(" ")
a = int(a)
b = int(b)
e = float(e)

c,d,f = input().split(" ")
c = int(c)
d = int(d)
f = float(f)

print ("VALOR A PAGAR: R$ ""{:.2f}".format(e*b + d*f))
