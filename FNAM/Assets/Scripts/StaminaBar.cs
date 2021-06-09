using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StaminaBar : MonoBehaviour
{
	
	
    public Slider staminaBar;

    private int maxStamina = 100000;
    private int currentStamina;
    private Coroutine regen;

    public static StaminaBar instance;
        
    private void Awake()
    {
        instance = this;
    }
        
    void Start()
    {
        currentStamina = maxStamina;
        staminaBar.maxValue = maxStamina;
        staminaBar.value = maxStamina;
    }

    public void UseStamina(int amount)
    {
        if(currentStamina - amount >= 0)
        {
            currentStamina -= amount;
            staminaBar.value = currentStamina;
        }
        else
        {
        Debug.Log("Not enough stamina");
        }
    }
}
