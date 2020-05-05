
using UnityEngine;
using UnityEngine.UI;


public class Detail : MonoBehaviour
{
    public int BatHP = 10;
    public int BatAttack = 2;
    public int BatHealth = 2;

    public int SlimeHp = 15;
    public int SlimeAttack = 1;
    public int SlimeHealth = 2;

    public Text result;
    public void mon1Attack()
    {
        SlimeHp = SlimeHp - BatAttack;
        result.text = "史萊姆血量" + SlimeHp +"\n"+ "蝙蝠攻擊" + BatAttack+"\n" +"史萊姆血量剩下"+(SlimeHp-BatAttack);
    }
    public void mon2Attack()
    {
        BatHP = BatHP - SlimeAttack;
        result.text = "蝙蝠血量" + BatHP + "\n" + "史萊姆攻擊" + SlimeAttack + "\n" + "蝙蝠血量剩下" + (BatHP - SlimeAttack);
    }
    public void mon1Health()
    {
        BatHealth = BatHP + BatHealth;
        result.text = "蝙蝠血量" + BatHP + "\n" + "蝙蝠回復" + BatHealth + "\n" + "蝙蝠血量為" + (BatHP + BatHealth);
    }
    public void mon2Health()
    { 
    SlimeHealth = SlimeHp + SlimeHealth;
        result.text = "史萊姆血量" + SlimeHp + "\n" + "史萊姆回復" + SlimeHealth + "\n" + "史萊姆血量為" + (SlimeHp + SlimeHealth);
        }


    
    
    

}
