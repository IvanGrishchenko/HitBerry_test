using System.ComponentModel;
using UnityEngine;

public class IngredientSpawnPoint : SpawnPoint
{
    public bool isOccupied = false;
    
    [ReadOnly(true)] 
    public Enums.IngredientType type;

    public override bool IsValid()
    {
        return isOccupied == false;
    }
}