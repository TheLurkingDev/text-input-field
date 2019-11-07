using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UiInputWindow : MonoBehaviour
{
    private Button _okButton;
    private Button _cancelButton;
    private TextMeshProUGUI _titleText;
    private TMP_InputField _inputField;

    private void Awake()
    {
        GetButtonReferences();
        SetClickHandlers();
        SetInputFieldValidation();
        Hide();
    }

    public void Show(string titleText, string inputFieldText)
    {
        this.gameObject.SetActive(true);

        _titleText.text = titleText;
        _inputField.text = inputFieldText;
    }

    public void Hide()
    {
        this.gameObject.SetActive(false);
    }

    private void GetButtonReferences()
    {
        _okButton = transform.Find("OkButton").GetComponent<Button>();
        _cancelButton = transform.Find("CancelButton").GetComponent<Button>();
        _titleText = transform.Find("TitleText").GetComponent<TextMeshProUGUI>();
        _inputField = transform.Find("InputField (TMP)").GetComponent<TMP_InputField>();
    }

    private void SetClickHandlers()
    {
        _cancelButton.onClick.AddListener(HandleCancelButtonClick);
        _okButton.onClick.AddListener(HandleOkButtonClick);                  
    }

    private void SetInputFieldValidation()
    {
        _inputField.onValidateInput = (string text, int charIndex, char characterToAdd) =>
        {
            return ValidateInput(characterToAdd);
        };

        _inputField.characterLimit = 10;
    }

    private void HandleCancelButtonClick()
    {
        this.Hide();
    }

    private void HandleOkButtonClick()
    {        
        Debug.Log("You entered: " + _inputField.text);
        this.Hide();        
    }

    private char ValidateInput(char characterToAdd)
    {
        var validCharacters = "1234567890";
        if (validCharacters.IndexOf(characterToAdd) != -1)
        {
            return characterToAdd;
        }

        return '\0';
    }
    
}
