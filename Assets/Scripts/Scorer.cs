using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SocialPlatforms;

public class Scorere : MonoBehaviour
{
    int hits =0;
void OnCollisionEnter(Collision other)
{
    hits = hits + 1;
 Debug.Log("You have bumped into the wall " + hits + "Times");
}
}
