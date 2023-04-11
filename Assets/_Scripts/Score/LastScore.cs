using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.ScoreGame
{
    public class LastScore : MonoBehaviour
    {
        [SerializeField] private Text _lastScoreText;
        private int _lastScore;

        private void Start()
        {
            _lastScore = PlayerPrefs.GetInt("LastScore");
            _lastScoreText.text = _lastScore.ToString();
        }
    }
}
