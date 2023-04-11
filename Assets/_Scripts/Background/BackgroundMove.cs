using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Background
{
    public class BackgroundMove : MonoBehaviour
    {
        public static float speed = 2.0f;

        private void Update()
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
