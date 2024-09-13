import tkinter as tk
from tkinter import messagebox

# Crea la scacchiera di gioco
board = [[' ' for _ in range(3)] for _ in range(3)]

# Crea la finestra principale
window = tk.Tk()
window.title("Tris")


current_player = 'X'
# Crea i pulsanti per la scacchiera di gioco
buttons = []
for i in range(3):
    row = []
    for j in range(3):
        button = tk.Button(window, text=' ',
                           width=10,
                           height=5,
                           command=lambda r=i,
                           c=j: make_move(r, c),
                           font=("Arial", 20),
                           fg="blue" if current_player == 'X' else "red")
        button.grid(row=i, column=j)
        row.append(button)
    buttons.append(row)


# Funzione per gestire il clic sul pulsante e fare una mossa
def make_move(row, col):
    global current_player

    # Controlla se la cella selezionata è vuota
    if board[row][col] == ' ':
        # Aggiorna la scacchiera e il testo del pulsante
        board[row][col] = current_player
        buttons[row][col].config(text=current_player)

        # Controlla se c'è una vittoria
        if check_win(current_player):
            messagebox.showinfo("Fine del gioco", f"Il giocatore {current_player} vince!")
            reset_game()
        # Controlla se c'è un pareggio
        elif check_draw():
            messagebox.showinfo("Fine del gioco", "È un pareggio!")
            reset_game()
        else:
            # Passa all'altro giocatore
            current_player = 'O' if current_player == 'X' else 'X'

# Funzione per controllare se c'è una vittoria
def check_win(player):
    # Controlla le righe
    for row in board:
        if row.count(player) == 3:
            return True

    # Controlla le colonne
    for col in range(3):
        if [board[row][col] for row in range(3)].count(player) == 3:
            return True

    # Controlla le diagonali
    if board[0][0] == board[1][1] == board[2][2] == player:
        return True
    if board[0][2] == board[1][1] == board[2][0] == player:
        return True

    return False

# Funzione per controllare se c'è un pareggio
def check_draw():
    for row in board:
        if ' ' in row:
            return False
    return True

# Funzione per ripristinare il gioco
def reset_game():
    global current_player

    # Pulisci la scacchiera
    for i in range(3):
        for j in range(3):
            board[i][j] = ' '
            buttons[i][j].config(text=' ')

    # Reimposta il giocatore corrente
    current_player = 'X'

# Avvia il gioco
window.mainloop()