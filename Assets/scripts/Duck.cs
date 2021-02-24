using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Duck : MonoBehaviour
{   
    void Update()
    {
        transform.position += new Vector3(0, 0, -1) * Time.deltaTime * 10f;
        DestroyDuck();
        
    }

    public void DestroyDuck()
    {
        Destroy(gameObject, 10f);
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
        score.duckNum++; //Come from score script
    }
}
