using UnityEngine;
using UnityEngine.InputSystem;


public class followMouse : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mouseP = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mouseP.y = -3;
        transform.position = mouseP;
    }
}
