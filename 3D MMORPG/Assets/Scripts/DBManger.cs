using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DBManger : MonoBehaviour
{
    public static string username;
    public static int level;

    public static bool LoggedIn { get { return username != null; } }
    
    public static void LogOut()
    {
        username = null;
    }
}
