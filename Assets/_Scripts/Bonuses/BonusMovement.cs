using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Bonus
{
    public class BonusMovement : MonoBehaviour
    {
        private float _speed = 3.0f;

        private void Update()
        {
            transform.Translate(Vector2.left * _speed * Time.deltaTime);
            if (transform.position.x < -13.0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
