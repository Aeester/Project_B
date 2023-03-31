using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;                               //���� Hp�� private �ϰ� ���� 100 �Է�
    private int power = 50;                             //���� power�� private �ϰ� ���� 50 �Է�
    
    public void Attack()                                //�޼ҵ� Attack ����
    {
        Debug.Log(this.power + " �������� ������.");
    }

    public void Damage(int damage)                      //�޼ҵ� Damage ����
    {
       this.hp -= damage;
        Debug.Log(damage + "�������� ������");
    }

    public int GetHp()
    {
        return hp;
    }
}

public class Test_008 : MonoBehaviour
{
    public Text playerhp;                   //Player Hp �����ִ� UI
    public Text player2hp;                  //Player2 Hp �����ִ� UI


    Player mPlayer = new Player();               //Player Ŭ���� ���� New <===
    Player mPlayer2 = new Player();             //Player2 Ŭ���� ���� New <===
    // Start is called before the first frame update
    void Start()
    {
        mPlayer.Attack();                       //Player �޼ҵ� Attack ȣ��
        mPlayer.Damage(30);                     //Player �޼ҵ� Damage ȣ��
        Debug.Log(mPlayer.GetHp());
    }

    // Update is called once per frame
    void Update()
    {
        player2hp.text = "Player1 HP:  " + mPlayer.GetHp().ToString();
        player2hp.text = "Player2 HP:  " + mPlayer2.GetHp().ToString();

        if (Input.GetMouseButton(0))
        {
            mPlayer.Damage(1);
        }

        if (Input.GetMouseButtonDown(1)) 
        {
            mPlayer2.Damage(1);
        } 
    }
}
