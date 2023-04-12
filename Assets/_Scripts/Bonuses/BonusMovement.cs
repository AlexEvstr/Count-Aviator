using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Bonus
{
    public class BonusMovement : MonoBehaviour
    {
        private float _speed = 2.0f;

        private void Update()
        {
            transform.Translate(Vector2.down * _speed * Time.deltaTime);
            if (transform.position.y < -7.0f)
            {
                gameObject.SetActive(false);
            }
        }
    }
}
