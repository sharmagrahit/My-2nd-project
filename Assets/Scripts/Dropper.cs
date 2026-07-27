using UnityEngine;

public class Dropper : MonoBehaviour
{
    float TimeToWait = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        if (Time.time > TimeToWait)
        {
            Debug.Log("Time Has Elapsed");
        }
        
    }
}
