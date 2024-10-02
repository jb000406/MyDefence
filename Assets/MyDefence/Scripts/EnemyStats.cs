using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyDefence
{

   /* public class EnemyStats : MonoBehaviour
    {
        #region Variables
        //라이프
        private static int lives;

        //라이프 읽기 전용 속성
        public static int Lives => lives;

        //게임 시작시 지급하는 초기 생명값
        [SerializeField] private static int startLives = 100;

        //라운드 별로 증가하는 생명값
        public static int AddLives = 0;

        public static int addMoney = 50;

        #endregion

        private void Start()
        {
            //초기화
            lives = startLives + AddLives;
        }

        public static void Damage(Transform target,int amount)
        {
            lives -= amount;

            if (lives <= 0)
            {
                Enemy enemy = target.GetComponent<Enemy>();
                enemy.Death();
                PlayerStats.AddMoney(addMoney);
            }
        }

        public static void AddHP(int amount, int count)
        {
            int HP = amount * count;
            AddLives = HP;
        }
    }*/
}