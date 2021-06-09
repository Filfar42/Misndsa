using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotazioneMainCam : MonoBehaviour
{

    float speed = 1000;
    bool pass = true;
    private int frame = 0;

    void Update()
    {
        frame += 1;
        float HorizontalMovment = Input.GetAxis("Mouse X");
        if (HorizontalMovment != 0 && frame > 120)
        {
            Vector3 rotation = new Vector3(0, 0, 0);
            double posizione = transform.rotation.y;
            rotation.y = HorizontalMovment;
            if (posizione >= 0.38)
            {
                pass = false;
                if (HorizontalMovment < 0)
                {
                    transform.Rotate(rotation * (speed * Time.deltaTime));
                }
            }
            if (posizione <= -0.38)
            {
                pass = false;
                if (HorizontalMovment > 0)
                {
                    transform.Rotate(rotation * (speed * Time.deltaTime));
                }
            }
            if (pass == true)
            {
                transform.Rotate(rotation * (speed * Time.deltaTime));
            }
            pass = true;
       
        }
    }
}
