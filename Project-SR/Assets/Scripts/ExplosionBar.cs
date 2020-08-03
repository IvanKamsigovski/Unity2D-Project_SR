using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplosionBar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;

    public void SetMaxBar(int helth)
    {
        slider.maxValue = helth;
        slider.value = helth;

       fill.color = gradient.Evaluate(1f);
    }
    public void SetBar(int helth)
    {
        slider.value = helth;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
}
