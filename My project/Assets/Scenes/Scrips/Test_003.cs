using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_003 : MonoBehaviour
{
    public int herbNum = 1;                 //���� herNum �����Ŀ� 1�� �Է� (public�߰� ,
    // Start is called before the first frame update
    void Start()
    {
         int herbNum = 1; 

        if (herbNum == 1)                    //���ǽ� herbNum �� 1�� ��� �ȿ� ������ �����Ѵ�.
        {
            Debug.Log("ü���� 50 ȸ��");    //Console.log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�   
        }
        else
        {
            Debug.Log("ü�� -50 ");        //Console.Log â�� ������ ������ ��� �ش� ������ ǥ���Ѵ�
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
