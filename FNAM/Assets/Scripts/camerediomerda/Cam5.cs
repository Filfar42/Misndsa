using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam5 : MonoBehaviour
{
    private float speed = 3;
    private float frames = 700;
    // Update is called once per frame
    void Update()
    {
        frames += 1;
        float HorizontalMovment = 1;
        Vector3 rotation = new Vector3(0, 0, 0);
        rotation.y = HorizontalMovment;
        transform.Rotate(rotation * (speed * Time.deltaTime));
        if (frames > 1400)
        {
            frames = 0;
            speed = 0 - speed;
        }

    }
}
