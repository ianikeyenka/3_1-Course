ip_address = str(input())
value = int(ip_address.split('.')[0])
ip_address_class = 'unused'
if 1 <= value <= 223:
    ip_address_class = 'unicast'
elif 224 <= value <= 239:
    ip_address_class = 'multicast'
elif str(ip_address) in '255.255.255.255':
    ip_address_class = 'local broadcast'
elif ip_address in '0.0.0.0':
    ip_address_class = 'unassigned'
print(ip_address_class)
