n = int(input())

p1 = 0 #divide by 2 without reminder
p2 = 0 #divide by 3 without reminder
p3 = 0 #divide by 4 without reminder

for i in range(0, n):
    num = int(input())
    if num % 2 == 0:
        p1 += 1
    if num % 3 == 0:
        p2 += 1
    if num % 4 == 0:
        p3 += 1

p1 = (p1 / n) * 100
p2 = (p2 / n) * 100
p3 = (p3 / n) * 100

print(f'{p1:.2f}%')
print(f'{p2:.2f}%')
print(f'{p3:.2f}%')
