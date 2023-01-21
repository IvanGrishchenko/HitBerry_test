using System.Collections.Generic;
using UnityEngine;

public class IngredientSelectionSpawnPointProvider : MonoBehaviour, ISpawnPointProvider
{
    public List<SpawnPoint> spawnPoints;

    public SpawnPoint GetValidSpawnPoint()
    {
        for (int i = 0; i < spawnPoints.Count; i++)
        {
            if (spawnPoints[i].IsValid())
                return spawnPoints[i];
        }

        return null;
    }
}