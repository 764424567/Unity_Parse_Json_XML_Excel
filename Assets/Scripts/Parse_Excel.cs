using UnityEngine;
using System.Collections.Generic;
using Excel;
using System.IO;
using System.Data;

public class Parse_Excel : MonoBehaviour
{
    void Start()
    {
        ParseExcel();
    }

    public void ParseExcel()
    {
        //获取到Json文件的路径
        string filePath = Application.dataPath + "/Resources/test.xlsx";
        FileStream fs = File.Open(filePath, FileMode.Open, FileAccess.Read, FileShare.Read);
        IExcelDataReader iExcelDR = ExcelReaderFactory.CreateOpenXmlReader(fs);
        DataSet ds = iExcelDR.AsDataSet();
        List<TableData> data = new List<TableData>();
        int columns = ds.Tables[0].Columns.Count;   //总列数，Tables[0]为表1
        int rows = ds.Tables[0].Rows.Count;         //总行数
        for (int i = 1; i < rows; i++)
        {
            TableData td = new TableData();
            td.Id = ds.Tables[0].Rows[i][0].ToString();//ds.Tables[0].Rows[i][0]是Object，需强行转换为String型
            td.Name = ds.Tables[0].Rows[i][1].ToString();
            td.Score = ds.Tables[0].Rows[i][2].ToString();
            Debug.Log(td.Id + "  " + td.Name + "   " + td.Score);
            data.Add(td);
        }
    }
}
