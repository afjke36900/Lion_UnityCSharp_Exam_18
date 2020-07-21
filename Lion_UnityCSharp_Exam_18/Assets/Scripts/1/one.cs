using UnityEngine;

public class one : MonoBehaviour
{

    public GameObject cube;
    public int speed = 1;

    void Start()
    {

    }

    private void Update()
    {
        if (cube.transform.position.z< 9)
        {
            cube.transform.position += Vector3.forward * speed * Time.deltaTime;
        }
    }
}
