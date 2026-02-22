using UnityEngine;
public class MobileAimController : MonoBehaviour
{
    Gyroscope gyro;
    public float sensitivity = 2f;
    void Start(){ gyro = Input.gyro; gyro.enabled = true; }
    void Update(){ transform.Rotate(-gyro.rotationRateUnbiased.y*sensitivity,0,0); }
}
