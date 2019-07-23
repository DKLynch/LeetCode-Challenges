/*Problem URL: https://leetcode.com/problems/big-countries/ */

SELECT 
  NAME, 
  POPULATION, 
  AREA 
FROM 
  World 
WHERE 
  POPULATION > 25000000 
  OR AREA > 3000000
