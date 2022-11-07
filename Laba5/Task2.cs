using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{

    public class ClassRoom
    {
        public readonly List<Pupil> Pupils = new List<Pupil>();

        public ClassRoom(params Pupil[] pupils)
        {
            Pupils.AddRange(pupils);
        }

    public void GetPupilsStudy()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Study();
            }
        }

        public void GetPupilsRead()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Read();
            }
        }

        public void GetPupilsWrite()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Write();
            }
        }

        public void GetPupilsRelax()
        {
            foreach (var pupil in Pupils)
            {
                pupil.Relax();
            }
        }
        public class Pupil
        {
            public string PupilName { get; private set; }

            public Pupil(string name)
            {
                PupilName = name;
            }

            private string GetPupilNameAndStatus()
            {
                return String.Format("{0} {1}", GetType().Name, PupilName);
            }
            public virtual void Study()
            {
                Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Вмiє вчитися");
            }

            public virtual void Read()
            {
                Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Вмiє читати");
            }

            public virtual void Write()
            {
                Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Вмiє писати");
            }

            public virtual void Relax()
            {
                Console.WriteLine("{0} {1}", GetPupilNameAndStatus(), "Вмiє вiдпочивати");
            }
        }

        public class ExcellentPupil : Pupil
        {
            public ExcellentPupil(string name)
                : base(name)
            { }            
        }

        public class GoodPupil : Pupil
        {
            public GoodPupil(string name)
                : base(name)
            { }
        }

        public class BadPupil : Pupil
        {
            public BadPupil(string name)
                : base(name)
            { }
        }


    }
}

    
