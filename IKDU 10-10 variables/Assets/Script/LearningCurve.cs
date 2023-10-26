using System.Collections.Generic;
using UnityEngine;

public class LearningCurve : MonoBehaviour
{

    public int a = 10;
    public int b = 20;

    private void Start()
    {
        FindPartyMember(1, "Jacob Vigso");
    }
    public void TwoNumbers()
    {
        if (a > b)
        {
            Debug.Log("A is bigger than B");
        }
        else if (a < b)
        {
            Debug.Log("B is bigger than A");
        }
    }

    public void AddTwoNumbers()
    {
        Debug.Log(a + " and " + b + " is: " + (a + b));
    }

    public int NumberSwitch(int a, int b)
    {
        switch (a > b)
        {
            case true:
                return a;
            case false:
                return b;
        }
    }

    public void FindPartyMember(int index, string name)
    {
        List<string> QuestPartyMembers = new List<string>()
        {
        "Grim the Barbarian",
        "Merlin the Wise",
        "Sterling the Knight"
        };
        QuestPartyMembers.Insert(index, name);

        int listLength = QuestPartyMembers.Count;

        Debug.LogFormat("Party Members: {0}", listLength);

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, QuestPartyMembers[i]);

            if (QuestPartyMembers[i] == name)
            {
                Debug.Log("Glad you're here " +  name + "!");
            }
        }
    }
}
