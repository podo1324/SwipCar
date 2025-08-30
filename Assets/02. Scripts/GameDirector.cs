using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    public GameObject car;
    public GameObject flag;
    public Text distance;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   float length = this.flag.transform.position.x - this.car.transform.position.x;

        if (length >= 0)
        {
            this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F3") + "m";
        }
        else
        {
            distance.GetComponent<Text>().text = "게임오버";
        }
    }
}
