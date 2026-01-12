using Unity.VisualScripting;
using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public float speed = 0.1f;
    Vector2 left;
    Vector2 right;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        left = Camera.main.ScreenToWorldPoint(Vector2.zero);
        right = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width,Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;
        newPosition.x += speed * Time.deltaTime;
        

        //check if the position.x < 0 or position.x > width of the screen
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);
        if (screenPos.x < 0)
        {
            newPosition.x = left.x;
            speed = -speed;
        }

        if (screenPos.x > Screen.width)
        {
            newPosition.x = right.x;
            speed = -speed;
        }
        transform.position = newPosition;
    }
}
