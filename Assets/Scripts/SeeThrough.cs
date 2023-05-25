using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThrough : MonoBehaviour

{

    public GameObject seeThroughPrefab;

    public GameObject objectToDetect;

    private GameObject currentSphere;

    private void Update() {
        if (Input.GetMouseButtonDown(0)) {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit)) {
                if (hit.transform.gameObject == objectToDetect) {
                    if (currentSphere != null) {
                        Destroy(currentSphere);
                    }
                    else {
                        currentSphere = Instantiate(seeThroughPrefab, hit.point, Quaternion.identity);
                    }
                }
            }
        }
    }

}
