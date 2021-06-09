using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam7 : MonoBehaviour
{
    private float speed = 1;
    private float frames = 1000;
    // Update is called once per frame
    void Update()
    {
        frames += 1;
        float HorizontalMovment = 1;
        Vector3 rotation = new Vector3(0, 0, 0);
        rotation.y = HorizontalMovment;
        transform.Rotate(rotation * (speed * Time.deltaTime));
        if (frames > 2000)
        {
            frames = 0;
            speed = 0 - speed;
        }

    }
}
