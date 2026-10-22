using UnityEngine;
using UnityEngine.InputSystem;

public class miau : MonoBehaviour
{
    public Rigidbody variavel; 
    // Start is called before the firt frame update
    void Update()
    {
        variavel.AddForce(0, 0, 5);
        if (Keyboard.current.leftArrowKey.isPressed)
        {
            variavel.AddForce(-5, 0, 0);
        }
        if (Keyboard.current.rightArrowKey.isPressed)
        {
            variavel.AddForce(5, 0, 0);
        }
    }
}