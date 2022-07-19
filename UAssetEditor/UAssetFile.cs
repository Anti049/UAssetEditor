using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UAssetEditor
{
    internal class UAssetFile
    {
        private string _fileName;
        private string _filePath;
        private string _fileExtension;

        public string FileName
        {
            get { return _fileName; }
            set { _fileName = value; }
        }
        public string FilePath
        {
            get { return _filePath; }
            set { _filePath = value; }
        }
        public string FileExtension
        {
            get { return _fileExtension; }
            set { _fileExtension = value; }
        }

        public UAssetFile(string fileName, string filePath, string fileExtension)
        {
            _fileName = fileName;
            _filePath = filePath;
            _fileExtension = fileExtension;
        }
        
    }
}
