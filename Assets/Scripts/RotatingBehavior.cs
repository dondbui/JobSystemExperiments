using UnityEngine;

public class RotatingBehavior : MonoBehaviour
{
    private const int speed = 100;

    // Update is called once per frame
    public void Update()
    {
        transform.Rotate(0f, speed * Time.deltaTime, 0f);
    }
}
