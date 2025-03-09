using System.Collections;
using UnityEngine;

/*
public class Script
{
    enum Animal
    {
        Dog,
        Cat,
        Lion,
        Tiger,
        Bear,
        Ok
    }

    void start()
    {
        Animal animal = Animal.Dog;
        
        switch (animal)
        {
            case Animal.Dog: Debug.Log("Dog"); break;
            case Animal.Cat: Debug.Log("Cat"); break;
            case Animal.Lion: Debug.Log("Lion"); break;
            case Animal.Tiger: Debug.Log("Tiger"); break;
            case Animal.Bear: Debug.Log("Bear"); break;
            
            default:
                break;
        }
    }
}
*/

//코루틴, 1초에 한번씩 현재 시각을 출력하는 코드
/*
public class Coroutine
{
    
    //Coroutine startCoroutine;
    
    IEnumerator Step(int count)
    {
        //1초마다 현재시각을 출력
        for (int i = 0; i <= count; i++)
        {
            Debug.Log(System.DateTime.Now.ToString("yyyy/MM/dd hh:mm:ss"));
            //현재시간을 출력한
            yield return new WaitForSecondsRealtime(1.0f);
            Debug.Log("야옹");
        }
    }

    void Start()
    {
        StartCoroutine(Step(100));
    }
}
*/
