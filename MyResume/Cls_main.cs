using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MyResume
{
    public class Cls_main
    {
        #region SQL Server Name
        public static string SQL_Server_Name = "";
        public static string DB_Name = "";
        public static string SQL_Server_User_Name = "";
        public static string SQL_Server_Password = "";
        #endregion


        #region Personal Details
        public static string Name = "Nilesh Ahire";
        public static string Age = "22";
        public static string DOB = "30 Jul 2001";
        public static string Mail_1 = "Niluahirepatil@gmail.com";
        public static string Mail_2 = "Workniluahirepatil@gmail.com";
        public static string Phone_1 = "+91 909697 7063";
        public static string Phone_2 = "+91 909697 4233";
        public static string Address = "Baglan(Nashik) MH,IN 423204";
        public static string Current_City = "Pune";
        public static string City = "Nashik";
        public static string Education = "Master Of Science ( Computer Science )";
        #endregion

        #region All Social Links
        public static string Email = "mailto:niluahirepatil@gmail.com";
        public static string Site = "www.niluahirepatil.bsite.net";
        public static string LinkedIn = "https://www.linkedin.com/in/niluahirepatil";
        public static string GitHub = "https://github.com/Nilu-Ahire-Patil";
        public static string Rresume = "https://drive.google.com/open?id=1s-lUU50kEVjMU0_c5ju1Qu9XuW0xb53g&usp=drive_fs";

        public static string Phone = "+919096974233";
        public static string Map = "";
        public static string Facebook = "m.facebook.com/Niluahirepatil";
        public static string Teligram = "https://t.me/Nilu_ahire_patil_96k";
        public static string Whatapp = "https://wa.me/+919096977063";
        public static string Instagram = "https://www.instagram.com/nilu_ahire_patil_96k";
        #endregion


        #region Education
        #region Master
        public static string Degree_1 = "Master Of Science ( Computer Science )";
        public static string Year_1 = "2022 - 2024";
        public static string Univercity_1 = "Savitribai Phule Pune University, Pune";
        public static string Descrepction_1 = "Currently pursuing Master's degree";
        #endregion 

        #region Master
        public static string Degree_2 = "Bachelor of Computer Science";
        public static string Year_2 = "2019 - 2022";
        public static string Univercity_2 = "Mahatma Gandhi Vidyamandir's Maharaja Sayajirao Gaikwad Arts Science and Commerce College, Malegaon";
        public static string Descrepction_2 = "I have done my graduation through this college and got 8.0 CGPA marks in this course";
        #endregion 

        #region Master
        public static string Degree_3 = "Higher Secondary School";
        public static string Year_3 = "2017 - 2019";
        public static string Univercity_3 = "Mahatma Gandhi Vidyamandir's Maharaja Sayajirao Gaikwad Arts Science and Commerce College, Nampur";
        public static string Descrepction_3 = "";
        #endregion

        #region Master
        public static string Degree_4 = "Secondary School";
        public static string Year_4 = "2015 - 2017";
        public static string Univercity_4 = "Nampur English School, Nampur";
        public static string Descrepction_4 = "";
        #endregion
        #endregion



    }
}