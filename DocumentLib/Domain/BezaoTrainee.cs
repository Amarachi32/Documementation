using DocumentLib.Attributes;
using DocumentLib.Enum;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentLib.Domain
{

    [Document("Software Engineering Training")]
    public class BezaoTrainee
    {
        [Document("Student Fullname", "Amara Chukwu")]
        public string Fullname { get; set; }

        public BezaoTrainee(string fullname)
        {
            Fullname = fullname;
        }
        public BezaoTrainee()
        {
            
        }

        [Document("what student sreams", "GodAbeg", "output shit")]
        public string StudentsAction(string fullname)
        {
            return $"{Fullname} screams {Scream.HeyGod}";
        }



        }
    }

