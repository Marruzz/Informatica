import random

print("Benvenuti, il gioco sta iniziando!")

punteggioPrimoGiocatore = 0
punteggioSecondoGiocatore = 0
casuale1 = 0
casuale2 = 0
sommacasuale = 0
nCiclo = 0
quit1 = False
quit2 = False

while True:
    nCiclo += 1

    if nCiclo % 2 == 0 and quit2:
        break
    elif nCiclo % 2 != 0 and quit1:
        break

    if nCiclo % 2 == 0:
        print("è il turno del secondo giocatore!")
    else:
        print("è il turno del primo giocatore!")

    print("Il gioco è iniziato, cosa desiderate fare?\n1: Fermati\n2: Genera un numero da 5 a 10\n3: Genera due numeri da 1 a 5")
    scelta = int(input())

    if scelta == 1:
        print("Hai scelto di fermarti, il tuo punteggio è pari a:", punteggioPrimoGiocatore)
        if nCiclo % 2 == 0:
            quit2 = True
        else:
            quit1 = True
    elif scelta == 2:
        print("Hai scelto di generare un numero da 5 a 10")
        casuale1 = random.randint(5, 10)
        if nCiclo % 2 == 0:
            print("Verranno aggiunti al secondo giocatore")
            punteggioSecondoGiocatore += casuale1
            print("Il punteggio del secondo giocatore ammonta a:", punteggioSecondoGiocatore)
        else:
            print("Verranno aggiunti al primo giocatore")
            punteggioPrimoGiocatore += casuale1
            print("Il punteggio del primo giocatore ammonta a:", punteggioPrimoGiocatore)
    elif scelta == 3:
        print("Hai scelto di generare due numeri da 1 a 5")
        casuale1 = random.randint(1, 5)
        casuale2 = random.randint(1, 5)
        sommacasuale = casuale1 * casuale2
        if nCiclo % 2 == 0:
            print("Verranno aggiunti al secondo giocatore")
            punteggioSecondoGiocatore += sommacasuale
            print("Il punteggio del secondo giocatore ammonta a:", punteggioSecondoGiocatore)
        else:
            print("Verranno aggiunti al primo giocatore")
            punteggioPrimoGiocatore += sommacasuale
            print("Il punteggio del primo giocatore ammonta a:", punteggioPrimoGiocatore)

    if punteggioPrimoGiocatore > 100:
        print("Il primo giocatore ha sballato!")
        quit1 = True
    elif punteggioSecondoGiocatore > 100:
        print("Il secondo giocatore ha sballato!")
        quit2 = True

    input("Ora il turno passa all'altro giocatore, premere un qualunque tasto per procedere!")
    print("\n")

if punteggioPrimoGiocatore > punteggioSecondoGiocatore:
    print("Il primo giocatore ha vinto con:", punteggioPrimoGiocatore, ", il secondo perde con", punteggioSecondoGiocatore)
elif punteggioPrimoGiocatore < punteggioSecondoGiocatore:
    print("Il secondo giocatore ha vinto con:", punteggioSecondoGiocatore, ", il primo perde con", punteggioPrimoGiocatore)
else:
    print("I giocatori sono pari!")

input()