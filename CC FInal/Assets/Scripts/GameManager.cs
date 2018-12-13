using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour {

    public int TreeInt;

    public TextMeshProUGUI TreeTextUpdate;

	public static GameManager instance;

	

     void Start()
    {


    }

    void Awake ()
	{
		instance = this;
	}

	

    public void TreeCount(int num){

        TreeInt += num;
        TreeTextUpdate.text = "" + TreeInt;

    }

	public void Restart ()
	{
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
	}


    void Update()
    {

        Debug.Log(TreeInt);
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(0))
        {

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("change scene");
                SceneManager.LoadScene(1);
            }
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(1))
        {

            if (TreeInt > 9)
            {
                Debug.Log("change scene");
                SceneManager.LoadScene(2);
            }
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(2))
        {

            if (TreeInt > 9)
            {
                Debug.Log("change scene");
                SceneManager.LoadScene(3);
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("change scene");
                SceneManager.LoadScene(2);
            }
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(3))
        {

            if (TreeInt > 6)
            {
                Debug.Log("change scene");
                SceneManager.LoadScene(4);
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("change scene");
                SceneManager.LoadScene(3);
            }
        }

        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByBuildIndex(4))
        {

            if (TreeInt > 4)
            {
                Debug.Log("change scene");
                SceneManager.LoadScene(0);
            }

            if (Input.GetKeyDown(KeyCode.Return))
            {
                Debug.Log("change scene");
                SceneManager.LoadScene(4);
            }
        }

        //else if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("scene2"))
        //{
        //    SceneManager.LoadScene("scene1");
        //}
    }

}
