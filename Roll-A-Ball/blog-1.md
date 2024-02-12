# Roll a ball

## 1) First impressions
- Dragos-Daniel Bonaparte
<p> I gotta say that I didn't know much to begin with, the first class we had I was struggling to find the component for making a cube collide with the platform I made in the editor.
I didn't know much of scripting and organizing the game files, but the tutorial was exactly what I needed
</p>

- Matas Armonaitis
<p>
Before starting I had very minimal amount of experience with unity, only doing small projects that I was learning on youtube, but never did anything to the end and never did a unity learn tutorial, so I was excited to see how it is different from regular youtube tutorials.
</p>

## 2. During the tutorial
- Dragos-Daniel Bonaparte
<p> Started by creating the play area, which was easier than expected. I understood now the reason behind creating an empty object when aligning the walls of the platform</p>

![empty object "walls"](/Roll-A-Ball/images/image-dragos.png)

<p>It's very cool that objects can become children of another object, I consider this nice since you can give the parent some properties, and that will apply to all of its children. (Of course this can be done with tags also)
</p>

![alt text](/Roll-A-Ball/images/image-1-dragos.png)

<p> When it comes to scripting, the methods are intuitive enough to understand (at least slightly) what they do. </p>

```csharp
    void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movementX = movementVector.x;
        movementY = movementVector.y;
    }
``` 
<p> I (personally) understand that by this method, the function receives calls from the input library that we installed in the tutorial (InputActions) and provides the next vector position for the player object as long as a movement key is pressed.</p>

```csharp
private void FixedUpdate()
    {
        Vector3 movement = new Vector3(movementX, 0.0f, movementY);
        rb.AddForce(movement * speed);
    }
```
<p> The `FixedUpdate` method constantly updates the rigidbody probably as fast as the game loop runs at (probably given by the frame rate of the game)

I don't think there is a lot more to say about  this games as it is very simple, and didn't require much of thought (monke see, monke do).</p>

- Matas Armonaitis
<p>When I First started the tutorial, it was very straight forward, the steps were very detailed in text and in video format, so following it was very easy.
</p>
<h4>Setting up</h4>
<p>The setup part was very easy, it was just to create a new project and add a floor and a game object for a player and it was something that I was familiar with before starting and when I finished the first part it looked something like this:
</p>

![alt text](/Roll-A-Ball/images/image.png)

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

![alt text](/Roll-A-Ball/images/image-3.png)

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

![alt text](/Roll-A-Ball/images/image-1.png)

<h4>Creating Collectibles</h4>

<p>In this part was how to make collectibles in the game and how to make objects rotate and also showed how to work with prefabs. By the end it looked like this but the collectables were not able to be picked up</p>

![alt text](/Roll-A-Ball/images/image-2.png)

<h4>Detecting Collisions with Collectibles</h4>

<p>This part was just making the collectibles to be able to be picked up. Also it showed how to change a rigid body so it just detects collision and does not just stop the player like a wall</p>

<h4>Displaying Score and Text</h4>

<p>In this part we learned how to make the game count the score and display it on the screen. It showed how to put text on the players view and update it</p>

![alt text](/Roll-A-Ball/images/image-4.png)

<h4>Building the Game</h4>

<p>This part was just for building the game and making an executable file for it.</p>

## 3. After the tutorial
- Dragos-Daniel Bonaparte
<p> Simple but very useful scenario, I think with the things learned from this tutorial you can easily make a platformer :)

 I rather wanted to understand what the tutorial was teaching me rather than making a Roll-A-Ball game, and I think after the tutorial I was left with a nice understanding of how is the basic process of making games.</p>

- Matas Armonaitis
<p>After finishing the tutorial I feel like I learned a lot of basics to create a simple game and gained knowledge to do the basics when creating any game.</p>