using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ai : MonoBehaviour
{
    [SerializeField]
    GameObject sprite;
    [SerializeField]
    Camera Camera1, Camera2, Camera3, Camera4, Camera5, Camera6, Camera7;
    int frame = 0;
    int number = 0;
    int avanzamento = 0;
    bool Stanza1 = false, Stanza2 = false, Stanza3 = false, Stanza4 = true, Stanza5 = false, Stanza6 = false, Stanza7 = false;
    //int avanzamento = 0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(-3, -5, 40);
    }

    // Update is called once per frame
    void Update()
    {
        frame++;

        if (frame == 120)
        {
            if (Stanza4)
            {
                if (!Camera4.isActiveAndEnabled)
                {
                    if (number == 0 && avanzamento == 0)
                    {
                        transform.position = new Vector3(-0.44f, -4.403f, 34.95f);
                        transform.Rotate(0, -53.04f, 0, Space.Self);
                         avanzamento = 1;
                    }
                    if (number == 1 && avanzamento == 1)
                    {
                        transform.position = new Vector3(-3.67f, -5.536f, 33.27f);
                        transform.Rotate(0, -8.4f, 0, Space.Self);
                        avanzamento = 2;
                    }
                    if (number == 2 && avanzamento == 2)
                    {
                        transform.position = new Vector3(-4.754f, -5.536f, 38.254f);
                        transform.Rotate(-5.398f, -3.194f, -0.929f, Space.Self);
                        avanzamento = 3;
                    }
                    if(number == 3 && avanzamento > 2 && !Camera6.isActiveAndEnabled)
                    {
                        transform.position = new Vector3(-1.937f, -5.536f, 31.08f);
                        transform.Rotate(0, -97.294f, 0, Space.Self);
                        Stanza4 = false;
                        Stanza6 = true;  
                        avanzamento = 0;
                    }
                    if (number == 4 && avanzamento > 2 && !Camera3.isActiveAndEnabled)
                    {
                        transform.position = new Vector3(5.53f, -5.536f, 33.23f);
                        transform.Rotate(0, -24.258f, 0, Space.Self);
                        Stanza4 = false;
                        Stanza3 = true;
                        avanzamento = 0;
                    }
                }
                
                if (Stanza6)
                {
                    if(!Camera6.isActiveAndEnabled)             
                    {
                        if (number == 0 && avanzamento == 0)
                        {
                            transform.position = new Vector3(-7, -5.536f, 35);
                            avanzamento = 1;
                        }
                    }
                }
                if (Stanza3)
                {
                    if (!Camera3.isActiveAndEnabled)
                    {
                        if (number == 0 && avanzamento == 0)
                        {
                            transform.position = new Vector3(10, -5.536f, 37);
                            avanzamento = 1;
                        }
                    }
                }
            }
            number = Movment();
          
            frame = 0;
        }

        
    }

    int Movment()
    {
        int n = Random.Range(0, 5);
        return n;
    }
}
