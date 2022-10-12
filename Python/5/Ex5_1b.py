def test_value(address):
    test_correct_input = False
    if len(address) == 4:
        if address:
            for i in address:
                if i.isdigit():
                    if int(i) > 255 or int(i) < 0:
                        test_correct_input = False
                        break
                    else:
                        test_correct_input = True
                else:
                    break
    return test_correct_input


def define_ip_class(address):
    value = int(address.split('.')[0])
    ip_address_class = 'unused'
    if 1 <= value <= 223:
        ip_address_class = 'unicast'
    elif 224 <= value <= 239:
        ip_address_class = 'multicast'
    elif str(address) in '255.255.255.255':
        ip_address_class = 'local broadcast'
    elif address in '0.0.0.0':
        ip_address_class = 'unassigned'
    print(ip_address_class)


while True:
    ip_address = str(input())
    if test_value(ip_address.split('.')):
        define_ip_class(ip_address)
        break
