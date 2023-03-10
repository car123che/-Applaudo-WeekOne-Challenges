# Roman Numeral Representation

## What is the problem to be solved?
The program will receive a positive integer and will return the Roman Numeral Representation of that integer. 

## What do I know?
* The input will be a positibe integer
* The symbols
  
| Number | Symbol |
| ------ | ------ |
| 1      | I      |
| 4      | IV     |
| 5      | V      |
| 9      | IX     |
| 10     | X      |
| 40     | XL     |
| 50     | L      |
| 90     | XC     |
| 100    | C      |
| 400    | CD     |
| 500    | D      |
| 900    | CM     |
| 1000   | M      |



* There can't be more than 3 identical symbols in a row
  * So the biggest number is: MMMCMXCIX = 3999


## What do I need from the user? 
* The number input

## What will my program produce?
* A string that represents the number
* An error message if the input is not an integer
* An error message if the input is not positive
* An error message if the input is 0 
* An error message if the input is bigger than 3999

## Pseudocode
1. Validate if the input is an integer
   1. If not return a message saying that the input must be an integer
2. Validate if the input is greater than 0
   1. If not return a message saying the input must be greater than 0
3. Validate if the in put is lower than 4000
   1. If not return a message saying that the input musht be lower than 4000
4.  Declare an array with the posible values that  Roman can take order from the biggest to the smallest. `[ 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 ]`
5. Declare an array with the Symbols of that values
`[ 'M', 'CM', 'D', 'CD', 'C', 'XC', 'L', 'XL', 'X', 'IX', 'V', 'IV','I']`
6. Declare a integer counter. 
7. Declare a string that will be the result. 
8. While the input number is greater than 0
   1. If the substraction of the input with the element in the values array in the counter position is greater than 0, then substract that value and add the corresponding symbol to the string result.
   2. If not. Add 1 to the counter to use a lower value. 
9. Return the corresponding string result.
    
## Flow Diagram
![Flow](img/Roman%20Numeral%20Representation.png)

## Test Cases
* 0 => Message Error
* 1998 => "MCMXCVIII"
* 166 => "CDXVI"
* 3999 => "MMMCMXCIX"
* 4000 => Message Error