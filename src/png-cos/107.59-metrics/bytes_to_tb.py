
print("This program converts bytes to kilobytes, megabytes, gigabytes and terabytes.")
print("Type a number of bytes to convert into these metrics!")
while True:
    b = int(input("> "))

    kb = b / 1024
    mb = kb / 1024
    gb = mb / 1024
    tb = gb / 1024

    print(f"Bytes: {b} bytes")
    print(f"Kilobytes: {kb} KBs")
    print(f"Megabytes: {mb} MBs")
    print(f"Gigabytes: {gb} GBs")
    print(f"Terabytes: {tb} TBs")
