
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f;
    public float upwardForce = 1000f;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    // FixedUpdate is used for physics stuff
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //moving upward

        if (rb.position.y > 0.5f && rb.position.y < 1.5f && rb.position.x < 7.5f && rb.position.x > -7.5f)
        {
            if (Input.GetKey("w"))
            {
                rb.AddForce(0, upwardForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            }
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
