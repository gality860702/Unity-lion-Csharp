
using UnityEngine;
using UnityEngine.UI;

public class house : MonoBehaviour
{
    [Header("血量"), Range(100, 5000)]
    public float hp;
    [Header("血條")]
    public Image hpbar;

    private float hpMax;

    private void Awake()
    {
        hpMax = hp;
    }

    ///<summary>
    ///接收傷害值
    /// </summary>
    /// <param name="damage">傷害值</param>
    public void Damage(float damage)
    {
        hp -= damage;
        hpbar.fillAmount = hp / hpMax;
    }


}
