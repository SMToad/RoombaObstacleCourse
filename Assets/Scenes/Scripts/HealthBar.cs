using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class HealthBar : MonoBehaviour
{
    public int maxValue;
    public int currValue;
    public Image Mask;
    // Start is called before the first frame update
    void Start()
    {
        maxValue = (int) PlayerStats.hpMax;
        currValue = (int)PlayerStats.hpPlayer;
    }

    // Update is called once per frame
    void Update()
    {
        currValue = (int)PlayerStats.hpPlayer;
        GetCurrentFill();
    }
    void GetCurrentFill()
    {
        float fillAmount = (float)currValue / (float)maxValue;
        Mask.fillAmount = fillAmount;
    }
}
