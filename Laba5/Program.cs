using Laba5;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Laba5.ClassRoom;

class Program
{
    //private static void Main(string[] args)
    //{
    //    var arr = new Task1[3];
    //    arr[0] = new Task1();
    //    arr[1] = new Task1Green();
    //    arr[2] = new Task1Magenta();

    //    foreach (Task1 r in arr)
    //    {
    //        r.Print("Hello");
    //    }

    //    ((Task1Green)arr[1]).Print("Hello (green)");
    //    ((Task1Magenta)arr[2]).Print("Hello (magenta)");
    //}
    //static void Main(string[] args)
    //{
    //    Pupil Gosha = new BadPupil("Gosha");
    //    Pupil Alex = new BadPupil("Alex");
    //    Pupil Ivan = new GoodPupil("Ivan");
    //    Pupil Vova = new ExcellentPupil("Vova");

    //    var ClassRoom1 = new ClassRoom(Gosha);
    //    var ClassRoom2 = new ClassRoom(Gosha, Alex);
    //    var ClassRomm3 = new ClassRoom(Gosha, Alex, Ivan);
    //    var ClassRomm4 = new ClassRoom(Gosha, Alex, Ivan, Vova);

    //    ClassRomm4.GetPupilsStudy();
    //    ClassRomm4.GetPupilsRead();
    //    ClassRomm4.GetPupilsWrite();
    //    ClassRomm4.GetPupilsRelax();

    //    Console.ReadLine();
    //}

    public static void Main()
    {
        string key = "";
        Console.Write("Уведiть ключ продукту: ");
        key = Console.ReadLine();
        DocumentWorker worker = new DocumentWorker();
        if (key.Equals("pro"))
            worker = new ProDocumentWorker();
        else if (key.Equals("expert"))
            worker = new ExpertDocumentWorker();
        Console.Write("Уведiть iм'я файлу: ");
        worker.OpenDocument(Console.ReadLine());
        Console.Write("Уведiть вмiст файлу: ");
        worker.EditDocument(Console.ReadLine());
        Console.Write("Уведiть розширення файлу: ");
        worker.SaveDocument(Console.ReadLine());    
    }

}
