# ITAlliance2.0 #


Joesph Douthwaite
Sehun Babatunde
Umar Saiyed 
Richard Fearnley

					Museum Hunter 0.2 Update

					We've now finished 1-9 videos out of 22 (40% base game completed) 



						//=============
						// New Features 
						//=============
New Asset Folders have been added "Audio" & "Animation" will possibly extended and added to onwards.
Player can jump into some boxes and destroy  them(see script descriptions below)
Player can jump down the first pipe and it will play an sound effect and a fade screen animantion.
Level been slighlty extended to an underground "dungeon" section after the player goes down the first green pipe.
Invisible Walls  have been added to the first and section, to prevent the player falling off.
Player can now collect coins & coins have added to the second section.
Coins add to an Coins integer keeping track of how many coins the player has collected.




						//=======
						//Scripts Summary
						//======
"Camera Follow" - Makes the Camera follow the player by the two vectors 
"Coin Rotation" - Enables the coin to rotate 
"Coin Pickup" - Enables the player to collect the coin when the player enteres the coin, makes it disspear from the screen and adds it to the coin's value  integer.
"Global Coins"  - Attaches the coin integer to the text, makes it update the value of the text from how many the player has picked up.
"BlockDestroy" - When the player jumps into a cube with this script attached  , it performs an "Destroy" animantion and dispears off screen.
"BlockNonDestroy" - When the player jumps into a cube with this script attached, it will move sligthy upwards and back down to it's original postion, simillar to Mario.
"Pipe001Entry" - Gets the code to perform the pipe animantion with the fade screen and sound, switches the main camera from the first level to the second camera for the second section and places the player into the underground section.



						//=======
						// Known Bugs & Issues
						//======
The invisible walls and cube floors have to be slightly adjusted as the player can not walk fully straight on them and can fall off.
The Fade Screen Animation performs the fade more times than it needs to. (Must be do to with the code in Pipe001Entry
The character is a bit wonky to control.(Maybe will be changed/fixed in a future video. 
