using UnityEngine;
using UnityEngine.Events;

public class CevinCoinCheck : MonoBehaviour
{
    public UnityEvent LowCoinCount;
    public UnityEvent HighCoinCount;
    
    [SerializeField] private CounCountUp coinCounter;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CheckCoin()
    {
        if (coinCounter.count >= 5)
        {
            HighCoinCount.Invoke();
        }
        else
        {
            LowCoinCount.Invoke();
        }
    }
}
