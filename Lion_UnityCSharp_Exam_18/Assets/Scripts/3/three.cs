using UnityEngine;

public class three : MonoBehaviour
{
    public GameObject cube;

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < (i+1); j++)
            {
                Vector3 pos = new Vector3(i * 1, j * 1, 0);
                Instantiate(cube, pos, Quaternion.identity);
            }            
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < (i+1); j++)
            {
                Vector3 pos = new Vector3(i * 1, j * -1, 0);
                Instantiate(cube, pos, Quaternion.identity);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                Vector3 pos2 = new Vector3(i * -1, j * 1, 0);
                Instantiate(cube, pos2, Quaternion.identity);
            }
        }

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < (i + 1); j++)
            {
                Vector3 pos2 = new Vector3(i * -1, j * -1, 0);
                Instantiate(cube, pos2, Quaternion.identity);
            }
        }
    }


    void Update()
    {
        
    }
}
