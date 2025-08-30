using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    float moveSpeed = 0f;
    Vector2 startPos;
    bool chanceIsOne = false;
    
    Vector3 carStartPos;
    void Start()
    {
        carStartPos = transform.position;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && chanceIsOne.Equals(true) && moveSpeed.Equals(0))
        {
            Restart();
        }

            if (Input.GetMouseButtonDown(0) && chanceIsOne.Equals(false))
            {
                startPos = Input.mousePosition; // 마우스 클릭한 곳의 좌표
            }

            if (Input.GetMouseButtonUp(0) && chanceIsOne.Equals(false))
            {
                Vector2 endtPos = Input.mousePosition; // 마우스 클릭한 곳의 좌표

                float swipeLength = Mathf.Abs(endtPos.x - startPos.x);

                if (endtPos.x > startPos.x)
                {
                    moveSpeed = swipeLength / 500.0f;

                    GetComponent<AudioSource>().Play();

                    chanceIsOne = true;
                }

            }

            transform.Translate(moveSpeed, 0, 0);

            if (moveSpeed > 0)
            {
                moveSpeed *= 0.95f;
            }

            if (moveSpeed < 0.05f)
            {
                moveSpeed = 0;
            }

        
    }

    void Restart()
    {
        chanceIsOne = false;
        transform.position = carStartPos;
        moveSpeed = 0f;
    }
}
