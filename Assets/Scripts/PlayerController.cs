using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class PlayerController : MonoBehaviour
{
    public float horizontalspeed = 2.0f;
    public float rightbounds = 5.0f;
    public float leftbounds = -5.0f;
    int runningRightHash;
    int runningLeftHash;
    SpawnManager spawnManager;
    Animator animator;
    [SerializeField] Rigidbody rb;
    [SerializeField] GameObject playerAnim;
    [SerializeField] float jumpForce = 400f;
    [SerializeField] LayerMask groundMask;

    void Start()
    { 
        animator = playerAnim.GetComponent<Animator>();

    }
    void Update()
    {
        bool leftPressed = Input.GetKey(KeyCode.A);
        bool rightPressed = Input.GetKey(KeyCode.D);


        if (leftPressed)
        {
            if (this.gameObject.transform.position.x > leftbounds)
            {
                transform.Translate(Vector3.left * Time.deltaTime * horizontalspeed);

            }
            animator.SetBool("RunningLeft", true);
        }
        else
        {
            animator.SetBool("RunningLeft", false);
        }

        if (rightPressed)
        {
            if (this.gameObject.transform.position.x < rightbounds)
            {
                transform.Translate(Vector3.right * Time.deltaTime * horizontalspeed);

            }
            animator.SetBool("RunningRight", true);
        }
        else
        {
            animator.SetBool("RunningRight", false);
        }


        if (Input.GetKey(KeyCode.Space))
        {
            Jump();
        }

        if (SpeedManager.Speed == 0)
        {
            playerAnim.GetComponent<Animator>().Play("HumanM@Knockdown01 - Fall");
            this.gameObject.GetComponent<PlayerController>().enabled = false;
        }
        
    }

    void Jump ()
    {
        //check grounded
        float height = GetComponent<CapsuleCollider>().height;
        bool isGrounded = Physics.Raycast(transform.position, Vector3.down, height / 2 + 0.1f, groundMask);

        //jump
        if (isGrounded == true)
        {
            rb.AddForce(Vector3.up * jumpForce);
            playerAnim.GetComponent<Animator>().Play("HumanM@Jump01");
        }
    }

}
