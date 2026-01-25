using UnityEngine;

public class alienCurve : MonoBehaviour
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
        //s increases with time, and if it is greater than one, it is set to zero
        s += Time.deltaTime;
        if (s > 1)
        {
            s = 0;
        }
        //use curve to control alien
        y = c.Evaluate(s);
        transform.localScale = new Vector2(y, y);

    }
}