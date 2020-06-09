
using UnityEngine;

public class mongm : MonoBehaviour
{
    [Header("怪物陣列 0 狐狸 1 老鷹 2 老鼠 3 青蛙")]
    public GameObject[] monsters;

    ///<summary>
    ///生成怪物
    /// </summary>
    
    public void CreateMonster(int index)
    {
        Instantiate(monsters[index], new Vector3(-10, 2, 0), Quaternion.identity);
    }


}
