# MaterialPropertyBlock - Problem

Sample of the Unity MaterialPropertyBlock Problem

I create this project just to show the problem that I have when a gameobject has an Animation colour and after that I want to change the material color but this not work.

## What is inside

### GameObject (Cube)
This cube has an animator and a clip called AnimColor that generate a transition between 2 colours

### Script (Player)

- __Start__
when start change the cube colour __This is the problem the colour never change__

- __Update__
when user press and hold the key space change the state to AnimColor

## How to make it work

Just select the Cube and uncheck the Animator, now when start the game the colour of cube is _RED_ 😡
