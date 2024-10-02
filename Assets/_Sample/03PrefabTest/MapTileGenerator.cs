using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI.Table;

namespace Sample
{

    public class MapTileGenerator : MonoBehaviour
    {
        //�ʵ�
        //��Ÿ�� ������   
        public GameObject tilePrefab;
        //�����Ǵ� ��Ÿ�ϵ��� �θ� ������Ʈ
        public Transform parent;

        //��Ÿ�� ���� ���� Ȯ��
        private bool isCreate = false;

        float x = 0f;
        float y = 0f;

        int sum = 2;

        // Start is called before the first frame update
        void Start()
        {
            // [1] Ư���� ��ġ�� �����ϱ�
            /*Vector3 position = new Vector3(5.0f, 0f, 8.0f);
            Instantiate(tilePrefab, position, Quaternion.identity);*/

            //[2] 10x10 �� Ÿ�� �����ϱ�
            //CreateMapTile1();

            //[3] 6 x 8 ��Ÿ�� �����ϱ�
            //CreateMapTile2(6, 8);

            //[4] ���� ��ġ�� �� Ÿ�� �����ϱ�


            //[5] 1���Ŀ� ��Ÿ���� Ư���� ��ġ�� �����ϱ�
            //Debug.Log("[1]��ŸƮ�ڷ�ƾ �Լ� ȣǮ");
            //StartCoroutine(GenerateMapTile());
            //Debug.Log("[9]��ŸƮ�ڷ�ƾ �Լ� ���� �Ϸ�");

            //[6] 10x10 �� Ÿ�� �����ϴµ� Ÿ�� �ϳ��� ���
            //�ϳ���� 0.1�� ������ ���� Ÿ�� ���
            //StartCoroutine(GenerateMapTile1());

        }

        // Update is called once per frame
        void Update()
        {
            if(isCreate == false)
            {
                Debug.Log("[1]��ŸƮ�ڷ�ƾ �Լ� ȣ��");
                StartCoroutine(GenerateMapTile1());

                Debug.Log("[2]��ŸƮ�ڷ�ƾ �Լ� ȣ�� �Ϸ�");
                isCreate = true;
            }

            
            
        }

        /*void CreateMapTile()
        {
            for(int i = 1; i < 101; i++)
            {
                Vector3 position = new Vector3(x, 0f, y);
                Instantiate(tilePrefab, position, Quaternion.identity);
                x += sum;
                if(i % 10 == 0)
                {
                    y += sum;
                    x = 0f;
                }
            }
        }*/

        IEnumerator GenerateMapTile()
        {
            Debug.Log("[2]�ڷ�ƾ �Լ� ����");
            //2�� ����
            yield return new WaitForSeconds(2f);

            Debug.Log("[3]2�� ������ ��Ÿ�� ����");
            Vector3 position = new Vector3(5.0f, 0f, 8.0f);
            Instantiate(tilePrefab, position, Quaternion.identity);

            //2�� ����
            yield return new WaitForSeconds(2f);

            Debug.Log("[4]2�� ������ ��Ÿ�� ����");

            position = new Vector3(8.0f, 0f, 5.0f);
            Instantiate(tilePrefab, position, Quaternion.identity);

            Debug.Log("[5]�ڷ�ƾ �Լ� ����");
        }

        //10x10 �� Ÿ�� �����ϱ�
        void CreateMapTile1()
        {
            for (int i = 0; i < 10; i++)
            {
                for(int j = 0; j < 10; j++)
                {
                    Vector3 position = new Vector3(i * 2.0f, 0f, j * 2.0f);
                    Instantiate(tilePrefab, position, Quaternion.identity,this.transform);
                }
            }
        }

/*        //row x column �� ���׷����� ����� - 7 x 8
        void CreateMapTile(float a, float b)
        {
            for(int i = 1; i < a*b+1; i++)
            {
                Vector3 position = new Vector3(x, 0f, y);
                Instantiate(tilePrefab, position, Quaternion.identity);
                x += sum;
                if(i % a == 0)
                {
                    y += sum;
                    x = 0f;
                }
            }
        }*/

        //row x column �� ���׷����� ����� - 6 x 8
        void CreateMapTile2(int row , int column)
        {
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Vector3 position = new Vector3(i * 2.0f, 0f, -j * 2.0f);
                    Instantiate(tilePrefab, position, Quaternion.identity, this.transform);
                }
            }
        }

        void CreateMapTile3(int row, int column)
        {
            for (int i = 0; i < column; i++)
            {
                for (int j = 0; j < row; j++)
                {
                    Vector3 position = new Vector3(i * 2.0f, 0f, -j * 2.0f);
                    GameObject go = Instantiate(tilePrefab, this.transform);
                    go.transform.position = position;
                }
            }
        }

        void GenerateRandomMapTile(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    
                }
            }
        }

        IEnumerator GenerateMapTile1()
        {

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Vector3 position = new Vector3(i * 2.0f, 0f, j * 2.0f);
                    Instantiate(tilePrefab, position, Quaternion.identity, this.transform);
                    yield return new WaitForSeconds(0.1f);
                }
            }
        }
    }
}