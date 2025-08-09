using UnityEngine;
using UnityEngine.UI;
public class Botonchat : MonoBehaviour
{
    public Button m_YourFirstButton;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_YourFirstButton.onClick.AddListener(TaskOnClick);
    }

    void TaskOnClick()
    {
        //Output this to console when Button1 or Button3 is clicked
        Debug.Log("Click ");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
