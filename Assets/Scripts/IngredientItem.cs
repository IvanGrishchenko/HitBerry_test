using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;


public class IngredientItem : MonoBehaviour
{
    public enum IngredientType
    {
        Apple,
        Banana,
        Tomato,
        Orange,
        Cucumber,
        Cherry,
        Eggplant
    }

    [SerializeField] 
    private Rigidbody rigidbody;
    
    [SerializeField] 
    private Color ingredientColor;         

    [ReadOnly]
    public IngredientType ingredientType;



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
