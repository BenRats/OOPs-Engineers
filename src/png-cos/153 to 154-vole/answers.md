2026-10-09: Exercises for Compuersystems

# Exercise 2

## 2.a

I've split up 0x2304 into 4 groups, each having 4 bits. Just so it's easier.

1. Op-code: `0010` means 2 in binary
2. Operand: `0011` means 3 in binary
3. Operand: `0000` means 0 in binary
4. Operand: `0100` means 4 in binary

0x2304 becomes a 16 bit string that is: `0010001100000100`

## 2.b

The first 4 bits in `0xB2A5` translated into binary is 11 in binary: `1011`

## 2.c

`0x2A5` translated into binary is thus: (I've split it into 3 groups of 4 bits)

1. `0010` means 2 in binary
2. `1010` means 10 in binary
3. `0101` means 5 in binary

Combined, it's: `001010100101`

# Exercise 3

`0x98` is `10011000` in binary which is `128 + 16 + 8` which is `152` in decimal.

`0xA2` is `10100010` in binary which is `128 + 32 + 2` which is `162` in decimal.

So between `0x98` and `0xA2`, there are 11 addresses (including `0xA2` and `0x98`). I'll just list them by incrementing 10 times, starting from `0x98`.

1. `0x98`
2. `0x99`
3. `0x9A`
4. `0x9B`
5. `0x9C`
6. `0x9D`
7. `0x9E`
8. `0x9F`
9. `0xA0`
10. `0xA1`
11. `0xA2`

# Exercise 4

`0xB0CD` will jump to address `0xCD`, so the program counter will now be `0xCD`

# Exercise 5

These entire program can be summed up as three instructions:

* `2211`: Loads `0x11` as a value directly into `R2`.
* `3202`: Stores the pattern in `R2` into cell `0x02` 
* `C000`: Which means halt indefinitely, this will stop the execution of the current program.

So this program overwrites memory cell `0x02` with `0x11`, and that's it.

# Exercise 6

## `x + y + z`

In order to compute x + y + z, we'll need to know the following beforehand.

1. Address of memory cell containing value x
2. Address of memory cell containing value y
3. Address of memory cell containing value z

I am assuming the numbers are already in main memory, and I am assuming the addresses are thusly:

1. Address for num `x`: `01`
2. Address for num `y`: `02`
3. Address for num `z`: `03`

### Strategy

The general strategy here is to first load number x and number y into two different registers,
then use `ADD` instruction to add these two registers together.
We can choose to either overwrite one of the existing registers, or put the result in a different register.

Then we load number z into an existing register (but not the one containing the result of `x + y`) or into a new register.

Then we repeat the add instruction, choosing the sum of `x + y` and number z. We can set the result wherever we want.

### Vole code

I'll be using `;` for comments.

```asm
1001 ; Load number x from cell 0x01 into R0.
1102 ; Load number y from cell 0x02 into R1.
5001 ; Add R0 and R1, put result in R0.
1103 ; Load number z from cell 0x03 into R1.
5001 ; Add R0 (x + y) and R1 (z), put result in R0.
```

Result should be in `R0`

## `(2 * x) + y`

Same general strategy, same assumptions for location of number `x` and `y`.

### Vole code

```asm
1001 ; Load number x from cell 0x01 into R0.
5000 ; Add R0 and R0 together, put result in R0.
1102 ; Load number y from cell 0x02 into R1.
5001 ; Add R0 (x * 2) and R1 (y) together, put result in R0.
```

Result should be in `R0`

# Exercise 7

* `0x7123`: Op-code 7 er `OR`, så dette vil lave boolean `OR` mod `R2` og `R3`, resultatet sættes i `R1`
* `0x40E1`: Op-code 4 er `MOVE`, så dette vil flytte værdien i `RE` til `R1`
* `0xA304`: Op-code A er `ROTATE`, så dette vil rotere værdien i `R3` `4` pladser mod højre cirkulært.
* `0xB100`: Op-code B er `JUMP`, hvis værdien i `R1` er lige med `R0`, så begynder vi at køre fra celle `0x00`.
* `0x2BCD`: Op-code 2 er `LOAD`, den sætter register `RB` til `0xCD`

# Exercise 9

`LOAD` har en opcode af enten `1` eller `2`, afhængigt på om du vil gerne loade en værdi direkte, eller load med indholdet af en celle i hukommelsen.

Den første `LOAD` er direkte `LOAD` hvilket har op-code `2`, den første operand er registren til at gemme i og derefter skal man tilsætte værdien man vil gerne gemme.

Den anden `LOAD` er `LOAD` med indholdet af en celle i hukommelsen, den første operand er registren til at gemme i og derefter skal skrive cellen af

`JUMP` har en op-code af `B`, den første operand er registren til at tjekke med `R0`, de næste 2 operander er cellen til at hoppe ned i.

`ROTATE` har en op-code af `A`, den første operand er gistren til at rotere i,  den næste operand er 0, men den sidste operand er hvor meget den skal rotere til højre i en cirukulært måde.

`AND` har en op-code af `8`, den første operand er hvilke register til at gemme resultatet i, de næste to operander er jo hvilke registre man skal udføre operationen på. 

1. `2677`: `LOAD` `0x77` direkte ind på `R6`
2. `1777`: `LOAD` værdien fra celle `0x77` ind på `R7`
3. `BA24`: `JUMP` til `0x24` hvis `RA` er lige med `R0`
4. `A403`: `ROTATE` værdien i `R4` 3 bits til højre i en cirkulært måde.
5. `81E2`: `AND` `R3` and `R2` together, and put the result in `R1`

# Exercise 14

## 14.a

The instructions, when decoded, turn into the following:

1. `1202`: Load the value in memory cell `0x02` into `R2`
2. `3242`: Store the value in `R2` to memory cell `0x42`
3. `C000`: Halt program execution.

## 14.b

The answer is `0x32` is in cell `0x42`.

Before the program starts up, we've stored `0x32` into cell `0x02`, then when we run we load the value from `0x02` into `R2`, the next instruction aftwards saves whatever value is in `R2` (which is `0x32`) into cell `0x42`.

## 14.c

The program ends at cell `0x05`, and the program counter is always incremented after fetching the instruction, so the program counter is at `0x06`