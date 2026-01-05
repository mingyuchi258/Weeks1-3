using UnityEngine;
using UnityEngine.InputSystem;

public class followme : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousPos = Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //mousPos.z = 0;
        transform.position = mousPos;
    }
}
