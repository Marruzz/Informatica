from chatterbot import ChatBot

# Create a new chatbot instance
chatbot = ChatBot('My ChatBot')

# Get a response to an input statement
response = chatbot.get_response('Hello, how are you?')
print(response)