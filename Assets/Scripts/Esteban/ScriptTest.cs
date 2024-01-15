using UnityEngine;
using UnityEngine.UIElements;

public class ScriptTest : MonoBehaviour
{
    UIDocument UI;
    Button Button1;
    Button Button2;
    Button Button3;

    // Test
    public void Start()
    {
        UI = GetComponent<UIDocument>();
        VisualElement root = UI.rootVisualElement;
        Button1 = root.Q<Button>("Button1");
        Button2 = root.Q<Button>("Button2");
        Button3 = root.Q<Button>("Button3");
        Button1.RegisterCallback<ClickEvent>(PlaySound);
        Button2.RegisterCallback<ClickEvent>(PlaySound);
        Button3.RegisterCallback<ClickEvent>(PlaySound);
    }

    private void PlaySound(ClickEvent evt)
    {
        Debug.Log("Hiciste click en un boton!");
    }


}
