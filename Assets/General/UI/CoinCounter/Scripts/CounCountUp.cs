using UnityEngine;
using TMPro;

public class CounCountUp : MonoBehaviour
{
    public TextMeshProUGUI coinCount;

    public int count = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinCount.text = "Coins: " + count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountUp()
    {
        count++;
        coinCount.text = "Coins: " + count;
    }
}
