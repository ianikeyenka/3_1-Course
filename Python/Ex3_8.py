IP = '192.168.3.1'
[print('{:<10}'.format(i), end='') for i in IP.split('.')]
print()
[print(bin(int(i))[2:].zfill(8), end='  ') for i in IP.split('.')]
