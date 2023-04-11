using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Bonus
{
    public class ObjectPoolBonus : MonoBehaviour
    {
        public static ObjectPoolBonus SharedInstance;
        public List<GameObject> pooledObjects;
        public GameObject[] objectToPool;
        public int amountToPool;

        void Awake()
        {
            SharedInstance = this;
        }

        void Start()
        {
            pooledObjects = new List<GameObject>();
            GameObject tmp;
            for (int i = 0; i < amountToPool; i++)
            {
                for (int j = 0; j < objectToPool.Length; j++)
                {
                    tmp = Instantiate(objectToPool[j]);
                    tmp.SetActive(false);
                    pooledObjects.Add(tmp); 
                }
            }
        }

        public GameObject GetPooledObject()
        {
            for (int i = 0; i < amountToPool; i++)
            {
                if (!pooledObjects[i].activeInHierarchy)
                {
                    return pooledObjects[i];
                }
            }
            return null;
        }
    }
}
