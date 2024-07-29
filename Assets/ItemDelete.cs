using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{

    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //Unityちゃんの位置
    private float difference;

    //アイテムの位置
    private float item_difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置を取得
        this.difference = unitychan.transform.position.z;

        //アイテムの位置を取得
        this.item_difference = this.transform.position.z + 10f;

        //Unityちゃんがアイテムを通り越したら削除
        if (this.difference >= this.item_difference)
        {
            Destroy(this.gameObject);
        }
    }



}
