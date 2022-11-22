using UnityEngine;

public class QD_ChoiceButton : MonoBehaviour
{
    public int number;
    public DialogueTracker Tracker;

    public void Select() => Tracker.Choose(number);
}
