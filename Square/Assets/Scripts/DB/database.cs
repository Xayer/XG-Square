using UnityEngine;
using System.Collections;

public class database : MonoBehaviour 
{
    public static string user = "", email = "";
    private string password = "", rePass = "", message = "";

    private bool register = false;

    private void OnGUI()
    {
        if (message != "")
            GUILayout.Box(message);

        if (register)
        {
            GUILayout.Label("Username");
            user = GUILayout.TextField(user);
            GUILayout.Label("E-mail");
            email = GUILayout.TextField(email);
            GUILayout.Label("password");
            password = GUILayout.PasswordField(password, "*"[0]);
            GUILayout.Label("Re-password");
            rePass = GUILayout.PasswordField(rePass, "*"[0]);

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Back"))
                register = false;

            if (GUILayout.Button("Register"))
            {
                message = "";

                if (user == "" || email == "" || password == "")
                    message += "Please enter all the fields \n";
                else
                {
                    if (password == rePass)
                    {
                        WWWForm form = new WWWForm();
                        form.AddField("user", user);
                        form.AddField("email", email);
                        form.AddField("password", password);
                        WWW w = new WWW("http://www.xayergames.com/test_shit/register.php", form);
                        StartCoroutine(registerFunc(w));
                    }
                    else
                        message += "Your Password does not match \n";
                }
            }

            GUILayout.EndHorizontal();
        }
        else
        {
            GUILayout.Label("User:");
            user = GUILayout.TextField(user);
            GUILayout.Label("Password:");
            password = GUILayout.PasswordField(password, "*"[0]);

            GUILayout.BeginHorizontal();

            if (GUILayout.Button("Login"))
            {
                message = "";

                if (user == "" || password == "")
                    message += "Please enter all the fields \n";
                else
                {
                    WWWForm form = new WWWForm();
                    form.AddField("user", user);
                    form.AddField("password", password);
                    WWW w = new WWW("http://www.xayergames.com/test_shit/login.php", form);
                    StartCoroutine(login(w));
                }
            }

            if (GUILayout.Button("Register"))
                register = true;

            GUILayout.EndHorizontal();
        }
    }

    IEnumerator login(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            if (w.text == "login-SUCCESS")
            {
                print("WOOOOOOOOOOOOOOO!");
            }
            else
                message += w.text;
        }
        else
        {
            message += "ERROR: " + w.error + "\n";
        }
    }

    IEnumerator registerFunc(WWW w)
    {
        yield return w;
        if (w.error == null)
        {
            message += w.text;
        }
        else
        {
            message += "ERROR: " + w.error + "\n";
        }
    }
}
