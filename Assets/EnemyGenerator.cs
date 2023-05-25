using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    public GameObject Enemy_0Prefab;
    //“G‚ÌoŒ»•p“x
    float span = 0.5f;
    float delta = 0;

    void Start()
    {
        
    }

    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject go = Instantiate(Enemy_0Prefab);
            float px = Random.Range(4.7f, -4.7f);
            go.transform.position = new Vector3(10, px, 0);
        }
    }
}
