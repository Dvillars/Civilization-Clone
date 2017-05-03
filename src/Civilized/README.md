# Civilized

### An excercise in AJAX calls with ASP.NET Core
##### By Derek Villars and Marc Larkin
***

### User Stories
As a user I want to be able to:
1. Register an account
2. Sign in
3. Choose our type of:
	* Government
    * Economy
    * Geography
    * Civilization
4. View my resources
   * Luxuries
   * Bonus
   * Strategic
5. View my population
6. View my empire's stability
7. Respond to disasters affecting my people
8. Spend resources and capital to improve my civilization
9. View my civilization's score
***
### Game Specs

1. To register an account we will use 'Identity' with a 'Create Account' page
2. To sign in we will use a 'Log In' page
3. When we are logged in, we can click a button to start a new game
4. Upon starting a new game, we will select our
5. civilization's Economy, Geography, Government, and Civilization from a pop up menu.
6. After selecting our civilization's information we will click "Start game" and we will and be redirected to the main game page

### Object Specs

#### Government
|id|name|pro|con|
|--|--|--|--|
|||||
#### Economy
|id|name|pro|con|
|--|--|--|--|
|||||
#### Geography
|id|name|pro|con|
|--|--|--|--|
||Mountain|||
||Desert|||
||Coast|||
||Forest|||
#### Civilization
|id|name|pro|con|
|--|--|--|--|
||Asian|||
||European|||
||American|||
||African|||

#### Resources
|id|name|type|$|happiness|
|--|--|--|--|--|
||Cattle|Bonus|1|1|
||Iron|Strategic|2|1|
||Silk|Luxury|3|2|
#### Player
|id|name|Civilization|Government|Economy|Geography
|--|--|--|--|--|--|
|||||