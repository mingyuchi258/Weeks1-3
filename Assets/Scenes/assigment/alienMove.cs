using UnityEngine;

public class alienMove : MonoBehaviour
{
    public float speed = 1f;

    Vector2 left;
    Vector2 right;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //set bottom left and top right corners of the screen
        left = Camera.main.ScreenToWorldPoint(Vector2.zero);
        right = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        //Make alien move laterally
        Vector3 newP = transform.position;
        newP.x += speed * Time.deltaTime;
        transform.position = newP;

        //When the aliens are almost at the left edge of the screen
        Vector2 screenP = Camera.main.WorldToScreenPoint(transform.position);
        if (screenP.x < 120)
        {
            //Replace with world to prevent aliens from getting stuck.
            newP.x = left.x;
            //Move in the opposite direction
            speed = speed * -1;
        }

        //When the aliens are almost at the right edge of the screen
        if (screenP.x > Screen.width - 120)
        {
            newP.x = right.x;
            speed = speed * -1;
        }

    }
}
