using UnityEngine;
[AddComponentMenu("Vectorier/Dynamic Trigger")]
public class DynamicTrigger : MonoBehaviour
{
    public string TriggerName = "";
    [Tooltip("Which transformation to trigger")] public string TriggerTransformName = "Transform_Name";
    [Tooltip("Which AI is allowed to trigger")] public float AIAllowed = -1f;
    public bool PlaySound;
    public string Sound = "";
}
