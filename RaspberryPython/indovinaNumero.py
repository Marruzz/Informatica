import random

# Genera un numero casuale tra 1 e 100
numero_segreto = random.randint(1, 100)

# Inizializza il numero di tentativi
num_tentativi = 0

print("Benvenuto al gioco Indovina il Numero!")

while True:
    # Ottieni il tentativo dell'utente
    tentativo = int(input("Inserisci il tuo tentativo (tra 1 e 100): "))
    # Incrementa il numero di tentativi
    num_tentativi += 1
    # Controlla se il tentativo è corretto
    if tentativo == numero_segreto:
        print("Congratulazioni! Hai indovinato il numero in", num_tentativi, "tentativi.")
        break
    elif tentativo < numero_segreto:
        print("Troppo basso! Prova ancora.")
    else:
        print("Troppo alto! Prova ancora.")
