using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace SpawnControl
{
    [DefaultExecutionOrder(-1)]
    public class IngredientObjectPool : MonoBehaviour
    {
        public static IngredientObjectPool Instance;

        [SerializeField]
        private List<IngredientItem> objectsToPool;

        [SerializeField]
        private int amountToPoolForEachObject;
    
        [SerializeField]
        private List<IngredientItem> pooledObjects;

        private void Awake()
        {
            Instance = this;
        }

        
        void Start()
        {
            pooledObjects = new List<IngredientItem>();
            for (var i = 0; i < objectsToPool.Count; i++)
            {
                for (var j = 0; j < amountToPoolForEachObject; j++)
                {
                    IngredientItem objectToPool = Instantiate(objectsToPool[i]);
                    objectToPool.gameObject.SetActive(false);
                    pooledObjects.Add(objectToPool);
                }
            }
        }

        public IngredientItem GetPooledObjectOfType(Enums.IngredientType type)
        {
            for (int i = 0; i < pooledObjects.Count; i++)
            {
                if (!pooledObjects[i].gameObject.activeInHierarchy &&
                    type == pooledObjects[i].type)
                {
                    return pooledObjects[i];
                }
            }
            return null;
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
