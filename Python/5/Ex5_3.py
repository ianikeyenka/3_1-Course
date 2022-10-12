access_template = ['switchport mode access',
                   'switchport access vlan',
                   'spanning-tree portfast',
                   'spanning-tree bpduguard enable']
trunk_template = ['switchport trunk encapsulation dot1q',
                  'switchport mode trunk',
                  'switchport trunk allowed vlan']
fast_int = {'access': {'0/12': '10', '0/14': '11', '0/16': '17', '0/17': '150'},
            'trunk': {'0/1': ['add', '10', '20'],
                      '0/2': ['only', '11', '30'],
                      '0/4': ['del', '17']}}
for intf, vlan in fast_int['trunk'].items():
    print('interface FastEthernet' + intf)
    for command in trunk_template:
        if vlan[0] == 'add' and command.endswith('allowed vlan'):
            print(' {} add {},{}'.format(command, vlan[1], vlan[2]))
        elif vlan[0] == 'only' and command.endswith('allowed vlan'):
            print(' {} {},{}'.format(command, vlan[1], vlan[2]))
        elif vlan[0] == 'del' and command.endswith('allowed vlan'):
            print(' {} remove {}'.format(command, vlan[1]))
        else:
            print(' {}'.format(command))
