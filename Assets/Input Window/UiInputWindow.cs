using UnityEngine;

public class UiInputWindow : MonoBehaviour
{
    private void Awake()
    {
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
}
