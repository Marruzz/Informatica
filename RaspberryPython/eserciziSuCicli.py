numeroDiElementi = int(input("Inserisci il numero di elementi che vuoi visionare: "))
valoreDaCercare = int(input("Inserisci il valore da cercare: "))
valoreTrovato = 0

for i in range(numeroDiElementi):
    valore = int(input("Inserisci il valore: "))
    if valore == valoreDaCercare:
        valoreTrovato += 1

print("Il valore", valoreDaCercare, "è stato trovato", valoreTrovato, "volte")


while True:
    p = float(input("Inserisci il peso ideale del prodotto: "))
    if p == 0:
        break
    print("Inserisci lo scarto, in eccesso o in difetto, del peso del prodotto: ")
    s = float(input())
    print("Inserisci il peso del prodotto: ")
    pesoProdotto = float(input())
    if pesoProdotto != p:
        if pesoProdotto - s > p:
            pesoEccesso = pesoProdotto - p
            print("Il peso del prodotto è troppo grande: " + str(pesoEccesso) + " g di troppo")
        elif pesoProdotto + s < p:
            pesoDifetto = p - pesoProdotto
            print("Il peso del prodotto è troppo piccolo: " + str(pesoDifetto) + " g di difetto")