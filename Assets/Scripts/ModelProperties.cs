using UnityEngine;
[AddComponentMenu("Vectorier/Model Properties")]
public class ModelProperties : MonoBehaviour
{
    [Range(0, 1)] public int Type;
    public bool UseLifeTime;
    public string LifeTime = "0";
}