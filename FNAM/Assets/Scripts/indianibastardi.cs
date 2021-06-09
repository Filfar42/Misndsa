using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class indianibastardi : MonoBehaviour
{

    int frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(6, -5, 10);
    }

    // Update is called once per frame
    void Update()
    {
        frame++;
        if (frame == 120) { transform.position = new Vector3(-1, -5, 10); }
        if(frame == 240) { transform.position = new Vector3(-1, -5, 17); }

    }
}
