CONFIG = 'switchport trunk allowed vlan 1,3,10,20,30,100'
print(CONFIG.split().pop(-1).split(','))
