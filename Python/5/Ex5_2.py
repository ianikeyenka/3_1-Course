mac = ['aabb:cc80:7000', 'aabb:dd80:7340', 'aabb:ee80:7000', 'aabb:ff80:7000']
mac_cisco = []
[mac_cisco.insert(i, mac[i].replace(':', '.')) for i in range(len(mac))]
print(mac_cisco)

