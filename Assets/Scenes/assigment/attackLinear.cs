using UnityEngine;

public class attackLinear : MonoBehaviour
{
    public Transform plane;
    public Transform alien;
    float s = 0;
    public AnimationCurve curve;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //create a linear interpolation that moves from the starting point to the ending point
        transform.position = Vector2.Lerp(plane.position, alien.position, s);
        //s increases with time, and if it is greater than one, it is set to zero
        s += Time.deltaTime;
        if (s > 1)
        {
            s = 0;
        }

    }
}