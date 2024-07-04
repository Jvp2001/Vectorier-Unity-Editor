#nullable enable
using System.IO;
using UnityEditor;
public static class VectorierSettings
{

    public const string SettingsPath = "Assets/Settings/VectorierSettings.asset";
    private const string GameExecutableName = "Vector.exe";

    internal const string GameDirectoryKey = "VectorierSettings.GameDirectory";
    internal const string GameExecutablePathKey = "VectorierSettings.GameExecutablePath";

    public static string? GameDirectory
    {
        get => EditorPrefs.GetString(GameDirectoryKey, "");

    }

    public static string? GameExecutablePath
    {
        get => EditorPrefs.GetString(GameExecutablePathKey, "");

    }



    /// <summary>
    /// This generates the game executable path by combining the <see cref="GameDirectory"/> with the <see cref="GameExecutableName"/>
    /// </summary>
    /// <remarks>
    /// <seealso cref="Path.Combine(string,string)"/>
    /// </remarks>
    /// <returns>< The path to the game executable./returns>
    public static string? GenerateGameExecutablePath()
    {
      return Path.Combine(GameDirectory ?? string.Empty, GameExecutableName);
    }









}
