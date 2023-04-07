using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoop : MonoBehaviour
{
    private void Update()
    {
        if (transform.position.x < -25f)
        {
            transform.position = new Vector2(28f, 0);
        }
    }
}
