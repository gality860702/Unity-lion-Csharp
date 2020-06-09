using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shape : MonoBehaviour
{
    [Header("長寬高")]
    public float length;
    public float width;
    public float height;

    ///<summary>
    ///體積
    ///protected 保護:允許子類別存取禁止外部存取
    /// </summary>
    public  float volume;

    ///<summry>
    ///取得體積
    ///virtual 虛擬:允許子類別覆寫
    /// </summry>
    /// <return>體積</return>
    public virtual float GetVolume()
    {
        volume= length * width * height;
        return volume;
    }

}
