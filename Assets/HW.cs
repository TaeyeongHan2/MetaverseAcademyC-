using System;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class HW : MonoBehaviour
{
    //public int[] num = new int[4];
    //public int max;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    //4장 if문 실습
    //public int num;

    public int score;
    
    void Start()
    {

        // int num1 = int.Parse(Console.ReadLine());
        // string num2 = Console.ReadLine(Convert.ToString(num2));
        //
        // Debug.Log("몫"  + (num1 / num2));
        // Debug.Log("나머지" + );
        //Debug.Log("몫: " + n1 / n2);
        //Debug.Log("나머지: " +n1 % n2);

        //Debug.Log(fTemperature);
        //fTemperature = 9 / 5 * cTemperature + 32;
        //Debug.Log(fTemperature);

        //실습6
        /*
        for (int i = 0; i < 4; i++)
        {
            if (num[i] > num[i+1])
            {
                max = num[i];
            }
            else
            {
                max = num[i+1];
            }

        }
        Debug.Log(max);
    }
    */

        //if문 4장 실습1
        /*
        if (num % 2 == 0)
        {
            Debug.Log(num + "은 짝수입니다.");
        }
        else
        {
            Debug.Log(num + "은 홀수입니다.");
        }
        */
        
        //if문 4장 실습2

        if (score <= 90)
        {
            if (score < 80)
            {
                if (score < 70)
                {
                    if (score < 60)
                    {
                        Debug.Log("F학점입니다.");
                    }
                    else
                    {
                        Debug.Log("D학점입니다.");
                    }
                }
                else
                {
                    Debug.Log("C학점입니다.");
                }
            }
            else
            {
                Debug.Log("B학점입니다.");
            }
        }
        else
        {
            Debug.Log("A학점 입니다.");
        }

    }
    
    
    
    
   



    // Update is called once per frame
    void Update()
    {
        
    }
}
