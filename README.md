# Dictionary Unit Testing in C#

## Project Overview
This project demonstrates unit testing for a function that analyzes the frequency of digits in an integer number. The function handles both positive and negative numbers and returns a dictionary showing how many times each digit appears in the number, with unit tests to validate different scenarios.
## Purpose
The ```CountDigits function``` takes an integer as input and returns a dictionary where: <br />
- Key: Each unique digit (from 0 to 9) found in the input number.<br />
- Value: The frequency of each digit.<br />

## Tech Stack
*Language:* C#<br />
*Testing Framework:*  NUnit<br />
*IDE:* Visual Studio<br />

## Unit Tests<br />
```Zero Number Returns Empty Dictionary```: Verifies that passing 0 as the input returns an empty dictionary (since 0 has no digits in this case).<br />
```Single Digit Number Returns Dictionary With Single Entry```: Ensures that passing a single-digit number returns a dictionary containing that digit with a count of 1.<br />
```Multiple Digits Number Returns Dictionary With Digits Frequencies```: Confirms that the function correctly counts multiple occurrences of digits in a larger number.<br />
```Negative Number Returns Dictionary With Digits Frequencies```: Verifies that negative numbers are handled as positive, and the digit frequencies are counted correctly.
