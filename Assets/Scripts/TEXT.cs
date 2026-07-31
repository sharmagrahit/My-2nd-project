using TMPro;
using UnityEngine;

public class TEXT : MonoBehaviour
{
    [SerializeField]float TimeToWait =  10f;
    TextMeshPro Text;
    void Start()
    {
        
    }
    
    void Update()
    {
        if (Time.time > TimeToWait)
        {
        Text = GetComponent<TextMeshPro>();
        Text.enabled = false;
        }
    }
}
