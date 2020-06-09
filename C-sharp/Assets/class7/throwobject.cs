
using UnityEngine;

public class throwobject : MonoBehaviour
{
    [Header("傷害值"), Range(5, 10)]
    public float damage;
    [Header("爆炸效果")]
    public GameObject explosion;

    ///<summary>
    ///爆炸
    /// </summary>
    private void Explosion()
    {
        GameObject exp = Instantiate(explosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(exp, 2.5f);
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
