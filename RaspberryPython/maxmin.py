print("Quanti valori deve avere il vettore?")
grandezzaVettore = int(input())
vettorePrezzi = [0] * grandezzaVettore
frequenzePrezzi = [0] * grandezzaVettore
somma = 0
i = 0
secondoVettore = [0] * grandezzaVettore
valoreScontato = 0
y = 0
vettoreOrdineDecrescente = [0] * grandezzaVettore

# inserimento di un nuovo prezzo
for i in range(len(vettorePrezzi)):
    print("Inserisci un prezzo")
    vettorePrezzi[i] = float(input())
    # calcolo somma se vettorePrezzi[i] > 10
    if vettorePrezzi[i] > 10:
        somma += vettorePrezzi[i]

# trova il prezzo dato l'indice
print("Inserisci l'indice di cui vuoi trovare il prezzo")
prezzoIndice = int(input())
print("Il prezzo dell'indice", prezzoIndice, "è", vettorePrezzi[prezzoIndice])

# media prezzo>10
media = somma / i
print("La media è", media)

# prezzo minimo e massimo
prezzoMinimo = vettorePrezzi[0]
prezzoMassimo = vettorePrezzi[0]
for i in range(len(vettorePrezzi)):
    if vettorePrezzi[i] > prezzoMassimo:
        prezzoMassimo = vettorePrezzi[i]
    if vettorePrezzi[i] < prezzoMinimo:
        prezzoMinimo = vettorePrezzi[i]
print("Il prezzo minimo è", prezzoMinimo, "e il prezzo massimo è", prezzoMassimo)

# ordinamento in ordine crescente
for i in range(len(vettorePrezzi) - 1):
    for y in range(i + 1, len(vettorePrezzi)):
        if vettorePrezzi[i] > vettorePrezzi[y]:
            temp = vettorePrezzi[i]
            vettorePrezzi[i] = vettorePrezzi[y]
            vettorePrezzi[y] = temp

for i in range(len(vettorePrezzi)):
    print(vettorePrezzi[i])

# prodotti con lo stesso prezzo
for i in range(1, len(vettorePrezzi) - 1):
    if vettorePrezzi[i] == vettorePrezzi[i - 1]:
        frequenzePrezzi[i] += 1

for i in range(len(vettorePrezzi)):
    print("")

# Creazione di un secondo vettore con sconto del 10% sui prezzi maggiori di 20
for y in range(len(secondoVettore)):
    secondoVettore[y] = 0
dimensioneScontato = 0

for y in range(len(vettorePrezzi)):
    if vettorePrezzi[y] > 20:
        valoreScontato = vettorePrezzi[y] / 100 * 10
        secondoVettore[dimensioneScontato] = vettorePrezzi[dimensioneScontato] - valoreScontato
        dimensioneScontato += 1
        print("Il prezzo del valore", vettorePrezzi[dimensioneScontato], "scontato del 20% è", secondoVettore[dimensioneScontato])

# Creazione di un terzo vettore con prezzi ordinati in ordine decrescente
PrezziDecrescente = [0] * grandezzaVettore
IndiceDecrescente = 0

for i in range(len(vettorePrezzi) - 1, -1, -1):
    PrezziDecrescente[IndiceDecrescente] = vettorePrezzi[i]
    print(PrezziDecrescente[IndiceDecrescente])

# Inserimento ordinato nel terzo vettore