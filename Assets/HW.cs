using System;
using UnityEditor;
using UnityEngine;
using UnityEngine.Rendering.Universal;

public class HW : MonoBehaviour
{
    //public int num1, num2, num3;

    //public int max;
    //public int min;

    //public int[] num = new int[4];

    //public char day;



    ///public int change;

    // Start is called once before the first execution of Update after the MonoBehaviour is created

    //4장 if문 실습
    //public int num;

    //public int score;

    void Start()
    {

        //실습6-1
        /*
        max = num1;
        if (num2 > num1)
        {
            max = num2;
            if (num3 > num2)
            {
                max = num3;
                if (num4 > num3)
                {
                    max = num4;
                }
            }
        }
        */

        //실습 6-2
        /*
        min = num1;
        if (num2 < num1)
        {
            min = num2;
        }
        if (num3 < min)
        {
            min = num3;
        }
        if (num4 < min)
        {
            min = num4;
        }
        */

        //실습7
        /*
        int num1,num2,num3,num4; //순서대로 500원,100원,50원,10원
        num1 = change / 500;
        change -= 500 * num1;
        num2 = change / 100;
        change -= 100 * num2;
        num3 = change / 50;
        change -= 50 * num3;
        num4 = change / 10;

        Debug.Log($"거스름돈: 500원 X {num1}, 100원 X {num2}, 50원 X {num3}, 10원 X {num4}");
        */

        //실습8
        /*
        int max = 0;
        max = num1;
        if (num2 > max)
        {
            max = num2;
        }
        else if (num3 > max)
        {
            max = num3;
        }
        else
        {
            Debug.Log("잘못입력하였습니다.");
        }
        Debug.Log(max);

        if ((num1 + num2 + num3) > 2 * max)
        {
            Debug.Log("삼각형이 가능합니다.");
        }
        else
        {
            Debug.Log("삼각형이 불가능합니다.");
        }
        */

        //정렬
        /*
        int max_length = 0;
        int middle_length = 0;
        int min_length = 0;
        if (num2 > num1)             //예를 들어 num1 = 10, num2 =6, num3 = 15
        {
            max_length = num2;
            min_length = num1;
            if (num3 > num2)
            {
                max_length = num3;
            }
            else
            {
                middle_length = num2;
            }
        }
        else
        {
            max_length = num1;
            min_length = num2;
        }

        if(max_length < middle_length + min_length)
        {
            Debug.Log("삼각형이 가능합니다.");
        }
        else
        {
            Debug.Log("삼각형이 불가능합니다.");
        }
        */

        //실습9
        ////사용자가 문자를 입력하면 정수로 변환이 된 후에 각각의 값에 따라 해당 요일이 수영장을 가는날인지 출력
     
        
        
        
        
    }





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
        /*
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
    
    */








        // Update is called once per frame
        void Update()
        {

        }

}
