using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_006 : MonoBehaviour
{
    public int[] array = new int[5];
    public int[] points = { 833, 99, 52, 93, 15 };
    // Start is called before the first frame update
    void Start()
    {
        array[0] = 2;
        array[1] = 10;
        array[2] = 5;
        array[3] = 15;
        array[4] = 3;

        for (int i = 0; i < 5; i++)          //for 문을 통해서 console 창에 모든 Array 배열 안에 있는 0 ~ 4까지 내용 표시
        {
            Debug.Log(array[i]);
        }

        for (int i = 0; i < points.Length; i++)      //배열의 길이를 가져오는 변수 (배열이름
        {
            if (points[i] > 90)
            {
                Debug.Log(points[i]);
            }
        }

        int sum = 0;

        for (int i = 0; i < points.Length; i++)
        {
            sum += points[i];
        }

        int average = sum;

        Debug.Log(average);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
