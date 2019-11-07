using UnityEngine;
using UnityEngine.UI;

public class UiInputWindowTesting : MonoBehaviour
{
    [SerializeField] private UiInputWindow _uiInputWindow;
    private Button _submitButton;

    private void Start()
    {
        _submitButton = GetComponentInChildren<Button>();
        _submitButton.onClick.AddListener(HandleSubmitButtonClick);
    }

    private void HandleSubmitButtonClick()
    {
        _uiInputWindow.Show("This is a test.", "qwerty");
    }
}
