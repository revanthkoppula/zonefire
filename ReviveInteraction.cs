using UnityEngine;
public class ReviveInteraction : MonoBehaviour
{
    public void Revive(PlayerHealth p){ p.knocked=false; p.health=50; }
}
