using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartScene : MonoBehaviour
{
    public GameObject profile;
    public GameObject strBtn;
    public AudioSource audioSource;
    public AudioClip clip;

    void Start()
    {   //AudioSource�� clip�� �����Ͽ� ���� �־��ֱ�
        audioSource.clip = clip;
        //Start������ �ѹ� �����Ͽ� ��� ����ϰ� �����
        audioSource.Play();
        for (int i = 0; i < 6; i++)
        {
            GameObject newProfile = Instantiate(profile);
            //�̸� �����ص� �θ� ������Ʈ�� �ڽ����� �����ϱ� ���� �ڵ�
            newProfile.transform.parent = GameObject.Find("LoopObjcet").transform;
            float x = (i % 7) * 3.5f - 7f;
            //¦���� Ȧ�� ���� ��ġ
            if (i % 2 == 0)
                newProfile.transform.position = new Vector3(x, 0.4f, 0);
            else
                newProfile.transform.position = new Vector3(x, -0.4f, 0);

            //newProfile�� �ڽ��� ã�� �ڽ��� SpriteRenderer�� sprite �������ֱ�
            newProfile.transform.GetChild(0).GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(i.ToString());

        }
        //strBtn�� Button�� btn���� ������� ���
        Button btn = strBtn.transform.GetComponent<Button>();
        //AddListener(�Լ�)�� ����Ͽ� ��ư�� �Լ� ����
        btn.onClick.AddListener(startBtn);
    }
    public void startBtn()
    {   //SceneManager�� �̿��Ͽ� Scene �ҷ�����
        SceneManager.LoadScene("Game");
    }
}
