using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemberCheck : MonoBehaviour
{
    public GameObject[] namePanel = new GameObject[6];

    // ���� ī�尡 ��������, �̸��� ǥ��
    public void CharactorActive(string name)
    {
        // nameCheck0 : ������
        // nameCheck1 : ������
        // nameCheck2 : ���ǿ�
        // nameCheck3 : �����
        // nameCheck4 : ������
        // nameCheck5 : ������
        switch (name)
        {
            case "charactor0": // ������
                namePanel[0].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
                break;

            case "charactor1": // �����
                namePanel[3].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
                break;

            case "charactor2": // ������
                namePanel[1].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
                break;

            case "charactor3": // ���ǿ�
                namePanel[2].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
                break;

            case "charactor4": // ������
                namePanel[4].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
                break;

            case "charactor5": // ������
                namePanel[5].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
                break;

            default:
                break;
        }


    }
}
