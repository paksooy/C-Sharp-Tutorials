<pre>
Requirements:
--------------
Random Number -> integer Random Number Library
User Guess -> integer Get input from user
Number of Guesses -> integer

Scenario:
--------------
Generate random number.
Ask the user for a guess.

/1\ Compare (number vs guess)
          number>guess
              raise the estimate
              counter++
              return/1\
          number<guess
              lower the estimate
              counter++
              return/1\
          number == guess
              congratulations
</pre>
