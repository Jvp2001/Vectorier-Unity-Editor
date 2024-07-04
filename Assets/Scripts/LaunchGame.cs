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


            string gameProcessPath = null;



                var gamePath = VectorierSettings.GenerateGameExecutablePath();
                if (string.IsNullOrEmpty(gamePath))
                {
                    Debug.LogWarning("Game executable path is empty; defaulting to the \"steam://rungameid/248970\" path");
                    Debug.LogWarning("Please sett at least the GameDirectory in the Vectorier settings");
                    gameProcessPath = SteamRunGamePath;
                }
                else
                {
                    gameProcessPath = gamePath;
                }


            var gameProcess = new Process();
            gameProcess.StartInfo.FileName = gameProcessPath;
            gameProcess.Start();

            gameProcess.WaitForExit();


        }
    }
}
