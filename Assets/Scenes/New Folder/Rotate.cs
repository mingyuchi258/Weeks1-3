using UnityEngine;

public class Rotate : MonoBehaviour
{
    public float speed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newP = transform.eulerAngles;
        newP.z += speed;
        transform.eulerAngles = newP;
    }
}
