// Source : https://www.gbif.org/ 
namespace Exam_BearsData;

class Program
{
    static void Main(string[] args)
    {
        string fileDatasName = "Bear_Datas.csv";
        string pathFileDatas = AppDomain.CurrentDomain.BaseDirectory + "../../../datas/" + fileDatasName;
        StreamReader streamReader = new StreamReader(pathFileDatas);
        string year = "";
        string gbifID = "";
        string line = "";
        string[] values;

        string fileResultName = "Bear_Result.csv";
        string pathFileResult = AppDomain.CurrentDomain.BaseDirectory + "../../../datas/" + fileResultName;
        StreamWriter streamWriter = new StreamWriter(pathFileResult);
        streamWriter.Write("YEAR;GBIFID;\n");
        while (!streamReader.EndOfStream)
        {
            line = streamReader.ReadLine();
            values = line.Split(';');
            if (values[35] == "HUMAN_OBSERVATION")
            {
                year = values[32];
                gbifID = values[0];
                string result = year + ";" + gbifID + ";\n";
                streamWriter.Write(result);
            }
        }
        streamReader.Close();
        streamWriter.Close();
    }
}

