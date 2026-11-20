using UnityEngine;
using UnityEngine.Events;

public class CoinCollect : MonoBehaviour
{
    private Collider2D _collider2D;
    public UnityEvent CoinCollected;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        LoadUnityThings();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player"))
            return;
        
        CoinCollected.Invoke();
        Destroy(gameObject);
    }
    
    private void LoadUnityThings()
    {
        _collider2D = GetComponent<Collider2D>();
    }
    
}
