using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface ICell
{
    void CellOpen(Cell cell);
}

public class Cell : MonoBehaviour
{
    [SerializeField] RectTransform content;
    [SerializeField] Text questName;
    float cellHeight = 200f;
    public ICell cellDelegate;
    bool isOn;

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

    public void OnClick()
    {

        if (isOn == false)
        {
            content.sizeDelta = new Vector2(1080, cellHeight * 2);
            isOn = true;
            Debug.Log(isOn);
        }

        else
        {
            content.sizeDelta = new Vector2(1080, cellHeight);
            isOn = false;
        }
    }

}
