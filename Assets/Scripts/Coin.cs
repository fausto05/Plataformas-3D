using UnityEngine;
using TMPro;

public class Coin : MonoBehaviour
{
    public static int totalCollected = 0;
    public static int totalRequired = 12;
    public TextMeshProUGUI coinText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            totalCollected++;
            Destroy(gameObject);
        }
    }

    void Update()
    {
        coinText.text = "Monedas: " + Coin.totalCollected + "/" + Coin.totalRequired;
    }
}
