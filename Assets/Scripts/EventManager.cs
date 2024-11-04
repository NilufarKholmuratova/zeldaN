using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventManager : MonoBehaviour
{
    public delegate void InteractionAction();
    public static event InteractionAction OnLeverActivated;
    public static event InteractionAction OnChestOpened;

    public static void LeverActivated()
    {
        if (OnLeverActivated != null)
        {
            OnLeverActivated();
        }
    }

    public static void ChestOpened()
    {
        if (OnChestOpened != null)
        {
            OnChestOpened();
        }
    }
}
