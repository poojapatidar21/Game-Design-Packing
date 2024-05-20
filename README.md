# Game-Design-Packing
Designed high level game in Unity using C#

 Problem Statement:
Packing of a given set of 2D items I into a 2D container C refers to an arrangement of the items
of I so that no two items overlap and each item is completely contained within C. The container
C and the unique shapes of items of I are given. There is an unlimited supply of items in I. The
objective before the player is to pack as many items into C as possible. While arranging an item
within C, the player must be allowed all the rigid motions in 2D. No other transformation may be
permitted

Overview:
Considering the problem statement, we are planning to create a container, with a solid
boundary, in which a user can put the object which should not overlap with each other and rigid
motion is allowed . The object can be square, circle and equilateral triangle.

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

Screens:
1. Home Screen:
2. Main Screen:
3. Screen after starting the game:
4. Select object:
5. Screen with error:
6. End Game:

