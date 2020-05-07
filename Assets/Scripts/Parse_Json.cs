using System.IO;
using UnityEngine;

public class Parse_Json : MonoBehaviour
{
    void Start()
    {
        ParseJson();
    }

    public void ParseJson()
    {
        //获取到Json文件的路径
        string filePath = Application.dataPath + "/Resources/test.json";
        //string类型的数据常量
        string readData = "";
        //读取文件
        StreamReader str = File.OpenText(filePath);
        //数据保存
        readData = str.ReadToEnd();
        str.Close();
        //数据解析并把数据保存到m_PersonData1 变量中
        DataClassList dataClass = JsonUtility.FromJson<DataClassList>(readData);
        foreach (var item in dataClass.Data_Class)
        {
            Debug.Log(item.Id);
            Debug.Log(item.Name);
            Debug.Log(item.Score);
        }
    }
}
