def calcoloTriangolo(base, altezza):
    return base * altezza / 2


def calcoloRettangolo(base, altezza):
    return base * altezza

base = float(input("Inserisci la base"))
altezza = float(input("Inserisci l'altezza"))

area = input("Inserisci t per triangolo e r per rettangolo")
if area== "t":
    print(calcoloTriangolo(base, altezza))
elif area== "r":
    print(calcoloRettangolo(base, altezza))
else:
    print("Scelta non valida")
