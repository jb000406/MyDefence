using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace MyDefence
{

    public class TitleUI : MonoBehaviour
    {
        #region Variables
        public SceneFader fader;
        [SerializeField] private string loadToScene = "MainMenu";

        //GotoMenu Ÿ�̸�
        [SerializeField] private float menuTimer = 10f;
        private float countdown = 0f;

        //showAnyKey
        public GameObject showAnyKey;
        [SerializeField] private float deleyTime = 3f;

        private bool isShow;

        #endregion
        // Start is called before the first frame update
        void Start()
        {
            //�ʱ�ȭ
            countdown = menuTimer;
            isShow = false;

            StartCoroutine(ShowAnyKey());
            //Invoke("ShowAnyKeyText", deleyTime);

        }

        // Update is called once per frame
        private void Update()
        {

            if(isShow == false)
            {
                return;
            }

/*            //10���� GotoMenu
            if(countdown >= 10f)
            {
                GotoMenu();
                return;
            }
            countdown -= Time.deltaTime;*/

            //�ƹ� Ű�� ������ ���θŴ� ������ �̵�
            if (Input.anyKeyDown && isShow)
            {
                GotoMenu();
                StopAllCoroutines();
                return;
            }
            
        }

        void GotoMenu()
        {
            fader.FadeTo(loadToScene);
        }


        IEnumerator ShowAnyKey()
        {
            //3�� ����
            yield return new WaitForSeconds(deleyTime);

            isShow = true;
            showAnyKey.SetActive(true);

            //10�� ����
            yield return new WaitForSeconds(menuTimer);
            GotoMenu();
        }

        void ShowAnyKeyText()
        {
            isShow = true;
            showAnyKey.SetActive(true);
        }

    }
}