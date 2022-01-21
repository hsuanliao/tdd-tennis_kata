# About this Kata

This Kata is about implementing a simple tennis game. I came up with it while thinking about Wii tennis, where they have simplified tennis, so each set is one game.

The scoring system is rather simple:
1. Each player can have either of these points in one game “love” “15” “30” “40”
1. If you have 40 and you win the point you win the game, however there are special rules.
1. If both have 40 the players are “deuce”.
1. If the game is in deuce, the winner of a point will have advantage
1. If the player with advantage wins the ball he wins the game
1. If the player without advantage wins they are back at deuce.

Alternate description of the rules per Wikipedia ([http://en.wikipedia.org/wiki/Tennis#Scoring](http://en.wikipedia.org/wiki/Tennis#Scoring))

1. A game is won by the first player to have won at least four points in total and at least two points more than the opponent.
1. The running score of each game is described in a manner peculiar to tennis: scores from zero to three points are described as “love”, “fifteen”, “thirty”, and “forty” respectively.
1. If at least three points have been scored by each player, and the scores are equal, the score is “deuce”.
1. If at least three points have been scored by each side and a player has one more point than his opponent, the score of the game is “advantage” for the player in the lead.

**The reference: [Tennis - Coding Dojo](https://codingdojo.org/kata/Tennis/)**

***

## Test cases
### Same score
* 0-0: love all
* 1-1: fifteen all
* 2-2: thirty all
* 3-3: deuce [n-n, n >= 3]

### Different score (First player: **Jay**, Second player: **Kevin**)
* 0-2: love thirty
* 3-1: forty fifteen
* 4-3: Jay Adv. [_n-(n-1), n >= 4_]
* 3-4: Kevin Adv. [_n-(n-1), n >= 4_]
* 4-2: Jay Win.
* 1-4: Kevin Win.
* 5-3: Jay Win. [_n-(n-2), n >= 4_]
* 3-5: Kevin Win. [_n-(n-2), n >= 4_]
