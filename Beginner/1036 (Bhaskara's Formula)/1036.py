a,b,c = input().split()

a = float(a)
b = float(b)
c = float(c)

delta = float((b * b) -4 * (a * c))

if a <=0 or delta < 0:
    print("Impossivel calcular")
else:
    print("R1 =","{:.5f}".format(((-b) + (delta **0.5))/(2*a)))
    print("R2 =","{:.5f}".format(((-b) - (delta **0.5))/(2*a)))