using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuUi : MonoBehaviour
{
    public static MenuUi Instance;

    

    // Start is called before the first frame update
    public void StartNew()
    {
        SceneManager.LoadScene(0);
    }


}
