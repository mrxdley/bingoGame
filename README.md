# Basic .NET Bingo Game

This is a *very basic* bingo game.
All graphics are generated during runtime, allowing for the potential for many millions of balls - or only 5 - with a tiny bit of tweaking.

### Program Structure

* Initalises variables - `ballX` and `ballY`, etc.
* Form1 - draws the form, initialises the grid of balls
* DrawBalls() - draws the balls with a configurable amount of `rows` and `cols`
* DrawNumber() - grabs a random number (seed WIP)
    * checks for existing numbers
    * grabs a X and Y value for the drawn ball
    * adds a small delay between draws for _suspense_
    * catches values above 90 to end the game
    * catches duplicates
* numbers_Paint() uses the PictureBox.Paint() functionality to add text to the images of the balls - this allows the user to change the image of the balls without impacting text.
* there is a reset button for unlimited gameplay


