using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : mon
{
    [Header("飛行範圍"), Range(1, 15)]
    public float range;

    ///<summary>
    ///飛行
    /// </summary>
    private void flying()
    {
        //Time.timeSinceLevelLoad 載入後的遊戲時間 從0增加
        //MathF.Sin() 曲線
        transform.Translate(0, range*Time.deltaTime*Mathf.Sin(Time.timeSinceLevelLoad*5), 0);
    }
    protected override void Update()
    {
        base.Update();             // 保留父類別內容
        flying();
    }

}
