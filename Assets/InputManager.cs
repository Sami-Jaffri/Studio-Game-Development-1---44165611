using UnityEngine;
using UnityEngine.Events; 

public class InputManager : MonoBehaviour
{
    public UnityEvent<Vector2> OnMove = new UnityEvent<Vector2>();

    // Update is called once per frame
    void Update()
    {
        Vector2 inputVector = Vector2.zero;
        if (Input.GetKey(KeyCode.W))
        {
            inputVector += Vector2.up; 
        }
        else if (Input.GetKey(KeyCode.S))
        {
            inputVector += Vector2.down;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            inputVector += Vector2.left;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            inputVector += Vector2.right;
        }
        OnMove?.Invoke(inputVector);
    }
}
