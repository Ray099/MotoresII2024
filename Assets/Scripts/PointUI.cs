using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PointUI : MonoBehaviour
{
    //variables
    public TMP_Text scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //scoreText.text = PointManager.instance.GetScore().ToString();
    }

    public void OnClick_AddPoints()
    {
        PointManager.instance.AddPoints(10);

    }
    public void OnClick_SubtractPoints()
    {
        PointManager.instance.RemovePoints(10);

    }
}
