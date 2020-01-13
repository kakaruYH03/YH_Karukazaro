using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    [SerializeField] RectTransform content;
    [SerializeField] GameObject dtailView;
    [SerializeField] Text questText;
    [SerializeField] Text explantion;
    [SerializeField] Text comPensation;
    

    float cellHeight = 200f;
    Animator animator;

    bool isOn;

    private void Start()
    {
        dtailView.SetActive(false);
    }

    public void OnClick()
    {

        if (isOn == false)
        {
            content.sizeDelta = new Vector2(1080, cellHeight * 2);
            Open();
            isOn = true;
        }

        else
        {
            content.sizeDelta = new Vector2(1080, cellHeight);
            Close();
            isOn = false;
        }

    }
   
    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // 애니메이션
    public void Open()
    {
        animator.SetTrigger(Constant.kViewManagerOpen);
    }

    public void Close()
    {
        animator.SetTrigger(Constant.kViewManagerClose);
    }

    // 애니메이션 종료후 동작
    public void OpenText()
    {
        dtailView.SetActive(true);
    }

    public void CloseText()
    {
        dtailView.SetActive(false);
    }

    public void SetcellData(Person cellData)
    {
        this.questText.text = cellData.questName;
        this.explantion.text = cellData.quest;
        this.comPensation.text = cellData.Compensation;
    }
}