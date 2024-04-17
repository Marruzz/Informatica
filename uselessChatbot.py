import random

def chatbot():
    responses = {
        random.choice(["hello", "hi", "sup", "yo"]): random.choice(["Hi there!", "Supp", "Hi bro!", "Hey! How you doing?"]),
        random.choice(["how are you", "hyd", "hay"]): "I'm just a program, but I'm functioning well. Thanks for asking!",
        "what's your name": "I'm a chatbot. I don't have a name.",
        "what can you do": "I can have a simple conversation with you.",
        "who created you": "I was created by Luca.",
        "what is the meaning of life": "I'm not sure. What do you think?",
    }

    print("Hi, I'm a simple chatbot!")
    while True:
        user_input = input("You: ").lower()
        if user_input in responses:
            print("Chatbot: " + responses[user_input])
        elif user_input == "quit" or user_input == "exit" or user_input == "bye":
            print("Chatbot: " + random.choice(["Goodbye!", "See you later!", "Bye!", "What a nice chat! Goodbye!"]))
            break
        else:
            print("Chatbot: Sorry, I don't understand.")
chatbot()