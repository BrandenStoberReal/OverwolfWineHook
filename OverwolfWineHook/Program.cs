using Vestris.ResourceLib;

string mshtmlPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "mshtml.dll");
if (File.Exists(mshtmlPath))
{
    try
    {
        Console.WriteLine("MSHTML found! Path -> " + mshtmlPath);
        VersionResource versionResource = new VersionResource();
        versionResource.LoadFrom(mshtmlPath);
        Console.WriteLine("File version: {0}", versionResource.FileVersion);
        versionResource.FileVersion = "11.0.9600.21762";
        versionResource.SaveTo(mshtmlPath);
        Console.WriteLine("Version change success! MSHTML is now emulating IE 11!");
        Console.WriteLine("Press any key to continue...");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error: {ex.Message}");
        Console.WriteLine("Press any key to exit...");
    }
    Console.ReadLine();
    return;
}
else
{
    Console.WriteLine("MSHTML not found! Is IE even installed?");
    Console.WriteLine("Press any key to exit...");
    Console.ReadLine();
    return;
}