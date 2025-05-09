using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalDoor : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Coin.totalCollected >= Coin.totalRequired)
            {
                SceneManager.LoadScene("Victoria");
            }
            else
            {
                Debug.Log("Todavía faltan monedas.");
            }
        }
    }
}
