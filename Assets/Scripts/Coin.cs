using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private float time = 7;
    private float variantTime = 0;

    private void OnEnable()
    {

    }

    private void OnDisable()
    {
        variantTime = 0;
    }
    // Start is called before the first frame update
    private void Update()
    {
        if (variantTime < time)
        {
            variantTime += Time.deltaTime;
        }
        else
        {
            //Destroy(this.gameObject);
            PoolManager.Instance.ReturnObjectToPool(this.gameObject);

        }
    }
}
