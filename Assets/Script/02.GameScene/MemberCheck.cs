using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemberCheck : MonoBehaviour
{
    // nameCheck0 : ������
    // nameCheck1 : ������
    // nameCheck2 : ���ǿ�
    // nameCheck3 : �����
    // nameCheck4 : ������
    // nameCheck5 : ������
    public GameObject[] name = new GameObject[6];
    public bool[] nameCheck = new bool[6];

    void Start()
    {

    }

    void Update()
    {
        // ī�尡 �˸°� �������ٸ�
        for (int i = 0; i < 6; i++)
        {
            if (nameCheck[i] == true)
            {

                name[i].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);

            }
        }    
    }
}
