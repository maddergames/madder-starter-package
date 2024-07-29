
/*
    * Madder class: MadderControllerState
    * This class is used to serialize the data sent to the UpdateMadderControllerState function
    * This class defines the layout of the Madder Controller for the Unity Input System
    * This class should not be altered for the Madder controller
    */
using UnityEngine;


[System.Serializable]
public struct MadderControllerState
{
    public string name;
    public Vector2 joystick;

    public float circle;

    public float triangle;

    public float plus;
}

