guesses = 6
wrong_letters = []
right_letters = []

word = input("Введите слово: ")
print("\n" * 100)
for i in word:
    right_letters.append("_")

while "_" in right_letters and guesses > 0:
    print("Неправильные буквы: " + str(wrong_letters))
    print("Правильные буквы: " + str(right_letters))
    print("У вас осталось " + str(guesses) + " шанса.")
    letter = input("Введите букву ")
    print("")

    if letter not in wrong_letters and letter not in right_letters:
        found = False
        for i in range(len(word)):
            if letter == word[i]:
                right_letters[i] = letter
                found = True
        if not found:
            guesses -= 1
            wrong_letters.append(letter)
    else:
        print("Вы уже выбирали эту букву")

    if guesses == 6:
        print(' ____')
        print('|    |')
        print('|    |')
        print('|')
        print('|')
        print('|')
        print('|')
        print('|')
        print('=========')

    if guesses == 5:
        print(' ____')
        print('|    |')
        print('|    |')
        print('|    o')
        print('|')
        print('|')
        print('|')
        print('|')
        print('=========')

    if guesses == 4:
        print(' ____')
        print('|    |')
        print('|    |')
        print('|    o')
        print('|    |')
        print('|')
        print('|')
        print('|')
        print('=========')

    if guesses == 3:
        print(' ____')
        print('|    |')
        print('|    |')
        print('|    o')
        print('|   /|')
        print('|')
        print('|')
        print('|')
        print('=========')

    if guesses == 2:
        print(' ____')
        print('|    |')
        print('|    |')
        print('|    o')
        print('|   /|\ ')
        print('|')
        print('|')
        print('|')
        print('=========')

    if guesses == 1:
        print(' ____')
        print('|    |')
        print('|    |')
        print('|    o')
        print('|   /|\ ')
        print('|   /')
        print('|')
        print('|')
        print('=========')

if "_" not in right_letters:
    print(right_letters)
    print("Вы победили!")

else:
    print(' ____')
    print('|    |')
    print('|    |')
    print('|    o')
    print('|   /|\ ')
    print('|   / \ ')
    print('|')
    print('|')
    print('=========')
    print("Человека повесили по вашей вине.")
    print("Правильное слово: " + word)

input("")