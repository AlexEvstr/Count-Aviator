using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.ScoreGame
{
    public class Score : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;
        public static int score;
        public static float timeIndex = 1.0f;

        private void Start()
        {
            StartCoroutine(IncreaseScore());
            score = 0;
        }

        private IEnumerator IncreaseScore()
        {
            while (true)
            {
                yield return new WaitForSeconds(timeIndex);
                score++;
                _scoreText.text = score.ToString();
            }
        }

        private void OnDisable()
        {
            PlayerPrefs.SetInt("LastScore", score);
        }
    }
}
