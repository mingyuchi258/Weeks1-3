using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    float speed = 0.1f;
    Vector2 left;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        left = Camera.main.ScreenToWorldPoint(Vector2.zero);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        transform.position = newPosition;

        //check if the position.x < 0 or position.x > width of the screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0)
        {
            speed = -speed;
        }

        if (screenPos.x > Screen.width)
        {
            speed = -speed;
        }
    }
}
