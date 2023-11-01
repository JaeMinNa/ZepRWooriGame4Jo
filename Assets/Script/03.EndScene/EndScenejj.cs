using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static UnityEngine.GraphicsBuffer;

public class EndScenejj : MonoBehaviour
{
    //button.onclick.AddListner()
    //Button restartBtn;
    public GameObject memberCharacter;

    // Start is called before the first frame update
    void Start()
    {
        // memberCharacter.transform.DOMoveY(1, 1).SetLoops(-1, LoopType.Restart);
        Sequence moveSequence = DOTween.Sequence();
        moveSequence.Append(memberCharacter.transform.DOMoveY(1, 0.3f)); // Y ��ǥ�� 1�� �̵�
        moveSequence.Append(memberCharacter.transform.DOMoveY(0, 0.5f)); // Y ��ǥ�� 0���� �̵�
        moveSequence.AppendInterval(0.5f);
        moveSequence.SetLoops(-1, LoopType.Restart); // ���� ����
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Restart()
    {
        //restartBtn = transform.GetChild(0).GetComponent<Button>();
        //restartBtn.onClick.AddListener(() => SceneManager.LoadScene("PlayScene"));

        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
        //button.onClick.AddListener();

        SceneManager.LoadScene("Start");
    }
}
