using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 1f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newP = transform.position;
        newP.x += speed * Time.deltaTime;
        transform.position = newP;

        Vector2 screenP = Camera.main.WorldToScreenPoint(transform.position);
        if (screenP.x < 90)
        {
            speed = speed * -1;
        }

        if (screenP.x >Screen.width - 90)
        {
            speed = speed * -1;
        }
    }
}
