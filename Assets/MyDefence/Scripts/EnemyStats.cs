using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MyDefence
{

   /* public class EnemyStats : MonoBehaviour
    {
        #region Variables
        //������
        private static int lives;

        //������ �б� ���� �Ӽ�
        public static int Lives => lives;

        //���� ���۽� �����ϴ� �ʱ� ����
        [SerializeField] private static int startLives = 100;

        //���� ���� �����ϴ� ����
        public static int AddLives = 0;

        public static int addMoney = 50;

        #endregion

        private void Start()
        {
            //�ʱ�ȭ
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