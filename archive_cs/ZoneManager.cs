using UnityEngine;
public class ZoneManager : MonoBehaviour
{
    public float shrinkSpeed = 0.5f;
    void Update(){ transform.localScale -= Vector3.one*shrinkSpeed*Time.deltaTime; }
}
