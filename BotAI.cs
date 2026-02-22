using UnityEngine;
public class BotAI : MonoBehaviour
{
    void Update(){ transform.Translate(Vector3.forward*2*Time.deltaTime); }
}
