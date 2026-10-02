def decode(bits):
    sign_bit = bits[0]
    exponent_bits = bits[1:4]
    mantissa_bits = bits[4:8]

    sign = -1 if sign_bit == "1" else 1.

    exponent = int(exponent_bits,2) - 4

    mantissa = int(mantissa_bits, 2) / 16

    value = sign * mantissa * (2 ** exponent)

    return value

print(decode("01011001")) # -> 1.125
print(decode("10101100")) # -> -0.1875
print(decode("11001000")) # -> -0.5
print(decode("00111001")) # -> 0.28125
