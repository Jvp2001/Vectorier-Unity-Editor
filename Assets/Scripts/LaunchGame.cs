using System.ComponentModel;
using System.Diagnostics;
using UnityEditor;
using UnityEngine;
using Debug = UnityEngine.Debug;
namespace DefaultNamespace
{
    public class LaunchGame : MonoBehaviour
    {
        private const string SteamRunGamePath = "steam://rungameid/248970";
        [MenuItem("Vectorier/Run Game %#&R")]
        public static void Run()
        {


            string gameProcessPath = "";



                var gamePath = VectorierSettings.GameDirectory;
                var gameExecutablePath = VectorierSettings.GameExecutablePath;
                if (string.IsNullOrEmpty(gamePath) && string.IsNullOrEmpty(gameExecutablePath))
                {
                    Debug.LogWarning("Game executable path is empty; defaulting to the \"steam://rungameid/248970\" path");
                    Debug.LogWarning("Please sett at least the GameDirectory in the Vectorier settings");
                    gameProcessPath = SteamRunGamePath;
                }
                else
                {
                    if(!string.IsNullOrEmpty(gamePath) && string.IsNullOrEmpty(gameExecutablePath))
                    {
                        gameProcessPath = VectorierSettings.GenerateGameExecutablePath();
                    }
                    else
                    {
                        gameProcessPath = gameExecutablePath;
                    }

                }


                try
                {
                    var gameProcess = new Process();
                    gameProcess.StartInfo.FileName = gameProcessPath;
                    gameProcess.Start();

                    gameProcess.WaitForExit();
                }
                catch (Win32Exception) // This exception is thrown when the game executable is not found.
                {
                    Debug.LogError($"Cannot find game executable at path: {gamePath}!");
                }

        }
    }
}
