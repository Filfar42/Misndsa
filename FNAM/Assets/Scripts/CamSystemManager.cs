using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamSystemManager : MonoBehaviour
{

    public GameObject MainCamera, Camera1, Camera2, Camera3, Camera4, Camera5, Camera6, Camera7, CamSystem;
    public bool CamSystemActive;


    void Start()
    {
        CamSystem.SetActive(false);
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        MainCamera.SetActive(true);

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {

            CamSystemActive = !CamSystemActive;

            if (CamSystemActive)
            {
                ActivateCamSystem();
            }

            if (!CamSystemActive)
            {
                DeActivateCamSystem();
                Camera1.SetActive(false);
                Camera2.SetActive(false);
                Camera3.SetActive(false);
                Camera4.SetActive(false);
                Camera5.SetActive(false);
                Camera6.SetActive(false);
                Camera7.SetActive(false);
                MainCamera.SetActive(true);
            }

        }
    }

    void ActivateCamSystem()
    {
        CamSystem.SetActive(true);
        Camera1.SetActive(true);
        MainCamera.SetActive(false);
    }

    void DeActivateCamSystem()
    {
        CamSystem.SetActive(false);
    }


    public void SetCamera1()
    {
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        MainCamera.SetActive(false);

    }

    public void SetCamera2()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        MainCamera.SetActive(false);

    }

    public void SetCamera3()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(true);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        MainCamera.SetActive(false);

    }

    public void SetCamera4()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(true);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        MainCamera.SetActive(false);

    }

    public void SetCamera5()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(true);
        Camera6.SetActive(false);
        Camera7.SetActive(false);
        MainCamera.SetActive(false);

    }

    public void SetCamera6()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(true);
        Camera7.SetActive(false);
        MainCamera.SetActive(false);

    }

    public void SetCamera7()
    {
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
        Camera7.SetActive(true);
        MainCamera.SetActive(false);

    }

}
