using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigidBodyComp;
    public float forwardForce = 2000f;
    public float verticalForce = 500f;

    private void FixedUpdate() 
    {
        rigidBodyComp.AddForce(0, 0, forwardForce * Time.deltaTime);
        
        if (Input.GetKey("d"))
        {
            rigidBodyComp.AddForce(verticalForce * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("a"))
        {
            rigidBodyComp.AddForce(-verticalForce * Time.deltaTime, 0, 0);
        }
    }
}
