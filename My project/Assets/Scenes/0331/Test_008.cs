using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;                               //변수 Hp를 private 하게 선언 100 입력
    private int power = 50;                             //변수 power를 private 하게 선언 50 입력
    
    public void Attack()                                //메소드 Attack 생성
    {
        Debug.Log(this.power + " 데미지를 입혔다.");
    }

    public void Damage(int damage)                      //메소드 Damage 생성
    {
       this.hp -= damage;
        Debug.Log(damage + "데미지를 입혔다");
    }

    public int GetHp()
    {
        return hp;
    }
}

public class Test_008 : MonoBehaviour
{
    public Text playerhp;                   //Player Hp 보여주는 UI
    public Text player2hp;                  //Player2 Hp 보여주는 UI


    Player mPlayer = new Player();               //Player 클래스 생성 New <===
    Player mPlayer2 = new Player();             //Player2 클래스 생성 New <===
    // Start is called before the first frame update
    void Start()
    {
        mPlayer.Attack();                       //Player 메소드 Attack 호출
        mPlayer.Damage(30);                     //Player 메소드 Damage 호출
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
