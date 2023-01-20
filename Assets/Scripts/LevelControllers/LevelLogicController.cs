using System;
using System.Collections;
using SpawnControl;
using UnityEngine;
using UnityEngine.Serialization;

//[DefaultExecutionOrder(100)]
public class LevelLogicController : MonoBehaviour
{
    public static LevelLogicController Instance;

    private IngredientSpawner _spawner;

    [SerializeField]
    private IngredientObjectPool ingredientObjectPool;

    private void Awake()
    {
        Instance = this;
        _spawner = GetComponent<IngredientSpawner>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _spawner.SpawnObject(ingredientObjectPool
            .GetPooledObjectOfType(Enums.IngredientType.Apple).gameObject);
        
        _spawner.SpawnObject(ingredientObjectPool
            .GetPooledObjectOfType(Enums.IngredientType.Banana).gameObject);
    }


}