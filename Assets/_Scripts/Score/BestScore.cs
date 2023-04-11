using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.Score
{
    public class BestScore : MonoBehaviour
    {
        [SerializeField] private Text _bestScoreText;
        private int _bestScore;

        private void Start()
        {
            _bestScore = PlayerPrefs.GetInt("BestScore");
        }
        private void Update()
        {
            if(_bestScore <= Score.score)
                _bestScore = Score.score;
            _bestScoreText.text = _bestScore.ToString();
        }

        private void OnDisable()
        {
           PlayerPrefs.SetInt("BestScore", _bestScore);
        }
    }
}
