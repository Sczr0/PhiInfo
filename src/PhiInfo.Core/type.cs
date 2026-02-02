#pragma warning disable IDE1006

namespace PhiInfo.Core;

public struct SongLevel
{
    public string charter { get; set; }
    public int all_combo_num { get; set; }
    public double difficulty { get; set; }
}

public struct SongInfo
{
    public string id { get; set; }
    public string name { get; set; }
    public string composer { get; set; }
    public string illustrator { get; set; }
    public double preview_time { get; set; }
    public double preview_end_time { get; set; }
    public Dictionary<string, SongLevel> levels { get; set; }
}

public struct Folder
{
    public string title { get; set; }
    public string sub_title { get; set; }
    public string cover { get; set; }
    public List<FileItem> files { get; set; }
}
public struct FileItem
{
    public string key { get; set; }
    public int sub_index { get; set; }
    public string name { get; set; }
    public string date { get; set; }
    public string supervisor { get; set; }
    public string category { get; set; }
    public string content { get; set; }
    public string properties { get; set; }
}

public struct Avatar
{
    public string name { get; set; }
    public string addressable_key { get; set; }
}