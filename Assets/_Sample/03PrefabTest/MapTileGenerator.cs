using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using static UnityEngine.Rendering.DebugUI.Table;

namespace Sample
{

    public class MapTileGenerator : MonoBehaviour
    {
        //필드
        //맵타일 프리펩   
        public GameObject tilePrefab;
        //생성되는 맵타일들의 부모 오브젝트
        public Transform parent;

        //맵타일 생성 여부 확인
        private bool isCreate = false;

        float x = 0f;
        float y = 0f;

        int sum = 2;

        // Start is called before the first frame update
        void Start()
        {
            // [1] 특정한 위치에 생성하기
            /*Vector3 position = new Vector3(5.0f, 0f, 8.0f);
            Instantiate(tilePrefab, position, Quaternion.identity);*/

            //[2] 10x10 맵 타일 생성하기
            //CreateMapTile1();

            //[3] 6 x 8 맵타일 생성하기
            //CreateMapTile2(6, 8);

            //[4] 랜덤 위치에 맵 타일 생성하기


            //[5] 1초후에 맵타일을 특정한 위치에 생성하기
            //Debug.Log("[1]스타트코루틴 함수 호풀");
            //StartCoroutine(GenerateMapTile());
            //Debug.Log("[9]스타트코루틴 함수 실행 완료");

            //[6] 10x10 맵 타일 생성하는데 타일 하나씩 찍기
            //하나찍고 0.1초 지연후 다음 타일 찍기
            //StartCoroutine(GenerateMapTile1());

        }

        // Update is called once per frame
        void Update()
        {
            if(isCreate == false)
            {
                Debug.Log("[1]스타트코루틴 함수 호출");
                StartCoroutine(GenerateMapTile1());

                Debug.Log("[2]스타트코루틴 함수 호출 완료");
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
            Debug.Log("[2]코루틴 함수 시작");
            //2초 지연
            yield return new WaitForSeconds(2f);

            Debug.Log("[3]2초 지연후 맵타일 생성");
            Vector3 position = new Vector3(5.0f, 0f, 8.0f);
            Instantiate(tilePrefab, position, Quaternion.identity);

            //2초 지연
            yield return new WaitForSeconds(2f);

            Debug.Log("[4]2초 지연후 맵타일 생성");

            position = new Vector3(8.0f, 0f, 5.0f);
            Instantiate(tilePrefab, position, Quaternion.identity);

            Debug.Log("[5]코루틴 함수 종료");
        }

        //10x10 맵 타일 생성하기
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

/*        //row x column 맵 제네레이터 만들기 - 7 x 8
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

        //row x column 맵 제네레이터 만들기 - 6 x 8
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