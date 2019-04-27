using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{

    //キューブの移動速度
    private float speed = -0.2f;

    //消滅位置
    private float deadLine = -10;



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        //画面外に出たら破壊する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }

    }

    void OnCollisionEnter2D(Collision2D collision2D)
    {
        Debug.Log("あたった！");
//        if (other.gameObject.tag != "unitychan")
//        {
        this.GetComponent<AudioSource>().Play();
//        }

    }
}