using UnityEngine;

public class BallMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 2000f;
    public float sideWaysForce = 500f;
    public int points = 0;

    // marked this with fixedUpdate becaus; iam using it to mess with the physics.
    void FixedUpdate()
    {
        // add force 2000 to the Z axis
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("l"))
        {

            rb.AddForce(sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("d"))

        {
            rb.AddForce(-sideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        
        if (rb.position.y < -1f)
        {

            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }

}
