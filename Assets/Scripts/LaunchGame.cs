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






        static LaunchGame()
        {
            BuildMap.MapBuilt += OnMapBuilt;
        }
        private static void OnMapBuilt()
        {

            var gameExecutablePath = VectorierSettings.GameExecutablePath ?? SteamRunGamePath;

            try
            {
                var gameProcess = new Process();
                gameProcess.StartInfo.FileName = gameExecutablePath;
                gameProcess.Start();

                gameProcess.WaitForExit();
            }
            catch (Win32Exception) // This exception is thrown when the game executable is not found.
            {
                Debug.LogError($"Cannot find game executable at path: {VectorierSettings.GameDirectory}!");
            }
        }



        [MenuItem("Vectorier/Build and Run Game %#&R")]
        public static void BuildAndRun()
        {
            BuildMap.Build();



        }
    }
}
