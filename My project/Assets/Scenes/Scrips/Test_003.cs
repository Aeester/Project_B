using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    public int herbNum = 1;                 //정수 herNum 선언후에 1을 입력 (public추가 ,
    // Start is called before the first frame update
    void Start()
    {
         int herbNum = 1; 

        if (herbNum == 1)                    //조건식 herbNum 이 1일 경우 안에 로직을 실행한다.
        {
            Debug.Log("체력을 50 회복");    //Console.log 창에 조건이 만족할 경우 해당 내용을 표시한다   
        }
        else
        {
            Debug.Log("체력 -50 ");        //Console.Log 창에 조건이 만족할 경우 해당 내용을 표시한다
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
