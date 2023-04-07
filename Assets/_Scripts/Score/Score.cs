using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.Score
{
    public class Score : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;
        private int _score;
        public static float timeIndex = 1.0f;

        private void Start()
        {
            StartCoroutine(IncreaseScore());
        }

        private IEnumerator IncreaseScore()
        {
            while (true)
            {
                _score++;
                _scoreText.text = _score.ToString();
                yield return new WaitForSeconds(timeIndex);
            }
        }
    }
}
