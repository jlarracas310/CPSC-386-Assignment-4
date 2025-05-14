using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rgidbdy;
    private BoxCollider2D collide;
    [SerializeField] private LayerMask jumpGround;
    private Animator anim;
    private float directionX = 0f;
    private SpriteRenderer spirte;
    [SerializeField]private float moveSpeed = 5f;
    [SerializeField]private float jumpSpeed = 10f;

    private enum MoveState { idle, running, jumping, falling }

    [SerializeField] private AudioSource jumpSoundEffect;

    // Start is called before the first frame update
    private void Start()
    {
        rgidbdy = GetComponent<Rigidbody2D>();
        collide = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();
        spirte = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        
        directionX = Input.GetAxisRaw("Horizontal");
        rgidbdy.velocity = new Vector2(directionX * moveSpeed, rgidbdy.velocity.y);

        if (Input.GetButtonDown("Jump") && IsGround())
        {
            jumpSoundEffect.Play();
            rgidbdy.velocity = new Vector2(rgidbdy.velocity.x, jumpSpeed);
        }
        
        UpdateAnimationState();
    }
    
    private void UpdateAnimationState()
    {
        MoveState state;
        
        if (directionX > 0f)
        {
            state = MoveState.running;
            spirte.flipX = false;
        }
        else if (directionX < 0f)
        {
            state = MoveState.running;
            spirte.flipX = true;
        }
        else
        {
            state = MoveState.idle;
        }

        if (rgidbdy.velocity.y > .1f)
        {
            state = MoveState.jumping;
        }
        else if (rgidbdy.velocity.y < -.1f)
        {
            state = MoveState.falling;
        }

        anim.SetInteger("State", (int)state);
    }
    private bool IsGround()
    {
        return Physics2D.BoxCast(collide.bounds.center, collide.bounds.size, 0f, Vector2.down, .1f, jumpGround);
    }
}
