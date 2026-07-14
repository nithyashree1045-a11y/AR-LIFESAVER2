using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public void StartApp()
	{
		SceneManager.LoadScene("ARScene");
	}

	public void AboutApp()
	{
		Debug.Log("AR Lifesaver - Interactive First Aid Training");
	}

	public void ExitApp()
	{
		Application.Quit();

		Debug.Log("Application Closed");
	}
}