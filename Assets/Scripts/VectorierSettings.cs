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



    public static string? GenerateGameExecutablePath()
    {
        string? result = GameExecutablePath;
        result ??= Path.Combine(GameDirectory ?? string.Empty, GameExecutableName);
        return result == GameExecutableName ? null : result;
    }









}
