class Game:
    def __init__(self, current_room):
        self.current_room = current_room

    def play(self):
        while True:
            action = input("What do you want to do? ")
            if action == "quit":
                print("Goodbye!")
                break
            else:
                self.current_room.take_action(action)

class Room:
    def __init__(self, description):
        self.description = description

    def take_action(self, action):
        print("You can't do that here.")

    # More room actions and definitions here.

# Define rooms and start the game.
game = Game(Room("You are in a room."))
game.play()