#Katas

####Fizz Buzz
```
Write a program that prints the numbers from 1 to N. But for multiples of three print "Fizz" instead of the number and for the multiples of five print "Buzz". For numbers which are multiples of both three and five print "FizzBuzz".
```
####Bowling Game
```
The game consists of 10 frames as shown above.  In each frame the player has two opportunities to knock down 10 pins.  The score for the frame is the total number of pins knocked down, plus bonuses for strikes and spares.
A spare is when the player knocks down all 10 pins in two tries.  The bonus for that frame is the number of pins knocked down by the next roll.  So in frame 3 above, the score is 10 (the total number knocked own) plus a bonus of 5 (the number of pins knocked down on the next roll.)
A strike is when the player knocks down all 10 pins on his first try.  The bonus for that frame is the value of the next two balls rolled.
In the tenth frame a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame.  However no more than three balls can be rolled in tenth frame.
Write a class named “Game” that has two methods
roll(pins : int) is called each time the player rolls a ball. The argument is the number of pins knocked down.
score() : int is called only at the very end of the game.  It returns the total score for that game.
```
####Leap Year Calculator
```
A year will be a leap year if
it is divisible by 4 but not by 100.
If a year is divisible by 4 and by 100,
it is not a leap year unless it is also divisible by 400.
```
####Tennis Match
```
This Kata is about implementing a simple tennis game. I came up with it while thinking about Wii tennis, where they have simplified tennis, so each set is one game.

The scoring system is rather simple:

1. Each player can have either of these points in one game 0 15 30 40
2. If you have 40 and you win the ball you win the game, however there are special rules.
3. If both have 40 the players are deuce.
	a. If the game is in deuce, the winner of a ball will have advantage and game ball.
	b. If the player with advantage wins the ball he wins the game 
	c. If the player without advantage wins they are back at deuce.
```
####Roman Numeral Converter
```
This kata is about converting from Arabic to Roman Numerals and from Roman to Arabic.

For example, given the following input:

III
29
38
CCXCI
1999

The correct output is:

3
XXIX
XXXVIII
291
MCMXCIX

If you're not familiar with or need a refresher on Roman numerals, the rules are simple. First, there are seven letters associated with seven values:

I = 1
V = 5
X = 10
L = 50
C = 100
D = 500
M = 1000

You can combine letters to add values, by listing them largest to smallest from left to right:

II   is 2
VIII  is 8
XXXI is 31

However, you may only list three consecutive identical letters. That requires a special rule to express numbers like 4 and 900. That rule is that a single lower value may proceed a larger value, to indicate subtraction. This rule is only used to build values not reachable by the previous rules:

IV is 4
CM is 900

But 15 is XV, not XVX.
```