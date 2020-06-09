using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calss6_static_api : MonoBehaviour
{
    //物件
    public enemy zombie1, zombie2;

    //修飾詞 非靜態所有成員 物件名稱
    public GameObject obj1;

    public Light myLight;

    public Transform tran1;

    private void Start()
    {
        #region 練習靜態
        //一般欄位
        print(zombie1.name + "血量" + zombie1.hp);
        print(zombie2.name + "血量" + zombie2.hp);

        //靜態欄位
        //取得方式:類別、靜態欄位名稱
        print("靜態欄位名稱:" + enemy.speed);

        //無法透過物件取得靜態欄位 (錯誤)
        //print(zombie1.speed);

        zombie1.Walk();
        zombie2.Walk();

        //使用靜態方法
        //類別,靜態方法
        enemy.Stop();


        //無法透過物件取得靜態方法 (錯誤)
        //zombie1.Stop();
        #endregion

        #region 靜態成員

        //存放 靜態 屬性
        //類別,靜態屬姓 = 值
        Cursor.visible = false;

        //取得 靜態 屬性
        print(Mathf.PI);

        //取得 隨機,值
        print(Random.value);

        //使用靜態方法
        //類別,靜態方法 (對應的引數)
        print("絕對值:" + Mathf.Abs(-77.7f));

        print("隨機的範圍:" + Random.Range(1f, 100f));

        //整數不傳回最大值
        print("隨機整數:" + Random.Range(1, 3));
        #endregion
        //錯誤: 非靜態不能透過類別存取
        //print(GameObject.layer);

        //靜態屬性與非靜態屬性區別
        //靜態屬性 不需要新增欄位 -Random.value
        //非靜態屬性 需要新增欄位 - Public GameObject obj1; obj1.layer

        //非靜態 屬性
        //物件名稱,非靜態屬性
        print("物件圖層:"+obj1.layer);
        //非靜態 需要有實體物件 - 存在遊戲場景內的物件
        print("燈光顏色:" + myLight.color);

        //tran1.localScale = new Vector3(5, 5, 5);

        //Vector3..one= new Vector3(1,1,1)
        tran1.localScale = Vector3.one * 5;
    }

    //偵測玩家輸入 -約60 FPS
    private void Update()
    {
        //原本用法:字串
        print("玩家是否按空白鍵:" + Input.GetKeyDown("space"));
        //多載 1 :  列舉
        print("玩家是否按右鍵:" + Input.GetKeyDown(KeyCode.Mouse1));

        //非靜態方法
        //物件名稱,非靜態方法(對應的引數)
        tran1.Rotate(1, 2, 3*Time.deltaTime);
    }
}
