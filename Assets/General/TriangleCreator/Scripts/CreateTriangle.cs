using UnityEngine;

public class CreateTriangle : MonoBehaviour
{
    
    [SerializeField] private GameObject trianglePrefab;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CreateTriangles()
    {
        Instantiate(trianglePrefab, transform.position + new Vector3(0, 2, 0), transform.rotation);
    }
}
