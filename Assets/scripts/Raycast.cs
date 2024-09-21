using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    [SerializeField] private float raycastLength;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Physics2D hit;
        Physics2D.Raycast(transform.position, Vector2.right, raycastLength, LayerMask.NameToLayer("Ground"));*/
        if (Physics2D.Raycast(transform.position, Vector2.right, raycastLength, 1 << LayerMask.NameToLayer("Ground")))
        {
            Debug.Log("Hit");
        }
        else
        {
            Debug.Log("No hit");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(transform.position, transform.position + (Vector3.right ) * raycastLength);
    }
}
