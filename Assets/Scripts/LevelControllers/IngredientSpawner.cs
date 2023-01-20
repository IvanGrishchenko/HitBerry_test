using UnityEngine;

public class IngredientSpawner : MonoBehaviour
{
    private ISpawnPointProvider _spawnPointsProvider;

    private void Awake()
    {
        _spawnPointsProvider = GetComponent<ISpawnPointProvider>();
    }

    public void SpawnObject(GameObject gameObj)
    {
        if (gameObj != null)
        {
            var spawnPoint = (IngredientSpawnPoint)_spawnPointsProvider.GetValidSpawnPoint();
            spawnPoint.isOccupied = true;
            
            gameObj.transform.position = spawnPoint.transform.position;
            gameObj.SetActive(true);
        }
        
    }
}