using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDelete : MonoBehaviour
{

    //Unity�����̃I�u�W�F�N�g
    private GameObject unitychan;

    //Unity�����̈ʒu
    private float difference;

    //�A�C�e���̈ʒu
    private float item_difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����̈ʒu���擾
        this.difference = unitychan.transform.position.z;

        //�A�C�e���̈ʒu���擾
        this.item_difference = this.transform.position.z + 10f;

        //Unity����񂪃A�C�e����ʂ�z������폜
        if (this.difference >= this.item_difference)
        {
            Destroy(this.gameObject);
        }
    }



}
