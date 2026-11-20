using UnityEngine;

public class JumpStartFunParicles : MonoBehaviour
{
    [SerializeField] private ParticleSystem ps;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartFunParticles()
    {
        ps.Play();
    }
}
