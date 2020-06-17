using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class EnemyGenerator : MonoBehaviour
{
    public GameObject theEnemy;
    public int xPos;
    public int zPos;
    public int enemyCount=0;
    public int enemyLeft = 100;
    public float count_down = 2.2f;
    public int wait;
    private float spawnTime = 1.2f;
    
    public static float acceleration;

    void Start()
    {
        Debug.Log("begin coroutine");

        StartCoroutine(EnemyDrop());
       
    }

    IEnumerator EnemyDrop()
    {

        Debug.Log("EnemyDrop run");
        yield return new WaitForSeconds(spawnTime);

        do
        {

            Vector3 center = transform.position;
            Vector3 pos = RandomCircle(center, 4.1f);
            Quaternion rot = Quaternion.FromToRotation(Vector3.forward, center - pos);
            GameObject dude=Instantiate(theEnemy, pos, Quaternion.identity);
           
            enemyCount++;
            yield return new WaitForSeconds(2.2f);
            Destroy(dude);

            if (spawnTime > 0)
            {
                spawnTime = (spawnTime - .15f);
            }

            
        }
        while (enemyCount <= enemyLeft);
    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        Debug.Log("random spawn in a radius");

        float ang = Random.value * 360+1;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = .15f;// + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        return pos;
    }
}
