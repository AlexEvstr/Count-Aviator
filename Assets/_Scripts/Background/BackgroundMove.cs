using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Background
{
    public class BackgroundMove : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverPanel;

        public static float speed = 2.0f;
        private void Start()
        {
            Time.timeScale = 1;
            speed = 2.0f;
            _gameOverPanel.SetActive(false);
        }
        private void Update()
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            if (speed <= 0)
            {
                Time.timeScale = 0;
                _gameOverPanel.SetActive(true);
            }
        }
    }
}
