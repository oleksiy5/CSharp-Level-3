using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Level_3.Subjects.Disposable
{
    class ExerciseDisposable
    {
        public void Test()
        {
            var fr = new FileReader();
            fr.Read();
            var fd = new FileDelete();
            fd.Delete();
        }
    }

    class FileReader : IDisposable
    {
        const string _path = @"C:\my_file\olo.txt";
        FileStream _stream;
        public void Read()
        {
            _stream = new FileStream(_path, FileMode.Open, FileAccess.Read);
            byte[] data = new byte[_stream.Length];
            _stream.Read(data, 0, (int)_stream.Length);
        }
        public void Dispose()
        {
            if (_stream != null)
                _stream.Dispose();
        }

    }

    class FileDelete
    {
        const string _path = @"C:\my_file\olo.txt";
        public void Delete()
        {
            File.Delete(_path);
        }
    }
}
