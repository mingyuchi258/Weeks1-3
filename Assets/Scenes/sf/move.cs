using System.Data;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 1f;

    Vector2 left;
    Vector2 right;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        left = Camera.main.ScreenToWorldPoint(Vector2.zero);
        right = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newP = transform.position;
        newP.x += speed * Time.deltaTime;
        transform.position = newP;

        Vector2 screenP = Camera.main.WorldToScreenPoint(transform.position);
        if (screenP.x < 120)
        {
            newP.x = left.x;
            speed = speed * -1;
        }

        if (screenP.x >Screen.width - 120)
        {
            newP.x = right.x;
            speed = speed * -1;
        }

    }
}
