using UnityEngine;

public class linear : MonoBehaviour
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
        transform.position = Vector2.Lerp(plane.position, alien.position, s);

        s += Time.deltaTime;
        if (s > 1)
        {
            s = 0;
        }
        
    }
}
