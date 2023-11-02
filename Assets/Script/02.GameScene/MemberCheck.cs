using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*
 * by 정훈
 * name Space 적용
 */
namespace Script._02.GameScene

{
    public class MemberCheck : MonoBehaviour
    {
        [Serializable]
        public class NameTag
        {
            /*
             * by 정훈
             * 객체 지향 방식으로 멤버 박스에 대한 class를 생성하여 재사용성을 높힘
             */
            public int memberNumber;
            public Image checkerBox;
            public Image checker;
        }

        [SerializeField] private Profile profile;

        // public GameObject[] namePanel = new GameObject[6];

        /*
         * by 정훈 
         * class로 선언한 NameTag 리스트를 선언 
         * Inspector에서 개별 할당
         */
        public List<NameTag> memberList = new List<NameTag>();

        private void Start()
        {
            /*
             * by 정훈
             * 체커박스 게임 시작시 초기화 세팅
             */ 
            foreach (var member in memberList)
            {
                member.checker.gameObject.SetActive(false);
            }
        }

        // ���� ī�尡 ��������, �̸��� ǥ��
        public void MatchMember(string memberName)
        {
            // nameCheck0 : 정선교
            // nameCheck1 : 박정혁
            // nameCheck2 : 선건우
            // nameCheck3 : 나재민
            // nameCheck4 : 이정훈
            // nameCheck5 : 장지후
            /*
             * by 정훈
             * Code 재사용을 위한 함수 생성 
             */
            int nameNumber = int.Parse(memberName);
            Checker(nameNumber);

            // 기존 코드
            // switch (name)
            // {
            //     case "charactor0": // ������
            //         namePanel[0].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
            //         break;
            //     case "charactor1": // �����
            //         namePanel[3].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
            //         break;
            //     case "charactor2": // ������
            //         namePanel[1].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
            //         break;
            //     case "charactor3": // ���ǿ�
            //         namePanel[2].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
            //         break;
            //     case "charactor4": // ������
            //         namePanel[4].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
            //         break;
            //     case "charactor5": // ������
            //         namePanel[5].gameObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 200 / 255f);
            //         break;
            //     default:
            //         break;
            // }
        }

        private void Checker(int nameNumber)
        {
            int memberCount = 0; //멤버체크완료 카운트 by 선교
            /*
             * by 정훈
             * 멤버 리스트 중 memberNumber가 동일한 오브젝트만 컬러 및 체커 활성화
             */ 
            foreach (var member in memberList)
            {
                if (member.memberNumber == nameNumber)
                {
                    member.checkerBox.GetComponent<Image>().color = new Color(0.0392f, 1f, 0f, 1f);
                    member.checker.gameObject.SetActive(true);
                    profile.ProfileOpen(member.memberNumber);

                    memberCount++; // 조건이 충족될 때마다 카운트를 증가시킴 by 선교

                    if (memberCount >= 6)
                    {
                        // 6개 이상의 조건이 충족되었을 때 시그널을 받도록 처리 by 선교
                        // 여기에 원하는 동작을 추가하십시오.
                    }
                }
            }
        }
    }
}
