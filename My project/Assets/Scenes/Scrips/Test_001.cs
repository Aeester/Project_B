using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {   //�ѹ��� �����
        int age;   //���� age�� ���� 
        age = 20; //���� age�� 30�� ���� �Է�
        Debug.Log(age);  //age�� �Էµ� ���� ����Ƽ console â�� ������

        float height1 = 160.5f;         //height�� 160.5 �� ����
        float height2;                  //height2 ����

        height2 = height1;              //height2�� height1���� �Է�
        Debug.Log(height2);           //heught2�� �Էµ� ���� ����Ƽ console â�� ������

        string name;                    //Name�� ���� 
        name = "Sera";                   //Name�� Sera �Է�
        Debug.Log(name);                //Name�� �Էµ� ���� ����Ƽ Consoleâ�� ������


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
