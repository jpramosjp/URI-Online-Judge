n = int(input())
acmIn = int()
acmOut = int()

for i in range(0,n):
    x = int(input())
    if x >= 10 and x <= 20:
        acmIn += 1
    else:
        acmOut += 1

print(acmIn, "in")
print(acmOut, "out")