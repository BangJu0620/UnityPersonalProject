using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC : InteractableObjectManager
{
    public Image dialogueImage;
    public Text dialogueText;
    public Text dialougeLikeGame;
    public Text dialougeDislikeGame;
    public Button likeGameButton;
    public Button dislikeGameButton;
    public Button exitDialogueButton;

    protected override void OnCollisionEnter2D(Collision2D collision)
    {
        if ((levelCollisionLayer.value & (1 << collision.gameObject.layer)) != 0)
        {
            // NPC 상호작용
            //Debug.Log("NPC 상호작용");
            dialogueImage.gameObject.SetActive(true);
            dialogueText.gameObject.SetActive(true);
            dialougeLikeGame.gameObject.SetActive(false);
            dialougeDislikeGame.gameObject.SetActive(false);
            likeGameButton.gameObject.SetActive(true);
            dislikeGameButton.gameObject.SetActive(true);
            exitDialogueButton.gameObject.SetActive(false);
        }
    }

    public void OnClickLikeButton()
    {
        dialogueText.gameObject.SetActive(false);
        likeGameButton.gameObject.SetActive(false);
        dislikeGameButton.gameObject.SetActive(false);
        dialougeLikeGame.gameObject.SetActive(true);
        exitDialogueButton.gameObject .SetActive(true);
    }

    public void OnClickDislikeButton()
    {
        dialogueText.gameObject.SetActive(false);
        likeGameButton.gameObject.SetActive(false);
        dislikeGameButton.gameObject.SetActive(false);
        dialougeDislikeGame.gameObject.SetActive(true);
        exitDialogueButton.gameObject.SetActive(true);
    }

    public void OnClickExitButton()
    {
        dialogueImage.gameObject.SetActive(false);
    }
}
