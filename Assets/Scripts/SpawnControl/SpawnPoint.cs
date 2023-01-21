using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public virtual bool IsValid()
    {
        return false;
    }
}