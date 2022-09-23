ospf_route = 'OSPF 10.0.24.0/24 [110/41] via 10.0.13.3, 3d18h, FastEthernet0/0'
test = 'Protocol', 'Prefix', 'AD/Metrix', 'Next-Hop', 'Last update', 'Outbound Interface'
result = ospf_route.split()
result = [result[i].strip('[],') for i in range(0, len(result) - 1)]
final = [dict([(test[i], result[i])]) for i in range(0, len(result) - 1)]
[print('{:<15}:{:<15}'.format(''.join(list(value.keys())), ''.join(list(value.values())))) for value in final]
