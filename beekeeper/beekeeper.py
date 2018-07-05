vowels = ["aa", "ee", "ii", "oo", "uu", "yy"]
while True:
    n = int(input())  # first input (amount of test cases)
    if n == 0:  # if the integer seen is 0, stop the function
        break
    words = [input() for _ in range(n)]  # divide words to check up into list

    best = -1  # Needs to be lower than 0 so that temp is always better than best (otherwise the case where no words have two consequtive vowels wouldn't be accepted).
    result = []
    for i in range(len(words)):  # iterate over each word, checking how many double vowels in each
        temp = sum([words[i].count(x) for x in vowels])
        if temp > best:
            best = temp
            result = words[i]  # select the word with the most consequtive vowels.
    print(result)
