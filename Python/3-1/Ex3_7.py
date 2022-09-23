MAC = 'AAAA:BBBB:CCCC'
print('\t'.join([bin(int(i, 16)) for i in MAC.split(':')]))