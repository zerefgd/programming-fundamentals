using TMPro;
using UnityEngine;

public class CollectibleManager : MonoBehaviour
{
    [SerializeField] private int totalCoins;
    public int CoinsCollected { get; private set; }
    public bool AllCoinsCollected => CoinsCollected >= totalCoins;

    public TMP_Text _cointext;

    private void Start()
    {
        CoinsCollected = 0;
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            CollectCoin();
        }
    }

    public void CollectCoin()
    {
        CoinsCollected++;
        _cointext.text = "Coins: " + CoinsCollected.ToString();
        Debug.Log($"Coin collected! Total coins: {CoinsCollected}/{totalCoins}");
        if(AllCoinsCollected)
        {
            Debug.Log("All coins collected!");
            _cointext.text = "All Coins Collected!";
        }
    }

}
