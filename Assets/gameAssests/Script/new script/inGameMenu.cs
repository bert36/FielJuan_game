using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inGameMenu : MonoBehaviour
{
    
    public Transform box;
    public CanvasGroup bg_;

    public GameObject Menu;
    public static bool isMenuActive;
 
    void Awake()
    {
       Menu.SetActive(false);
        isMenuActive = false;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Escape)&& isMenuActive == false)
        {
             openMenu();
          
        }

    }



    private void OnEnable ()
    {
        bg_.alpha = 0;
        bg_.LeanAlpha(1, 0.5f);

        box.localPosition = new Vector2(0, -1f);
        box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;

    }

    public void closeMenu()
    {
        bg_.LeanAlpha(0, 0.5f);
        box.LeanMoveLocalY(-Screen.height, 0.5f).setEaseOutExpo();
        isMenuActive = false;
        
    }




    private void openMenu()
    {
        bg_.alpha = 0;
        bg_.LeanAlpha(1, 0.5f);

        box.localPosition = new Vector2(0, -1f);
        box.LeanMoveLocalY(0, 0.5f).setEaseOutExpo().delay = 0.1f;

        Menu.SetActive(true);
        isMenuActive = true;
     
    }


    public void quitgame()
    {
        Application.Quit();
        Debug.Log("quited");

    }
}
