using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;
using UnityEngine;

public class Parse_Xml : MonoBehaviour
{
    void Start()
    {
        ParseXML();
    }

    public void ParseXML()
    {
        //获取到XML文件的路径
        string filePath = Application.dataPath + "/Resources/test.xml";
        if (File.Exists(filePath))
        {
            //创建一个数据类集合
            List<Data_Class> dataList = new List<Data_Class>();
            //创建一个XML文件解析对象
            XmlDocument xmlDoc = new XmlDocument();
            //加载XML
            xmlDoc.Load(filePath);
            //获取根节点
            XmlNode rootNode = xmlDoc.FirstChild;
            //获取根节点下面所有的子节点
            XmlNodeList nodeList = rootNode.ChildNodes;
            //遍历节点
            foreach (XmlElement item in nodeList)
            {
                Data_Class dataClass = new Data_Class();
                dataClass.Id = item.ChildNodes.Item(0).InnerText;
                dataClass.Name = item.ChildNodes.Item(1).InnerText;
                dataClass.Score = item.ChildNodes.Item(2).InnerText;
                dataList.Add(dataClass);
            }
            //打印数据
            foreach (Data_Class item in dataList)
            {
                Debug.Log(item.Id);
                Debug.Log(item.Name);
                Debug.Log(item.Score);
            }
        }
    }
}
