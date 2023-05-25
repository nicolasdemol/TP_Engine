using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 

public class SphereGrow : MonoBehaviour
{
    public float growTime = 1.0f;

    void Start()
    {
        StartCoroutine(ScaleUp());
    }

 

    IEnumerator ScaleUp()
    {
        float timer = 0;

 

        while (timer < growTime)
        {
            timer += Time.deltaTime;
            float scaleValue = Mathf.Lerp(0, 1, timer / growTime);
            transform.localScale = new Vector3(scaleValue, scaleValue, scaleValue);
            yield return null;
        }
    }
}