using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    [SerializeField] Text questName;

    Button cellButton;

    public string QuestName
    {
        get
        {
            return this.questName.text;
        }
        set
        {
            this.questName.text = value;
        }
    }
}
