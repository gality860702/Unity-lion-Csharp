
using UnityEngine;

public class mon : MonoBehaviour
{
    [Header("移動速度"), Range(0, 100)]
    public float speed;
    [Header("傷害值"), Range(20, 200)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;

    ///<summary>
    ///移動
    /// </summary>
    protected void move()
    {
        //Time.deltatime
        transform.Translate(speed * Time.deltaTime, 0, 0);
    }

    ///<summary>
    ///爆炸
    /// </summary>
    private void Explosion()
    {


        //生成爆炸效果
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);


        Destroy(gameObject);
        Destroy(exp, 2.5f);
    }

    private void Awake()
    {
        Physics2D.IgnoreLayerCollision(8, 8);         //忽略圖層碰撞
    }
    protected virtual void Update()
    {
        move();   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "house")
        {
            collision.gameObject.GetComponent<house>().Damage(damage);
            Explosion();
        }
    }

}
