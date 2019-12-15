using System.IO;
using UnityEditor;

public class Builder
{
    [MenuItem("Test1/Build1")]
    static void Test1Build1()
    {
        CreateIfNotExist("Test1");
        var builds = new AssetBundleBuild[1];
        builds[0] = GetMat();
        BuildPipeline.BuildAssetBundles("Test1", builds, BuildAssetBundleOptions.UncompressedAssetBundle, EditorUserBuildSettings.activeBuildTarget);
    }

    [MenuItem("Test1/Build2")]
    static void Test1Build2()
    {
        BuildAll("Test1");
    }

    [MenuItem("Test2/Build1")]
    static void Test2Build1()
    {
        BuildAll("Test2");
    }

    static void BuildAll(string outputDir)
    {
        CreateIfNotExist(outputDir);
        var builds = new AssetBundleBuild[2];
        builds[0] = GetMat();
        builds[1] = GetCube();
        BuildPipeline.BuildAssetBundles(outputDir, builds, BuildAssetBundleOptions.UncompressedAssetBundle, EditorUserBuildSettings.activeBuildTarget);
    }

    static AssetBundleBuild GetMat()
    {
        var build = new AssetBundleBuild();
        build.assetNames = new[] { "Assets/Game/Red.mat" };
        build.assetBundleName = "Red";
        return build;
    }

    static AssetBundleBuild GetCube()
    {
        var build = new AssetBundleBuild();
        build.assetNames = new[] { "Assets/Game/Cube.prefab" };
        build.assetBundleName = "Cube";
        return build;
    }

    static void CreateIfNotExist(string directory)
    {
        if (!Directory.Exists(directory))
        {
            Directory.CreateDirectory(directory);
        }
    }
}
