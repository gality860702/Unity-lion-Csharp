using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class far : ground
{
    [Header("停止距離"), Range(0, 10)]
    public float stopdistance;
    [Header("投擲物品")]
    public GameObject prop;
    [Header("投擲間隔"), Range(0, 5)]
    public float cd;
    [Header("死亡時間"),Range(5,10)]
    public float deadTime;
    
    /// <summary>
    /// 目標物件
    /// </summary>
    private Transform target;

    ///<summary>
    ///計時器
    /// </summary>
    private float timer;

    /// <summary>
    /// 繪製圖示物件:在 Scene 繪製圖示,遊戲內不會顯示
    /// </summary>
    private void OnDrawGizmos()
    {
        //圖示,顏色 =顏色(紅、綠、藍、透明)
        Gizmos.color = new Color(1, 0, 0, 0.5f);
        //圖示,繪製線條(起點,終點)
        Gizmos.DrawLine(transform.position, transform.position + transform.right*stopdistance);
    }

    private void Start()
    {
        target = GameObject.Find("house").transform;    // 遊戲物件,尋找("物件名稱"),變形元件
    }

    protected override void Update()
    {
        base.Update();
        Throw();
    }

    ///<summary>
    ///投擲
    /// </summary>
    private void Throw()
    {
        //距離 = 二維向量,距離(此物件座標、目標座標)
        float dis = Vector3.Distance(transform.position, target.position);
        //如果 距離 <= 停止距離
        if (dis <= stopdistance)
        { 
            speed = 0;          // 此物件移動速度會 = 0
            

            timer += Time.deltaTime;   //計時
            // 如果 計時器 >= cd
            if (timer >= cd)
            {
                timer = 0;              //計時器 歸零
                //生成(投擲物品 , 中心點 + 右邊 + 上方 、 角度)
                GameObject temp = Instantiate(prop, transform.position + transform.right + transform.up, Quaternion.identity);
                temp.GetComponent<Rigidbody2D>().AddForce(new Vector2(300, 150));
                temp.GetComponent<throwobject>().damage = damage;
            }


            Invoke("Explosion", deadTime);         // 延遲呼叫方法("方法名稱",延遲時間)
        }
    }
}
