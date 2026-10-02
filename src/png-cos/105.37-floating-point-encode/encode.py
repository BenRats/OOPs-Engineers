import struct

def encode(num):
    # From: https://stackoverflow.com/a/14431225
    return struct.unpack('>l', struct.pack('>f', num))[0]

print(bin(encode(-7*(1/2))))
print(bin(encode(7/32)))
print(bin(encode(1/2)))
print(bin(encode(31/32)))
print(bin(encode(-3*(3/4))))
