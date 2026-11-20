using UnityEngine;
using TMPro;

public class CounCountUp : MonoBehaviour
{
    public TextMeshProUGUI coinCount;

    private int _count = 0;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinCount.text = "Coins: " + _count;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CountUp()
    {
        _count++;
        coinCount.text = "Coins: " + _count;
    }
}
