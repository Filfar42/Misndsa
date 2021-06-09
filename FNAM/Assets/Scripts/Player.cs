using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    bool sex = false;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.LeftControl))
        {
            if (sex == true)
                sex = false;
            else
                sex = true;
        }

        if(sex == true)
        {
           StaminaBar.instance.UseStamina(1);
        }
    }
}
