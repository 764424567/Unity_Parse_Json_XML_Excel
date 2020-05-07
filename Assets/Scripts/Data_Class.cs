[System.Serializable]
public class Data_Class 
{
    public string Id;
    public string Name;
    public string Score; 
}
[System.Serializable]
public class DataClassList
{
    public Data_Class[] Data_Class;
}

public struct TableData
{
    public string Id;
    public string Name;
    public string Score;
}