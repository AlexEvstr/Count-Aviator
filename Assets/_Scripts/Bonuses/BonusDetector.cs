using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evstr.Background;
using Evstr.ScoreGame;

namespace Evstr.Bonus
{
    public class BonusDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _plus100Prefab;
        [SerializeField] private GameObject _speedUpPrefab;


        void Update()
        {
            if (Input.touchCount > 0)
            {
                if (Input.GetTouch(0).phase == TouchPhase.Began)
                {
                    var p = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position);
                    var hit = Physics2D.Raycast(p, Vector2.zero);
                    if (hit.collider != null)
                    {
                        if (hit.collider.gameObject.CompareTag("StarBonus"))
                        {
                            Score.score += 100;
                            hit.collider.gameObject.SetActive(false);
                            Instantiate(_plus100Prefab);
                        }
                        else if (hit.collider.gameObject.CompareTag("SpeedBonus"))
                        {
                            if (Score.timeIndex > 0.1f && BackgroundMove.speed < 22.0f)
                            {
                                Score.timeIndex -= 0.1f;
                                BackgroundMove.speed += 2f;
                            }
                            hit.collider.gameObject.SetActive(false);
                            Instantiate(_speedUpPrefab);
                        }
                    }                        
                }
            }
        }
    }
}