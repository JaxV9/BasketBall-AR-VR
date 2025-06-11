using UnityEngine;
using TMPro; // Nécessaire pour TextMeshPro

public class BallScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText; // Assigné dans l'éditeur Unity
    private int score = 0;

    // Détection quand le ballon entre dans le panier (Collider en mode Trigger)
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Basket")) // Vérifie si c'est le panier
        {
            AddPoint();
        }
    }

    // Détection quand le ballon touche le panier (Collider non-trigger)
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Basket"))
        {
            AddPoint();
        }
    }

    void AddPoint()
    {
        score++;
        scoreText.text = "Score: " + score; // Met à jour le texte
        Destroy(gameObject); // Détruit le ballon (optionnel)
    }
}