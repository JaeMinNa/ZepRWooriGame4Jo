using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScene : MonoBehaviour
{
    //button.onclick.AddListner() ����غ����� �õ�...
    //Button restartBtn;
    public void Restart()
    {
        //restartBtn = transform.GetChild(0).GetComponent<Button>();
        //restartBtn.onClick.AddListener(() => SceneManager.LoadScene("PlayScene"));

        // �����÷��� ȭ������
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        //button.onClick.AddListener();

        // ����ȭ������
        SceneManager.LoadScene("Start");
    }
}
