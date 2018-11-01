using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public void Start()
    {
        for (int i = 0; i < 10000; i++)
        {
            GameObject inst = Instantiate(Resources.Load("Cube")) as GameObject;

            inst.transform.position = new Vector3(Random.Range(-50f, 50f), Random.Range(-50f, 50f), Random.Range(-50f, 50f));

            inst.AddComponent<RotatingBehavior>();
        }
    }
}
