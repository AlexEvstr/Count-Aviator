using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Bonus
{
    public class BonusDetector : MonoBehaviour
    {
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
                            Debug.Log("WTF");
                        }
                        else if (hit.collider.gameObject.CompareTag("SpeedBonus"))
                        {
                            Debug.Log("LOL");
                        }
                        else if (hit.collider.gameObject.CompareTag("Background"))
                        {
                            return;
                        }
                    }                        
                }
            }
        }
    }
}