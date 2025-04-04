using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CanvasController : MonoBehaviour
{
    public CanvasGroup whiteCanvasComponent;
    public Button enterButton;

    private bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        if (enterButton != null)
        {
            enterButton.onClick.AddListener(ToggleWhiteCanvas);
        }

        if (whiteCanvasComponent != null)
        {
            whiteCanvasComponent.alpha = 0f;
            whiteCanvasComponent.interactable = false;
            whiteCanvasComponent.blocksRaycasts = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            ToggleWhiteCanvas();
        }

        if (Input.GetKeyDown(KeyCode.X))
        {
            ToggleWhiteCanvas();
        }
    }

    void ToggleWhiteCanvas()
    {
        if (whiteCanvasComponent != null)
        {
            if (whiteCanvasComponent.alpha == 1)
            {
                whiteCanvasComponent.alpha = 0;
                whiteCanvasComponent.interactable = false;
                whiteCanvasComponent.blocksRaycasts = false;
                ResumeGame();
            }
            else
            {
                whiteCanvasComponent.alpha = 1;
                whiteCanvasComponent.interactable = true;
                whiteCanvasComponent.blocksRaycasts = true;
                PauseGame();
            }
        }
    }

    void PauseGame()
    {
        Time.timeScale = 0;
        isPaused = true;
    }

    void ResumeGame()
    {
        Time.timeScale = 1;
        isPaused = false;
    }
}
