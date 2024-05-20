# Game-Design-Packing
Designed high level game in Unity using C#

 ## **Problem Statement:**
Packing of a given set of 2D items I into a 2D container C refers to an arrangement of the items
of I so that no two items overlap and each item is completely contained within C. The container
C and the unique shapes of items of I are given. There is an unlimited supply of items in I. The
objective before the player is to pack as many items into C as possible. While arranging an item
within C, the player must be allowed all the rigid motions in 2D. No other transformation may be
permitted

## **Overview:**

Considering the problem statement, we are planning to create a container, with a solid
boundary, in which a user can put the object which should not overlap with each other and rigid
motion is allowed . The object can be square, circle and equilateral triangle.

<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/46ed8a1a-3535-4ee7-a82e-ee763f405235" width="600" height="200" />

This game can be played by N number of players. Winner is decided by the number of objects
placed in the container.
For Example: Player A and Player B are playing a game. Player A placed 13 objects in the
container and Player B placed 17 objects in the container with following all conditions. Then
Player B will be the winner of the game.
To make the game more interesting let's have some conditions for players:
1. Player should all figures at least some x times (which can be decide later)
2. Overlapping of objects is not allowed. ( if there is a single point of container that comes
in at least 2 objects including the sides will be considered as overlapping that means
touching of sides is not considered as overlapping).
3. Rigid motion of objects can be allowed (rotation + translation + reflection).
4. All objects should be inside the container.
5. The container size is fixed to 10 cm x 10 cm.
6. Object size is fixed and players are not allowed to resize it. So the length of the triangle
is equal to the length of the square and equal to the diameter of the circle

### **Screens:**
1. Home Screen: When you start the game you will be redirected to the home page which contains a
button which allows you to start the game. You can play individually and also in a team.
It will also ask you to enter a name.
<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/22b98be4-0038-43a6-b817-b4b564c15420" width="500" height="200" />

2. Main Screen: Where you will find the basic layout of the game which contains a timer, count of objects
placed in a container, leaderboard if you play a team, or name if you play individually,
and a start game button to start the game. As you click on the start game the timer will
start. Restart and Home page buttons are also there.
<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/6f21fc65-58f0-499e-9197-ecb62f32f723" width="500" height="200" />

3. Screen after starting the game:When you click the start button the timer will automatically start and the counter of the
total object will also increase when you place any object in a container and follow all
given conditions.
<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/62bb277f-d9ac-46bf-9e69-78ae04385def" width="500" height="200" />

4. Select object:On clicking select object it will display some objects from which you have to choose one
object, drag it from there and place it in the container according to your convenience.
How you can move and fix an object in container:
There are two options for movement and fixing of an object. Either we can
drag an object from the side space where some objects are placed to choose and place
it in a container using a mouse or we can click on an object to make it selected and then
use keyboard keys for the movement. We can rotate the object using the keyboard
(Ctrl+R) and press enter to fix its position.
<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/0c10ba6f-02d3-42ce-8999-bada5dc04d0c" width="500" height="200" />

5. Screen with error: If you violate any rule or condition it will display some error.While placing an object, if the
conditions such as (object is totally inside the container, object will not overlap with other
object) will not be satisfied and the user is trying to enter or fixing the position of object
then a message pops up which shows that invalid conditions.
<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/7ec49b34-754d-4baf-af27-0a0b121e78db" width="500" height="200" />

6. End Game: After the game is completed you will receive a game ended message and option to
restart the game.
<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/dc030152-bd91-4f2e-ae3b-5fb2ee7d68d6" width="500" height="200" />


### **Levels:**
This Game includes different levels. Each level will have a different shape and size of
container, which will be predefined and based on that shape, we kind of calculate the
approximate number of objects that should be put inside the container. And if a player
scores more or equal to that then level gets cleared.
In the case of multiplayer games, we alternatively assign turns to each member, and
once for a single level all players get turned then the new level will start.
As the level increases from 1 to 5, the difficulty of the game will increase
<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/710b935d-305e-459c-93ea-770ec926d77a" width="500" height="200" />


### **Modes**
1. Play Individually: The player can also play the game individually and have
different levels with more restrictions and time bound.
2. Play with Friends: player can send the invite link to friends and play the game
with them and also have different levels and after the completion of all levels
leaderboard will appear with the rankings of all individuals.
<img src="https://github.com/poojapatidar21/Game-Design-Packing/assets/56690803/2444de6b-c33f-4973-be26-10f38a7e2eab" width="500" height="200" />
