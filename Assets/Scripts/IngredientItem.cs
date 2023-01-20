using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;
using UnityEngine.Serialization;


[RequireComponent(typeof(Rigidbody))]
public class IngredientItem : MonoBehaviour
{
    [SerializeField] 
    private Rigidbody rigidbody;
    
    [SerializeField] 
    private Color ingredientColor;

    [ReadOnly]
    public Enums.IngredientType type;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    protected virtual void FreezeObject()
    {
        rigidbody.isKinematic = true;
    }
    
    protected virtual void UnlockAnyAxisConstraints()
    {
        rigidbody.constraints = RigidbodyConstraints.None;
    }

    
}
