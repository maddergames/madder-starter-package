
using UnityEngine;


/**
 * Madder class: MadderController
 * This class is used to define the Madder Controller
 * This class should not be altered.
 */


public class MadderController
{
    // Define controls

    public Vector2Control joystick { get; private set; }

    public ButtonControl triangleButton { get; private set; }

    public ButtonControl circleButton { get; private set; }

    public ButtonControl plusButton { get; private set; }

    protected override void FinishSetup()
    {
        //TODO: Add Rewired support
    }

    public static MadderController current { get; private set; }

    protected override void OnAdded()
    {
        if (current == null)
            current = this;
    }

    protected override void OnRemoved()
    {
        if (current == this)
            current = null;
    }
}
