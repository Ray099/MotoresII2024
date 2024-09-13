using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Bullet : MonoBehaviour
{
    private float time = 10;
    private float variantTime = 0;

    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        variantTime = 0;
    }

    private void Update()
    {
        if(variantTime < time)
        {
            variantTime += Time.deltaTime;
        }
        else
        {
            //Destroy(this.gameObject);
            PoolManager.Instance.ReturnObjectToPool(this.gameObject);

        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //Destroy(this.gameObject);
        PoolManager.Instance.ReturnObjectToPool(this.gameObject);
    }
}
