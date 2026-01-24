using UnityEngine;

public class curve : MonoBehaviour
{
    public AnimationCurve c;
    public float s;
    public float y;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        s += Time.deltaTime;
        if (s > 1)
        {
            s = 0;
        }

        y = c.Evaluate(s);
        transform.localScale = new Vector2(y, y);

    }
}
