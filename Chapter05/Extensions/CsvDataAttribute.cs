using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xunit.Sdk;

namespace Extensions
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
    public class CsvDataAttribute : DataAttribute
    {
        private readonly string filePath;
        private readonly bool hasHeaders;
        public CsvDataAttribute(string filePath, bool hasHeaders)
        {
            this.filePath = filePath;
            this.hasHeaders = hasHeaders;
        }

        public override IEnumerable<object[]> GetData(MethodInfo methodInfo)
        {
            var methodParameters = methodInfo.GetParameters();
            var parameterTypes = methodParameters.Select(x => x.ParameterType).ToArray();
            using (var streamReader = new StreamReader(filePath))
            {
                if(hasHeaders)
                    streamReader.ReadLine();
                string csvLine=string.Empty;
                while ((csvLine = streamReader.ReadLine()) != null)
                {
                    var csvRow = csvLine.Split(',');
                    yield return ConvertCsv((object[])csvRow, parameterTypes);
                }
            }
        }

        private static object[] ConvertCsv(IReadOnlyList<object> csvRow, IReadOnlyList<Type> parameterTypes)
        {
            var convertedObject = new object[parameterTypes.Count];
            //convert object if integer
            for (int i = 0; i < parameterTypes.Count; i++)
                convertedObject[i] = (parameterTypes[i] == typeof(int)) ? Convert.ToInt32(csvRow[i]) : csvRow[i]; 
            return convertedObject;
        }
        
    }
}
