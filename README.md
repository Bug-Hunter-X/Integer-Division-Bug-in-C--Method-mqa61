# Integer Division Bug in C# Method

This repository demonstrates a potential bug in a C# method involving integer division.  The `MyMethod` function in `MyClassBug.cs` incorrectly handles the case where both input integers are negative. This can lead to unexpected results due to how C# handles integer division and potential exceptions. The correct solution is demonstrated in `MyClassSolution.cs`.

## Bug Description
The bug lies in the integer division (`a / b`). When both `a` and `b` are negative, the result might not be as expected.  Standard integer division truncates the result towards zero, which can lead to unintended results if the programmer intended the division to behave differently in case of negative numbers.

## Solution
The solution in `MyClassSolution.cs` adds appropriate checks and handles the negative case correctly by explicitly handling the signs of inputs to ensure accurate integer division.  This ensures predictable behavior regardless of the signs of the input values.