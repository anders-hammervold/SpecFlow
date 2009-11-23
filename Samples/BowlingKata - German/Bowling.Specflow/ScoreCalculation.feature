Funktionalität: Score Calculation 
  In order to know my performance
  As a player
  I want the system to calculate my total score
  
Szenario: Gutter game
  Gegeben sei a new bowling game
  Wenn all of my balls are landing in the gutter
  Dann my total score should be 0
  
Szenario: Beginners game
  Gegeben sei a new bowling game
  Wenn I roll 2 and 7
  Und I roll 3 and 4
  Und I roll 8 times 1 and 1
  Dann my total score should be 32
  
Szenario: Another beginners game
  Gegeben sei a new bowling game
  Wenn I roll the following series:	2,7,3,4,1,1,5,1,1,1,1,1,1,1,1,1,1,1,5,1
  Dann my total score should be 40
  
Szenario: All Strikes
  Gegeben sei a new bowling game
  Wenn all of my rolls are strikes
  Dann my total score should be 300
  
Szenario: One single spare
   Gegeben sei a new bowling game 
   Wenn I roll the following series: 2,8,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1,1
   Dann my total score should be 29
   
Szenario: All spares
  Gegeben sei a new bowling game
  Wenn I roll 10 times 1 and 9
  Und I roll 1
  Dann my total score should be 110
     
