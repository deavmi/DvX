Registers
=========

This section describes the registers of the DvX architecture.

# General purpose registers

General purpose registers are registers that may ba used for any purpose and do not affect the status of the CPU in any way.

## Register naming scheme

It is useful to remember the registers via the name scheme they use. Registers for a single byte are named from `a` to `h`, when an `e` is postfixed to their name it means extended by a byte, hence 2-bytes. When it is extended to 4-bytes then it will have an `x` (after the `e`) postfixed to its name. Lastly, when extended form 4-bytes to 8-bytes, then a prefix of `r` is used.

## Registers

### 1-byte registers

1. `a`
2. `b`
3. `c`
4. `d`
5. `e`
6. `f`
7. `g`
8. `h`

### 2-byte registers (`e`-postfixed)

1. `ae`
2. `be`
3. `ce`
4. `de`
5. `ee`
6. `fe`
7. `ge`
8. `he`

### 4-byte registers (`x`-postfixed)

1. `aex`
2. `bex`
3. `cex`
4. `dex`
5. `eex`
6. `fex`
7. `gex`
8. `hex`

### 8-byte registers (`r`-prefixed)

1. `raex`
2. `rbex`
3. `rcex`
4. `rdex`
5. `reex`
6. `rfex`
7. `rgex`
8. `rhex`

# Status registers

Status registers are registers whereby their values represent some sort of state of the machine or changing their values allow one to change the current state of the machine.