using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class profile : MonoBehaviour
{
    [SerializeField]
    private float xSpeed;
    [SerializeField]
    private float ySpeed;
    // Start is called before the first frame update
    void Update()
    {   //Profile�� ȭ�� ������ �Ѿ�� ��ġ ����
        if (transform.position.x < -10.5)
        {   //y��ǥ�� ���� y��ǥ�� �޾� ������ �̾����� 
            transform.position = new Vector3(10.5f, transform.position.y, 0);
        }
    }
    private void FixedUpdate()
    {   //0.41f���� Ŀ���� ySpeed�� -�� �۾����� -�� ���� +�� ��ȯ
        if (transform.position.y >= 0.41f)
            ySpeed *= -1;
        else if (transform.position.y <= -0.41f)
            ySpeed *= -1;
        transform.position += new Vector3(xSpeed, ySpeed, 0);
    }
}
