
using UnityEngine;      //引用 Unity API (函式庫:Unity 屬性、功能.....)

// 類別 class 定義一個物件
// 語法: class 類別名稱
// : MonoBehaviour 可以將此腳本掛在Unity物件上
// 類別必須放在物件上才會執行
public class class1 : MonoBehaviour
{
    // 定義類別成員
    // C#
    // 1.大小不一樣
    // 2. 括號成對出現 ()  {}  []  ''  ""  < >

    [Header("車1號")]
    public Car car1;
    [Header("車2號")]
    public Car car2;
      

    //事件:在特定時間會以指定次數執行的方法(名稱會是藍色)
    //開始事件:撥放遊戲時執行一次，初始設定
    private void Start()
    {
        // 輸出("文字訊息");
        // C# 結尾為分號 ;
        print("hello world~");

        // 取得與設定欄位
        // 取得 get(可以知道他的cc數是多少)
        print("車1號的cc數:"+car1.cc);
        print("車2號的品牌:"+car2.brand);


        // 設定 set
        car1.cc = 5555;
        car1.weight = 222.2f;
        car1.brand = "Toyota";
        car1.brake = true;
    }

}

