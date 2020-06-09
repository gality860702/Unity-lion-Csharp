
using UnityEngine;

public class Class5_Mithod : MonoBehaviour
{
    [Header("是否開門")]
    public bool openDoor;
    [Header("分數")]
    public int score = 0;
    [Header("生命"), Range(0, 100)]
    public int Hp = 100;
    [Header("紅水")]
    public string prop = "紅水";

    public Day day;
    public Season season;

    [Header("道具數量"), Range(0, 5)]
    public int count;
    [Header("任務是否完成")]
    public bool complete;

    public string test;
    public int i = 1;
    public int j = 1;

    // GameObject 可存放階層面板或專案內的模型
    [Header("地板")]
    public GameObject cube;

    public int[] scores = { 100, 99, 88, 77, 66, 55 };

    private void CreateFloor(int length, int width)
    {
        //巢狀迴圈
        //注意初始名稱不能相同 // 使用for 迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i = 0)
        {
            print("for 迴圈取得資料:" + scores[i]);
        }
        for (int j = 0; j < width; j++)
        {
            for (int i = 0; i < length; i++)
            {
                // API 實例化(生成)
                // 生成(物件，座標，角度)
                // Vector3 三維向量(保存三個浮點數)
                // Quaternion 角度
                // Quaternion.identity 零角度
                // Quaternion.Euler(x,y,z) 歐拉角度, 0-360度
                Instantiate(cube, new Vector3(j * 2, 0, i * 2), Quaternion.Euler(270, 0, 0));
            }
        }
    }

    private void Awake()
    {

        #region 認識迴圈
        // 使用for 迴圈取得陣列資料
        for (int i = 0; i < scores.Length; i++)
        {
            print("for 迴圈取得資料:" + scores[i]);
        }

        // foreach 迴圈
        //語法:foreach ( 取得資料的類型，取得資料的名稱 in 陣列 ){執行次數為陣列數量}
        foreach (int item in scores)
        {
            print("foreach 迴圈取得資料:" + item);
        }
        CreateFloor(30, 5);

        // while 迴圈
        // while (布林值){ 當布林值為 TRUE 執行}
        // 迴圈之前評估，第一次判斷 i = 1
        while (i <= 10)
        {
            print("while 迴圈第:" + i + "次");
            i++;
        }

        // 迴圈之後評估 第一次判斷 j = 2
        do
        {
            print("do 迴圈第:" + j + "次");
            j++;
        } while (j <= 10);

        // for (初始值;條件;跌代器)
        for (int k = 1; k <= 10; k++)
        {
            print("for 迴圈第:" + k + "次");
        }

        for (int k = 10; k > 0; k--)
        {
            print("for 迴圈第:" + k + "次");
        }
        #endregion

        /*多行註解  
          for (int i = 0; i < 101; i++)
          {
              print("break 迴圈:" + i);

          //如果 i 等於10就打斷迴圈並且執行圈下方的程式 
              if (i == 10) break;
          }

          print("break 迴圈外的程式:" + i);
          */
          /*

          for (int i = 0; i < 10; i++)
          {
              print("return 迴圈:" + i);

              //如果 i 等於10就跳出方法外，下方程式皆不執行
              if (i == 10) return;
          }

          print("return迴圈外的程式:");
          */

        /*
       //執行結果:0-4 6-19 迴圈外的程式
        for (int i = 0; i < 20; i++)
        {
            if (i == 5) continue;
            print("continue 迴圈:" + i);
        }

        print("continue 迴圈外的程式");
        */

        for (int i = 0; i < 10; i++)
        {
            //goto標記名稱
            if (i == 5) goto Test;
            print("goto 迴圈:" + i);
        }

    //標記名稱:
    Test:
        //標記陳述式
        print("這是標記陳述式");

    }




    private void Start()
    {
        // if 判斷式
        // if(布林值){布林值=ture 時執行}
        if (true)
        {
            print("哈囉.我是if判斷式~");
        }
    }

    //更新事件:一秒直行約60次(60fps)
    private void Update()
    {
        // 當道具數量>=5，任務完成true
        // 三元運算子語法、布林運算式 ? 運算式A : 運算式B
        // 指派、呼叫 = ()
        complete = (count >= 5) ? true : false;

        test = score >= 60 ? "及格" : score >= 40 ? "補考" : "被當";


        /* 利用判斷式 if 方式寫法
        if (count >=5)
        {
          complete =true;
        }
         else
        {
            complete =false;
        }
        */
        /*
        switch(prop)
        {
            case "紅水":
                print("補 Hp~");
                break;
            case "藍水":
                print("補 Mp~");
                break;
            case "黃水":
                print("補 Np~");
                break;
            default:
                print("宇智波騙你~");
                break;
        }
        */
        switch (season)
        {
            case Season.Spring:
                break;
            case Season.Summer:
                break;
            case Season.Fall:
                break;
            case Season.Winter:
                break;
            default:
                break;
        }

        //當openDoor為true時執行 {開門}
        //當openDoor為false時執行 {關門}
        if (openDoor)
        {
            print("開門~");
        }

        else
        {
            print("關門~");
        }

        //大於 60及格
        //小於60不及格
        if (score >= 60)
        {
            print("及格~");
        }
        else if (score >= 40)
        {
            print("補考~");
        }
        else if (score >= 20)
        {
            print("付錢補考~");
        }
        else
        {
            print("被當~");
        }

        if (Hp >= 70)
        {
            print("安全");
        }
        else if (Hp >= 20)
        {
            print("警告");
        }
        else if (Hp >= 1)
        {
            print("危險");
        }
        else if (Hp <= 0)
        {
            print("死去");
        }



    }
}
