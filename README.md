# Modulo-10-EBAC
Module 10 - EBAC - Exercise: Creating a Game: Pong - Finishing

Exercise for developing a Pong clone.

This is a Pong clone project containing five scenes:

1) MenuScreen (for Title Screen);
2) Main_SinglePlayer (for Solo Mode);
3) Main_2Players (for Battle Mode);
4) MenuScreen_BattleMode (for including player names, color selection, recording the last winner's name, and a data reset system);
5) RankingScreen (for recording the number of Battle Mode victories between Player 1 and Player 2); NOTE:The ranking system is not working properly, as Player 2's victories are being counted with double values. Player 1's ranking is working correctly. I haven't yet been able to include the InputName data in the ranking system to also include the player names. It is limited to showing how many victories Player 1 and 2 have achieved.

The sprites and backgrounds were created using Aseprite and PowerPoint.

Solo and Battle Modes have a PAUSE button, which can be toggled on and off by clicking or pressing the Esc (Escape) key.

In the PAUSE window, you can continue the match (CONTINUE button), restart a new match by resetting the score (RESTART MATCH button), and exit the match (EXIT MATCH button) by returning to the MenuScreen scene in Solo Mode, or to the MenuScreen_BattleMode scene in Battle Mode.

To move the paddles:

Player 1: Use the up and down arrow keys.
Player 2: Use the i (up) and k (down) keys.

The game features exclusive end-of-game scenes for Solo and Battle modes.
