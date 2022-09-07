using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;

// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class Web : MonoBehaviour
{
    void Start()
    {
        //StartCoroutine(Login("haeun","pw1234"));
        //StartCoroutine(RegisterUser("haeun1", "pw1234"));
    }
    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPassword", password);
        using (UnityWebRequest www = UnityWebRequest.Post("http://3.39.178.56/PhpFiles/Login.php", form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                //MainScript.Instance.UserInfo.SetInfo(username, password);
                //MainScript.Instance.UserInfo.SetUsername(username);
                //MainScript.Instance.UserInfo.SetUsername(www.downloadHandler.text);
                //MainScript.Instance.UserInfo.SetPassword(password);
                if (www.downloadHandler.text.Contains("wrong password") || www.downloadHandler.text.Contains("Username does not exist."))
                {
                    Debug.Log("Try Again");
                    //errorpopup.SetActive(true);
                    Invoke("popupDeactivate", 2f);
                }
                //If we logged in correctly
                else
                {
                    Debug.Log("logged in correctly");
                    SceneManager.LoadScene("MainPage");
                    //realusername = username;
                    //MainScript.Instance.UserProfile.SetActive(true);
                    //MainScript.Instance.Login.gameObject.SetActive(false);
                }
            }
        }
    }
    public IEnumerator RegisterUser(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPassword", password);

        using (UnityWebRequest www = UnityWebRequest.Post("http://3.39.178.56/PhpFiles/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                if (www.downloadHandler.text.Contains("Username is already taken."))
                {
                    Debug.Log("Try Again");
                    //signuperrorpopup.SetActive(true);
                    //Invoke("signuperrorDeactivate", 2f);
                }
                //If we logged in correctly
                else
                {
                    if (www.downloadHandler.text.Contains("New record created successfully"))
                        SceneManager.LoadScene("LoginPage");
                    else Debug.Log("Try Again");
                }
            }
        }
    }
}

