using UnityEngine;
using UnityEngine.UI;

public class UiInputWindow : MonoBehaviour
{
    private Button _okButton;
    private Button _cancelButton;

    private void Awake()
    {
        GetButtonReferences();
        SetButtonClickHandlers();
        Hide();
    }

    public void Show()
    {
        this.gameObject.SetActive(true);
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    private void GetButtonReferences()
    {
        var buttons = GetComponentsInChildren<Button>();
        foreach (Button button in buttons)
        {
            if (button.name.Contains("Cancel"))
            {
                _cancelButton = button;
            }

            if (button.name.Contains("Ok"))
            {
                _okButton = button;
            }
        }
    }

    private void SetButtonClickHandlers()
    {
        _cancelButton.onClick.AddListener(HandleCancelButtonClick);
        _okButton.onClick.AddListener(HandleOkButtonClick);
    }

    private void HandleCancelButtonClick()
    {
        Debug.Log("Cancel clicked!");
    }

    private void HandleOkButtonClick()
    {
        Debug.Log("Ok clicked!");
    }
}
