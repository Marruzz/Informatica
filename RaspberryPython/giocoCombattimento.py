import random

player1HP = 100
player2HP = 100
turno = random.choice([True, False])  # Scelta casuale del primo giocatore
difesa = False

print("Inizia il combattimento!")

while player1HP > 0 and player2HP > 0:
    if turno:
        print("Punti vita rimanenti: Giocatore 1 =", player1HP, ", Giocatore 2 =", player2HP)
        print("Turno del Giocatore 1 (Attacco o Difesa?)")
        print("1. Attaccare - si infligge un danno all'altro giocatore compreso tra 1 e 20")
        print("2. Difendere - si dimezza il prossimo danno subito")
        scelta = int(input())

        if scelta == 1:
            damage = random.randint(1, 20)
            if difesa:
                damage //= 2
                difesa = False
                print("Invece di infliggere", damage * 2, "il giocatore 1 infligge", damage, "al Giocatore 2")
            player2HP -= damage

        elif scelta == 2:
            print("Il Giocatore 1 si difende.")
            difesa = True

    else:
        print("Punti vita rimanenti: Giocatore 1 =", player1HP, ", Giocatore 2 =", player2HP)
        print("Turno del Giocatore 2 (Attacco o Difesa?)")
        print("1. Attaccare - si infligge un danno all'altro giocatore compreso tra 1 e 20")
        print("2. Difendersi - si dimezza il prossimo danno subito")
        scelta = int(input())

        if scelta == 1:
            damage = random.randint(1, 20)
            if difesa:
                damage //= 2
                difesa = False
                print("Invece di infliggere", damage * 2, "il Giocatore 2 infligge", damage, "al Giocatore 1")
            player1HP -= damage

        elif scelta == 2:
            print("Il Giocatore 2 si difende.")
            difesa = True

    # Controllo della vittoria
    if player1HP <= 0:
        print("Il Giocatore 2 ha vinto il combattimento!")
    elif player2HP <= 0:
        print("Il Giocatore 1 ha vinto il combattimento!")
    else:
        print("Punti vita rimanenti: Giocatore 1 =", player1HP, ", Giocatore 2 =", player2HP)

    turno = not turno  # Cambio del turno