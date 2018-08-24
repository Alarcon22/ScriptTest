using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
    private int hp = 100;   //体力
    private int power = 25;　　//攻撃力
    private int mp = 53; //魔法
    
    //攻撃用の関数
    public void Attack()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }
    //防御用の関数
    public void Defence(int damage)
    {
        Debug.Log( damage + "のダメージを受けた");
        //残りのhpを減らす
        this.hp -= damage;
    }
    //魔法用の関数
    public void Magic(int needmp)
    {
        if (this.mp >= needmp)
        {
            this.mp -= needmp;
            Debug.Log("魔法攻撃をした。残りMPは。"+this.mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}
    public class test : MonoBehaviour
{ 

        void Start()
        {
            //Bossクラスの変数を宣言してインスタンスを代入
            Boss lastboss = new Boss();
             int[] array = new int[5];
                lastboss.Magic(5);

        for(int i = 0; i < 10; i++)
        {
            lastboss.Magic(5);
        }


       //配列の要素表を代入
        array[0] = 40;
        array[1] = 30;
        array[2] = 20;
        array[3] = 10;
        array[4] = 60;

        //配列の表示
        for(int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        
        //攻撃用の関数を呼び出す
            lastboss.Attack();
        //防御用の関数を呼び出す
            lastboss.Defence(3);
        //魔法用の関数を呼び出す
            lastboss.Magic(0);
        }
        //update is called once per frame
        void update()
        {

        }
    }
