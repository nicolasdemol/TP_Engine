// using UnityEngine;
// using System.Collections;

// public class EngineSplitting : MonoBehaviour
// {
//     private void OnEnable()
//     {
//         // S'abonner à l'événement des vis désactivées
//         ScrewManager.OnAllScrewsDisabled += SplitEngine;
//     }

//     private void OnDisable()
//     {
//         // Se désabonner de l'événement des vis désactivées
//         ScrewManager.OnAllScrewsDisabled -= SplitEngine;
//     }

//     private IEnumerator SplitEngine()
//     {
//         // Mettre en œuvre votre algorithme de séparation du moteur ici
//         // Utiliser un lerp pour effectuer une transition smoothée (ease-in/out)
//         // Voici un exemple simplifié :

//         float duration = 2.0f; // Durée de la transition
//         float elapsedTime = 0.0f; // Temps écoulé depuis le début de la transition
//         Vector3 initialPosition = transform.position; // Position initiale du moteur
//         Vector3 targetPosition = transform.position + Vector3.up * 5.0f; // Position cible pour la séparation

//         while (elapsedTime < duration)
//         {
//             float t = Mathf.SmoothStep(0.0f, 1.0f, elapsedTime / duration); // Utilisation de Mathf.SmoothStep pour obtenir une interpolation smoothée

//             transform.position = Vector3.Lerp(initialPosition, targetPosition, t);

//             elapsedTime += Time.deltaTime;
//             yield return null;
//         }
//     }
// }