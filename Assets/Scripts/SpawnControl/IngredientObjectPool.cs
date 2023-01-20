using System.Collections.Generic;
using UnityEngine;

namespace SpawnControl
{
    public class IngredientObjectPool : MonoBehaviour
    {
        public static IngredientObjectPool Instance;

        [SerializeField]
        private List<IngredientItem> objectsToPool;

        [SerializeField]
        private int amountToPoolForEachObject;
    
        private List<IngredientItem> _pooledObjects;

        private void Awake()
        {
            Instance = this;
        }

        void Start()
        {
            _pooledObjects = new List<IngredientItem>();
            for (var i = 0; i < objectsToPool.Count; i++)
            {
                for (var j = 0; j < amountToPoolForEachObject; j++)
                {
                    IngredientItem objectToPool = Instantiate(objectsToPool[i]);
                    objectToPool.gameObject.SetActive(false);
                    _pooledObjects.Add(objectToPool);
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }
}
