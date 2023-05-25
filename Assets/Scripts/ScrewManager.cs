using UnityEngine;
using UnityEngine.Events;

public class ScrewManager : MonoBehaviour
{
    public UnityEvent OnAllScrewsDisabled;

    private int totalScrews;
    private int disabledScrews;

    private void Awake()
    {
        // Comptez le nombre total de vis dans la scène au démarrage
        totalScrews = GameObject.FindGameObjectsWithTag("Vis").Length;
    }

    private void Update()
    {
        // Vérifiez si le joueur a cliqué avec le bouton gauche de la souris
        if (Input.GetMouseButtonDown(0))
        {
            // Lancez un raycast à partir de la position de la souris
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                // Vérifiez si l'objet touché est une vis
                if (hit.collider.CompareTag("Vis"))
                {
                    // Désactivez la vis touchée
                    hit.collider.gameObject.SetActive(false);
                    disabledScrews++;

                    // Vérifiez si toutes les vis ont été désactivées
                    if (disabledScrews == totalScrews)
                    {
                        // Déclenchez l'événement OnAllScrewsDisabled
                        if (OnAllScrewsDisabled != null)
                        {
                            OnAllScrewsDisabled.Invoke();
                        }
                    }
                }
            }
        }
    }
}
