using UnityEngine;

[RequireComponent(typeof(Raycasts))]
public class Jump : MonoBehaviour {

    private Rigidbody2D rb2d;
    private Raycasts rayCasts;

    private SpriteRenderer spriteRenderer;
    private Animator animator;
    
    private bool canWallJump = false;


    // isjumping
    private bool isJumping = false;
    public bool Jumping { get { return isJumping; } }

    //variables
    private readonly float fallMultiplier = 6.7f, 
                           lowJumpMultiplier = 5f, 
                           jumpForce = 20f, 
                           velocityMinimum = 10;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
        rayCasts = GetComponent<Raycasts>();

        spriteRenderer = GetComponent<SpriteRenderer>();
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        DoJump();
    }

    private void FixedUpdate()
    {
        DoFall();
    }
    

   

    private void DoJump()
    {
        //check if input goes down while grounded
        if (rayCasts.Grounded && Input.GetKeyDown(KeyCode.Space))
        {
            // play sound here
            isJumping = true;
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpForce);
        }

        //check if input is released (up) or if no input
        if (Input.GetKeyUp(KeyCode.Space) || !Input.GetKey(KeyCode.Space))
        {
            isJumping = false;
        }
    }

    private void DoFall()
    {
        if (!rayCasts.Grounded)
        {
            // this changes the gravity to make the player jump low
            if (rb2d.velocity.y < velocityMinimum)
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (fallMultiplier - 1) * Time.deltaTime;
            }
            else if (rb2d.velocity.y > velocityMinimum && !Input.GetKey(KeyCode.Space))
            {
                rb2d.velocity += Vector2.up * Physics2D.gravity.y * (lowJumpMultiplier - 1) * Time.deltaTime;
            }
        }
    }

    
}
