using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace Pick5Grammar.src
{
    public sealed class Excel
    {
        private readonly string _inFile;
        private readonly int _numOutput;
        private DataTable _fullTable;

        private List<Tuple<string, string>> randomlyPicked = new List<Tuple<string, string>>();

        public Excel(string inFile, int numOutput = 5)
        {
            _inFile = inFile;
            _numOutput = numOutput;
            ReadExcelFile();
            PickRandom();
        }

        private void ReadExcelFile()
        {
            using (var stream = File.Open(@"\\tsclient\Desktop\Example.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
	            {
		            ExcelDataSetConfiguration cofig = new ExcelDataSetConfiguration()
		            {
			            ConfigureDataTable = _ => new ExcelDataTableConfiguration() { UseHeaderRow = true}
		            };

		            DataSet result = reader.AsDataSet(cofig);
                    _fullTable = result.Tables[0];
	            }
            }
        }

        private void PickRandom()
        {
            
        }

        public override string ToString() {
            return "foo, for now";
        }
    }
}