
print("This program converts terabytes to bytes, kilobytes, megabytes and gigabytes.")
print("Type a number of terabytes to convert into these metrics!")
while True:
    tb = int(input("> "))

    gb = tb * 1024
    mb = gb * 1024
    kb = mb * 1024
    b = kb * 1024

    print(f"Terabytes: {tb} TBs")
    print(f"Gigabytes: {gb} GBs")
    print(f"Megabytes: {mb} MBs")
    print(f"Kilobytes: {kb} KBs")
    print(f"Bytes: {b} bytes")