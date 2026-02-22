using UnityEngine;
public class WeaponAttachments : MonoBehaviour
{
    public WeaponBase weapon;
    public void ApplyDamageBoost(){ weapon.damage += 10; }
}
