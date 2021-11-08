# Week 6
 Character Controllers, etc

-- I learned how to install Unity's Input System and edit the Input Actions for the FPControls.
-- I created Action Maps and Actions to move the camera and the player
-- I generated a script in the FPControls input and created code for the delta action of the mouse to control the camera movement
-- I created and attached scripts for smoother camera control on the player
-- I created a FPMovement script and attached to player. The code inputs WASD and Arrow keys to move the player. 

Jumppad & Door Triggers

-- I created OnTriggerEnter/Exit script for Door and Jumppads. 
-- I ran into an issue with Door code behaving backward, troubleshooting lead me to discover that I did not apply the DoorBehavior script to each door and instead had applied it to the Gate parent.
-- I ran into an issue with the Jump pad trigger not activating, troubleshooting lead me to discover that I did not have a capsule collider on my Player parent.


Coroutines

-- I learned that a Coroutine can create a smoother animation and that beginning from current position rather than a defined position, such as open or close, fixes an glitches if the player leaves the trigger area prematurely. 