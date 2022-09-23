num_list = [10, 2, 30, 100, 10, 50, 11, 30, 15, 7]
word_list = ['python', 'ruby', 'perl', 'ruby', 'perl', 'python', 'ruby', 'perl']
key = 'ruby'
value = word_list
print(len(value) - value[::-1].index(key) - 1)
