using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider slider;

    public void SetAmount(int amount)
    {
        slider.value = amount;
    }

    public void SetInit(int amount)
    {
        slider.maxValue = 100;
        slider.value = 100;

    }

}
