using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam2 : MonoBehaviour
{
    private float speed = 2;
    private float frames = 2000;
    // Update is called once per frame
    void Update()
    {
        frames += 1;
        float HorizontalMovment = 1;
        Vector3 rotation = new Vector3(0, 0, 0);
        rotation.y = HorizontalMovment;
        transform.Rotate(rotation * (speed * Time.deltaTime));
        if (frames > 4000)
        {
            frames = 0;
            speed = 0 - speed;
        }

    }
}
