using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody sphereRigidbody; 
    [SerializeField] private float ballSpeed = 2f; 
    [SerializeField] private float jumpForce = 5f;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck; 

    public void MoveBall(Vector2 input)
    {
        Vector3 inputXZPlane = new(input.x, 0, input.y);
        sphereRigidbody.AddForce(inputXZPlane * ballSpeed);
    }

    private bool isGrounded() {
        return Physics.CheckSphere(groundCheck.position, 0.9f, groundLayer);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded())
        {
            sphereRigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}
