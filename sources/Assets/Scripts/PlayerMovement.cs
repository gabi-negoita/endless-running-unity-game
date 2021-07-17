/**
 * Controll the player's movement
 */
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float forwardForce;
    public float sidewaysForce;
    public float upForce;
    public bool isAbleToJump;
    public Rigidbody rb;

    public SoundEffects soundEffect;

    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
        isAbleToJump = true;
    }

    private void Update()
    {
        forwardForce += 0.001f * Time.deltaTime;

        // Checking for jumping button
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("KEY PRESSED: [SPACE]");
            // Starting the player's jump animation
            FindObjectOfType<AnimationController>().StartJump();
        }
    }

    void FixedUpdate()
    {
        // Moving the player's position forward
        transform.Translate(Vector3.forward * forwardForce * Time.deltaTime);

        // Increase score
        DisplayScore.incrementScore((int)(forwardForce) / 10);

        // Checking for input buttons
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            Debug.Log("KEY PRESSED: [A]");
            // Moving player's position to left
            rb.AddForce(Vector3.left * sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            Debug.Log("KEY PRESSED: [D]");
            // Moving player's position to right
            rb.AddForce(Vector3.left * -sidewaysForce * Time.deltaTime, ForceMode.VelocityChange);

        }

        if ((Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow)) && isAbleToJump)
        {
            soundEffect.PlayJumpSoundEffect();

            // Player starts jumping
            rb.AddForce(Vector3.up * upForce * Time.deltaTime, ForceMode.VelocityChange);
            isAbleToJump = false;
        }
    }
}
