using UnityEngine;
public class ZoneDamage : MonoBehaviour
{
    public float dps = 5f;
    void OnTriggerStay(Collider c){
        if(c.TryGetComponent(out PlayerHealth h))
            h.TakeDamage(dps*Time.deltaTime);
    }
}
