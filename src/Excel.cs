using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using Pick5Grammar.Models;
using System.Text;
using System.Linq;

namespace Pick5Grammar.src
{
    public sealed class Excel
    {
        private readonly string _inFile;
        private int _numOutput;
        private DataTable _fullTable;

        private List<GrammarReference> randomlyPicked = new List<GrammarReference>();

        public Excel(string inFile, int numOutput = 5)
        {
            _inFile = inFile;
            _numOutput = numOutput;
            ReadExcelFile();
            PickRandom();
        }

        private void ReadExcelFile()
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            using (var stream = File.Open(@"Example.xlsx", FileMode.Open, FileAccess.Read))
            {
                using (var reader = ExcelReaderFactory.CreateReader(stream))
	            {
		            ExcelDataSetConfiguration config = new ExcelDataSetConfiguration()
		            {
			            ConfigureDataTable = _ => new ExcelDataTableConfiguration() { UseHeaderRow = true}
		            };

		            DataSet result = reader.AsDataSet(config);
                    _fullTable = result.Tables[0];
	            }
            }
        }

        private void PickRandom()
        {
            int totalAvailable = _fullTable.Rows.Count;
            if(_numOutput > totalAvailable)
            {
                _numOutput = totalAvailable;
            }

            Random rnd = new Random();
            for(int x = 0; x < _numOutput; x++)
            {
                int newRecord = rnd.Next(0, totalAvailable);
                DataRow row = _fullTable.Rows[newRecord];
                randomlyPicked.Add(new GrammarReference() {
                    Concept = row["Grammar"] as String,
                    Proficiency = row["Proficiency Level"] as String,
                    Minna = row["みんな"] as String,
                    DXJG = row["DXJG"] as String,
                    SoMatoMe = row["So-Matome"] as String,
                    Journal = row["Journal"] as String,
                });
            }
        }

        public override string ToString() {
            return String.Join("\n\n", randomlyPicked.Select(x => x.ToString()));
        }
    }
}