using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    internal class DocumentWorker
    {
        string fileName;
        public string FileName
        {
            get => fileName;
            set
            {
                fileName = value;
                fs = new FileStream(value, FileMode.Create);
            }
        }

        protected FileStream fs;

        public virtual void OpenDocument(string fname)
        {
            FileName = fname;
            Console.WriteLine("Документ вiдкритий");
        }
        public virtual void EditDocument(string content)
        {
            Console.WriteLine("Правка документа доступна у версiї Про");
        }
        public virtual void SaveDocument(string extension)
        {
            Console.WriteLine("Збереження документа доступне у версiї Про");
            fs.Close();
        }
    }

    internal class ProDocumentWorker : DocumentWorker
    {
        public override void EditDocument(string content)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(content);
            fs.Write(buffer, 0, buffer.Length);
            Console.WriteLine("Документ вiдредаговано");
        }

        public override void SaveDocument(string extension)
        {
            fs.Close();
            Console.WriteLine("Документ збережено у старому форматi, збереження в iнших форматах доступне у версiї Експерт");
        }
    }

    internal class ExpertDocumentWorker : DocumentWorker
    {
        public override void EditDocument(string content)
        {
            byte[] buffer = Encoding.UTF8.GetBytes(content);
            fs.Write(buffer, 0, buffer.Length);
            Console.WriteLine("Документ вiдредаговано");
        }
        public override void SaveDocument(string extension)
        {
            fs.Close();
            string title = "";
            string[] strs = FileName.Split(new char[] { '.' });
            for (int i = 0; i < strs.Length - 1; i++)
                title += strs[i];
            File.Move(FileName, title + extension);
            Console.WriteLine("Документ збережений в новому форматi");
        }
    }
}
