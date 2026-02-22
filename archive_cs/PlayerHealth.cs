using UnityEngine;
public class PlayerHealth : MonoBehaviour
{
    public float health = 100;
    public bool knocked;
    public void TakeDamage(float d){ health -= d; if(health<=0) knocked=true; }
}
