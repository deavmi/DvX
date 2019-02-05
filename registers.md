Registers
=========

This section describes the registers of the DvX architecture.

Registers are given in their human-readable format below but internally are represented as a byte from `0` to `255`.

# General purpose registers

General purpose registers are registers that may ba used for any purpose and do not affect the status of the CPU in any way.

## Register naming scheme

It is useful to remember the registers via the name scheme they use. Registers for a single byte are named from `a` to `h`, when an `e` is postfixed to their name it means extended by a byte, hence 2-bytes. When it is extended to 4-bytes then it will have an `x` (after the `e`) postfixed to its name. Lastly, when extended form 4-bytes to 8-bytes, then a prefix of `r` is used.

## Registers

### 1-byte registers

1. `a` (Byte: `0`)
2. `b` (Byte: `1`)
3. `c` (Byte: `2`)
4. `d` (Byte: `3`)
5. `e` (Byte: `4`)
6. `f` (Byte: `5`)
7. `g` (Byte: `6`)
8. `h` (Byte: `7`)

### 2-byte registers (`e`-postfixed)

1. `ae` (Byte: `8`)
2. `be` (Byte: `9`)
3. `ce` (Byte: `10`)
4. `de` (Byte: `11`)
5. `ee` (Byte: `12`)
6. `fe` (Byte: `13`)
7. `ge` (Byte: `14`)
8. `he` (Byte: `15`)

### 4-byte registers (`x`-postfixed)

1. `aex` (Byte: `16`)
2. `bex` (Byte: `17`)
3. `cex` (Byte: `18`)
4. `dex` (Byte: `19`)
5. `eex` (Byte: `20`)
6. `fex` (Byte: `21`)
7. `gex` (Byte: `22`)
8. `hex` (Byte: `23`)

### 8-byte registers (`r`-prefixed)

1. `raex` (Byte: `24`)
2. `rbex` (Byte: `25`)
3. `rcex` (Byte: `26`)
4. `rdex` (Byte: `27`)
5. `reex` (Byte: `28`)
6. `rfex` (Byte: `29`)
7. `rgex` (Byte: `30`)
8. `rhex` (Byte: `31`)

# Status registers

Status registers are registers whereby their values represent some sort of state of the machine or changing their values allow one to change the current state of the machine.

## Interrupt handling

These registers deal with the interrupt mechanism of the machine.

### Interrupt handler register (`intHndlr`)

The `intHndlr` or _Interrupt handler register_ is a 8-byte register containing the address of the beginning of the interrupt handler table. This register is used by the CPU     

TODO: [see the structure of the table here](interrupts.md)