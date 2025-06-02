using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
	public string sceneToLoad = "GauntletRunner";


	public void LoadGame ()
	{
		SceneManager.LoadScene(sceneToLoad);
	}
}
