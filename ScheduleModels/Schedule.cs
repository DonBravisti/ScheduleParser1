﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScheduleModels
{
    public class Faculty
    {
        public string FacultyName { get; set; }
        public List<Group> Groups { get; set; }
    }

    public class Group
    {
        public string GroupName { get; set; }
        public string GroupId { get; set; }
        public List<Couple> Couples { get; set; }
    }

    public class Couple
    {
        public string SubgroupName { get; set; }
        public string SubgroupId { get; set; }
        public string Week { get; set; }
        public string Day { get; set; }
        public string CoupleNum { get; set; }
        public string TimeBegin { get; set; }
        public string TimeEnd { get; set; }
        public string CoupleName { get; set; }
        public string CoupleTeacher { get; set; }
        public string CoupleAud { get; set; }

        public Couple(Couple some)
        {
            SubgroupName = some.SubgroupName;
            SubgroupId = some.SubgroupId;
            Week = some.Week;
            Day = some.Day;
            CoupleNum = some.CoupleNum;
            TimeBegin = some.TimeBegin;
            TimeEnd = some.TimeEnd;
            CoupleName = some.CoupleName;
            CoupleTeacher = some.CoupleTeacher;
            CoupleAud = some.CoupleAud;
        }

        public Couple()
        {

        }
    }

    public class TeacherCouple
    {
        public string CoupleName { get; set; }
        public string GroupId { get; set; }
        public string SubgroupId { get; set; }
        public string CoupleAud { get; set; }
        public string TimeBegin { get; set; }
        public string TimeEnd { get; set; }
        public string CoupleNum { get; set; }
        public DayOfWeek Day { get; set; }
        public string Week { get; set; }

        public TeacherCouple(Couple couple, string groupId)
        {
            CoupleName = couple.CoupleName;
            GroupId = groupId;
            CoupleAud = couple.CoupleAud;
            TimeBegin = couple.TimeBegin;
            TimeEnd = couple.TimeEnd;
            CoupleNum = couple.CoupleNum;
            Day = FromStringToDayOfWeek(couple.Day);
            Week = couple.Week;
            SubgroupId = couple.SubgroupId;
        }
        public TeacherCouple()
        {
            
        }

        public static DayOfWeek FromStringToDayOfWeek(string day)
        {
            switch (day)
            {
                case "monday":
                    return DayOfWeek.Monday;
                case "tuesday":
                    return DayOfWeek.Tuesday;
                case "wednesday":
                    return DayOfWeek.Wednesday;
                case "thursday":
                    return DayOfWeek.Thursday;
                case "friday":
                    return DayOfWeek.Friday;
                case "saturday":
                    return DayOfWeek.Saturday;
            }
            return DayOfWeek.Sunday;
        } 
    }


    public class ExamFaculty
    {
        public string FacultyName { get; set; }
        public List<ExamGroup> Groups { get; set; }
    }

    public class ExamGroup
    {
        public string GroupName { get; set; }
        public string SpecName { get; set; }
        public string Course { get; set; }
        public List<Couple> Couples { get; set; }
    }

    public enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
