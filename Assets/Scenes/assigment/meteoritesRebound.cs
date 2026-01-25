using UnityEngine;

public class meteoritesRebound : MonoBehaviour
{
    public Vector2 speed;

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
        //directional movement of meteorites use vector
        Vector2 newP = transform.position;
        newP += speed * Time.deltaTime;

        //When the meteorite reaches the edge of the screen
        Vector2 screenP = Camera.main.WorldToScreenPoint(transform.position);
        if (screenP.x < 0)
        {
            //Replace with world to prevent aliens from getting stuck.
            newP.x = left.x;
            //Move in the opposite direction
            speed.x = speed.x * -1;
        }

        if (screenP.x > Screen.width)
        {
            newP.x = right.x;
            speed.x = speed.x * -1;
        }

        if (screenP.y > Screen.height)
        {
            newP.y = right.y;
            speed.y = speed.y * -1;
        }

        if (screenP.y < 0)
        {
            newP.y = left.y;
            speed.y = speed.y * -1;
        }
        transform.position = newP;
    }
}
