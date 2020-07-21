using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour
{
    private Vector3 direction;
    public float speed = 10f;

    public void Move()
    {

        //浮點數 前後值 = 輸入類別.取得軸向("垂直") 垂直WS上下
        float v = Input.GetAxisRaw("Vertical");
        float h = Input.GetAxisRaw("Horizontal");


        if (v == 1) direction = new Vector3(0, 0, 0);
        if (v == -1) direction = new Vector3(0, 180, 0);
        if (h == 1) direction = new Vector3(0, 90, 0);
        if (h == -1) direction = new Vector3(0, 270, 0);

        transform.eulerAngles = direction;

    }

    private void Start()
    {

    }

    private void FixedUpdate()
    {
        Move();
    }
}
