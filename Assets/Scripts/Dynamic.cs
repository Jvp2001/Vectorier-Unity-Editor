using System;
using UnityEngine;
[AddComponentMenu("Vectorier/Dynamic")]
public class Dynamic : MonoBehaviour
{
    public string TransformationName = "Transform_name";

    [Serializable]
    public class UseCheck
    {
        public bool UseMovement1 = true;
        public bool UseMovement2;
        public bool UseMovement3;
        public bool UseMovement4;
        public bool UseMovement5;
    }
    

    [Serializable]
    public class Movement1
    {
        [Tooltip("Move Duration in Second")] public float MoveDuration = 1.5f;
        [Tooltip("Move Delay in Second")] public float Delay;
        [Tooltip("Value should be half of the amount of Move X")] public float SupportXAxis;
        [Tooltip("Value should be half of the amount of Move Y")] public float SupportYAxis;
        [Tooltip("How much to move on X Axis")] public float MoveXAxis;
        [Tooltip("How much to move on Y Axis")] public float MoveYAxis;
    }

    [Serializable]
    public class Movement2
    {
        [Tooltip("Move Duration in Second")] public float MoveDuration = 1.5f;
        [Tooltip("Move Delay in Second")] public float Delay;
        [Tooltip("Value should be half of the amount of Move X")] public float SupportXAxis;
        [Tooltip("Value should be half of the amount of Move Y")] public float SupportYAxis;
        [Tooltip("How much to move on X Axis")] public float MoveXAxis;
        [Tooltip("How much to move on Y Axis")] public float MoveYAxis;
    }


    [Serializable]
    public class Movement3
    {
        [Tooltip("Move Duration in Second")] public float MoveDuration = 1.5f;
        [Tooltip("Move Delay in Second")] public float Delay;
        [Tooltip("Value should be half of the amount of Move X")] public float SupportXAxis;
        [Tooltip("Value should be half of the amount of Move Y")] public float SupportYAxis;
        [Tooltip("How much to move on X Axis")] public float MoveXAxis;
        [Tooltip("How much to move on Y Axis")] public float MoveYAxis;
    }

    [Serializable]
    public class Movement4
    {
        [Tooltip("Move Duration in Second")] public float MoveDuration = 1.5f;
        [Tooltip("Move Delay in Second")] public float Delay;
        [Tooltip("Value should be half of the amount of Move X")] public float SupportXAxis;
        [Tooltip("Value should be half of the amount of Move Y")] public float SupportYAxis;
        [Tooltip("How much to move on X Axis")] public float MoveXAxis;
        [Tooltip("How much to move on Y Axis")] public float MoveYAxis;
    }

    [Serializable]
    public class Movement5
    {
        [Tooltip("Move Duration in Second")] public float MoveDuration = 1.5f;
        [Tooltip("Move Delay in Second")] public float Delay;
        [Tooltip("Value should be half of the amount of Move X")] public float SupportXAxis;
        [Tooltip("Value should be half of the amount of Move Y")] public float SupportYAxis;
        [Tooltip("How much to move on X Axis")] public float MoveXAxis;
        [Tooltip("How much to move on Y Axis")] public float MoveYAxis;
    }

    [SerializeField] public UseCheck MovementUsage;
    [SerializeField] public Movement1 MoveInterval1;
    [SerializeField] public Movement2 MoveInterval2;
    [SerializeField] public Movement3 MoveInterval3;
    [SerializeField] public Movement4 MoveInterval4;
    [SerializeField] public Movement5 MoveInterval5;
}
