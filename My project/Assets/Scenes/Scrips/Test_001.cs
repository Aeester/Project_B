using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   //한번만 실행됨
        int age;   //변수 age를 선언 
        age = 20; //변수 age에 30의 값을 입력
        Debug.Log(age);  //age에 입력된 값을 유니티 console 창에 보여줌

        float height1 = 160.5f;         //height에 160.5 값 선언
        float height2;                  //height2 선언

        height2 = height1;              //height2에 height1값을 입력
        Debug.Log(height2);           //heught2에 입력된 값을 유니티 console 창에 보여줌

        string name;                    //Name을 선언 
        name = "Sera";                   //Name에 Sera 입력
        Debug.Log(name);                //Name에 입력된 값을 유니티 Console창에 보여줌


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
