x = -12
yMax = x
yMin = x
xMax = x
xMin = x
zero = x

while x >= -12 and x <= 16:
    y = x ** 6 - 3 * x ** 5 - 93 * x ** 4 - 87 * x ** 3 + 1596 * x ** 2 - 1380 * x - 2800

    if y > yMax:
        yMax = y
        xMax = x
    elif y < yMin:
        yMin = y
        xMin = x
    elif y == 0:
        zero = x

    x += 1

print("Il valore x con il quale la y è maggiore è =", xMax)
print("Il valore x con il quale la y è minore è =", xMin)
print("Il valore x con il quale il polinomio è nullo è =", zero)