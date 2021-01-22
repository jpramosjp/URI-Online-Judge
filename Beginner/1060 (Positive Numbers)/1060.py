n = [6]
acm = int()


for i in range (0,6,1):
    n.append(float(input()))
    if n[i] > 0:
        acm += 1
    else:
        continue
print (acm ,"valores positivos")