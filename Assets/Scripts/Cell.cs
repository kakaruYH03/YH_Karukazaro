using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public interface ICell
{
    void BigCell(Cell cell);
}

public class Cell : MonoBehaviour
{
    [SerializeField] RectTransform content;
    [SerializeField] GameObject dtailView;
    public ICell cellDelegate;
    float cellHeight = 200f;
    
    bool isOn;

    private void Awake()
    {
        dtailView.SetActive(false);
    }

    public void OnClick()
    {
        cellDelegate.BigCell(this);

        if (isOn == false)
        {
            content.sizeDelta = new Vector2(1080, cellHeight * 2);
            dtailView.SetActive(true);
            isOn = true;
            Debug.Log(isOn);
        }

        else
        {
            content.sizeDelta = new Vector2(1080, cellHeight);
            dtailView.SetActive(false);
            isOn = false;
        }
    }

}
