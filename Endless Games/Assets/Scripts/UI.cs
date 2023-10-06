using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UI : MonoBehaviour
{
    [SerializeField] Main main;
    [SerializeField] TMP_InputField inputFieldSpeed;
    [SerializeField] TMP_InputField inputFieldDistance;
    [SerializeField] TMP_InputField inputFieldDelay;

    private float speed = 3;
    private float distance = 7;
    private float delay = 3;

    public void SetStart()
    {
        SetSpeed();
        SetDistance();
        SetDelay();
    }

    public void SetSpeed()
    {       
        try
        {
            speed = float.Parse(inputFieldSpeed.text);
            
        }
        catch
        {
            inputFieldSpeed.text = speed.ToString();
        }
        main.SetSpeed(speed);
    }

    public void SetDistance()
    {

        try
        {
            distance = float.Parse(inputFieldDistance.text);

        }
        catch
        {
            inputFieldDistance.text = distance.ToString();
        }
        main.SetDistance(distance);
    }

    public void SetDelay()
    {
        
        try
        {
            delay = float.Parse(inputFieldDelay.text);

        }
        catch
        {
            inputFieldDelay.text = delay.ToString();
        }
        main.SetDelay(delay);
    }

}
