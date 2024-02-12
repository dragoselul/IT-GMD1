# Roll a ball

## 1) Before the tutorial
   - Dragos-Daniel Bonaparte
   To me the tutorial was straight forward

   - Matas Armonaitis
   <p>
   Before starting I had very minimal amount of experience with unity, only doing small projects that I was learning on youtube, but never did anything to the end and never did a unity learn tutorial, so I was excited to see how it is different from regular youtube tutorials.
   </p>

## 2) During the tutorial

   - Matas Armonaitis
   <p>When I First started the tutorial, it was very straight forward, the steps were very detailed in text and in video format, so following it was very easy.
   </p>
   <h4>Setting up</h4>
   <p>The setup part was very easy, it was just to create a new project and add a floor and a game object for a player and it was something that I was familiar with before starting and when I finished the first part it looked something like this:
   </p>

   ![alt text](image.png)

   <h4>Moving the Player</h4>

   <p>This part of roll a ball showed how to make a player move and was a first introduction to scripts and file management. First was to create a separate folder for scripts and the first script was for making the player move: </p>

   ```csharp
   // Rigidbody of the player.
    private Rigidbody rb;
    private int count;
    // Movement along X and Y axes.
    private float movementX;
    private float movementY;
    // Speed at which the player moves.
    public float speed = 0;

    void OnMove (InputValue movementValue)
    {
        // Convert the input value into a Vector2 for movement.
        Vector2 movementVector = movementValue.Get<Vector2>();
        
        // Store the X and Y components of the movement.
        movementX = movementVector.x; 
        movementY = movementVector.y;
    }
   ```

   <p>I also think that it is really cool that we can set the value of speed for movement inside of unity instead of hard coding it in the script</p>

   ![alt text](image-3.png)

   <p>This part of the tutorial was not too hard, but it seems like its the case for the whole tutorial since it is written very clearly</p>

   <h4>Moving the Camera</h4>

   <p>In this part of the tutorial I made the camera follow the player ball constantly by adding a new script</p>

   ```csharp
      public class CameraController : MonoBehaviour
   {
    // Reference to the player GameObject.
    public GameObject player;
    // The distance between the camera and the player.
    private Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        // Calculate the initial offset between the camera's position and the player's position.
        offset = transform.position - player.transform.position;
    }

    // LateUpdate is called once per frame after all Update functions have been completed.
    void LateUpdate()
    {
        // Maintain the same offset between the camera and player throughout the game.
        transform.position = player.transform.position + offset;
    }
   }
   ```

   <p>It was also pretty easy but gave a good perspective of how the camera works and how to manipulate it to work how I want it to work</p>

   <h4>Setting up the Play Area</h4>

   <p>In this part It was just creating some walls and also making them solid so the player has a hard time to move out of the game area, also this part showed how to duplicate components so it is faster to do parts which are basically the same but just need to be in different places, by the end it looked like this:
   </p>

   ![alt text](image-1.png)

   <h4>Creating Collectibles</h4>

   <p>In this part was how to make collectibles in the game and how to make objects rotate and also showed how to work with prefabs. By the end it looked like this but the collectables were not able to be picked up</p>

   ![alt text](image-2.png)

   <h4>Detecting Collisions with Collectibles</h4>

   <p>This part was just making the collectibles to be able to be picked up. Also it showed how to change a rigid body so it just detects collision and does not just stop the player like a wall</p>

   <h4>Displaying Score and Text</h4>

   <p>In this part we learned how to make the game count the score and display it on the screen. It showed how to put text on the players view and update it</p>

   ![alt text](image-4.png)

   <h4>Building the Game</h4>

   <p>This part was just for building the game and making an executable file for it.</p>

## 3) After the tutorial

   - Matas Armonaitis
   <p>After finishing the tutorial I feel like I learned a lot of basics to create a simple game and gained knowledge to do the basics when creating any game.</p>


   

