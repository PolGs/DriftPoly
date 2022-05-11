using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttons : MonoBehaviour
{
    public GameObject loadingScreen;
    public Slider loadingBar;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    public void LoadLevel(string levelName)
    {
        SaveMAnager.SavePlayer();
        StartCoroutine(LoadSceneAsync(levelName));

    }

    IEnumerator LoadSceneAsync(string levelName)
    {
        Debug.Log("Loading Map");
        loadingScreen.SetActive(true);
        AsyncOperation op = SceneManager.LoadSceneAsync(levelName);

        while (!op.isDone)
        {
           
            Debug.Log(op.progress);
            float progress = Mathf.Clamp01(op.progress / .9f);
          
            loadingBar.value = progress;

            yield return null;
        }
    }
}
