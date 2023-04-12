using System.Collections;
using System.Collections.Generic;
using Evstr.Bonus;
using UnityEngine;

namespace Evstr.Bonus
{
    public class BonusSpawner : MonoBehaviour
    {
        private float _xPosition;
        private float _yPosition = 28.0f;
        private float _xBoardLeft = -8.0f;
        private float _xBoardRight = -1.0f;
        private float _randomTime;


        private void Start()
        {
            StartCoroutine(SpawnObstacle());
        }

        private IEnumerator SpawnObstacle()
        {
            while (true)
            {
                _randomTime = Random.Range(5f, 10f);
                yield return new WaitForSeconds(_randomTime);
                GameObject bonus = ObjectPoolBonus.SharedInstance.GetPooledObject();
                _xPosition = Random.Range(_xBoardLeft, _xBoardRight);
                if (bonus != null)
                {
                    bonus.transform.position = new Vector2(_xPosition, _yPosition);
                    bonus.SetActive(true);
                }
            }
        }
    }
}
