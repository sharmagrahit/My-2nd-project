using UnityEngine;

public class Dropper : MonoBehaviour
{
    float TimeToWait = 5f;
    MeshRenderer renderer;
    Rigidbody rigidbody;

    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        
        renderer.enabled = false;
        rigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time > TimeToWait)
        {
            renderer.enabled = true;
            rigidbody.useGravity = true; 
        }
        
    }
}
