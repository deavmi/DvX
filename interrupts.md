Interrupts
==========

## Mechanism

Interrupts are done very simply in Dvx. After each cycle has finished the `interrupt` or _Interrupt status register_ is checked for a non-zero value (if it is `0` then nothing happens), else it will contain a number from `1` to `255` indicating that an interrupt is to be executed now and that the given interrupt handler to be called is indicated via the non-zero number in the register.

This value is then decremented by `1` so that interrupt `1` when added to the `intHndlr` or _Interrupt handler register_ that interrupt `1`'s handler is indicated via the first 8-bytes read from the address stored in `intHndlr`.

## Interrupt table

{TODO: Add the needed interrupts}