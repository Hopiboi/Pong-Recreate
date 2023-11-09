using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeMenuController : MonoBehaviour
{

    [SerializeField] int maxPages;
    [SerializeField] int currentPage;
    Vector3 targetPos;
    [SerializeField] Vector3 pageStep;
    [SerializeField] RectTransform levelPagesRect;

    [SerializeField] float tweenTime;
    [SerializeField] LeanTweenType tweenType;

    [SerializeField] Button prevButton, nextButton;

    private void Awake()
    {
        currentPage = 1;
        targetPos = levelPagesRect.localPosition;

        updateArrowButton();
    }

    //Next page
    public void NextPage()
    {
        //Incrementing
        if (currentPage < maxPages)
        {
            currentPage++;
            targetPos += pageStep;
            MovePage();
        }
    }

    public void PrevPage()
    {
        //Decrementing
        if (currentPage > 1)
        {
            currentPage--;
            targetPos -= pageStep;
            MovePage();
        }

    }

    //Changing Position of image
    public void MovePage()
    {
        levelPagesRect.LeanMoveLocal(targetPos, tweenTime).setEase(tweenType);
        updateArrowButton();
    }

    //whether to disable or enable the next and prev button
    public void updateArrowButton()
    {
        nextButton.interactable = true;
        prevButton.interactable = true;

        if (currentPage == 1)
        {
            prevButton.interactable = false;
        }

        else if (currentPage == maxPages)
        {
            nextButton.interactable = false;
        }

    }

}
