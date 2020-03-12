using System;
using System.Collections.Generic;
using System.Text;

namespace Class3._
{
    public class Student
    {
        
        /// <summary>
        /// 学号
        /// </summary>

        public int _stuNum;
        /// <summary>
        /// 姓名
        /// </summary>
                                                        
        public string _stuName;
        /// <summary>
        /// 性别
        /// </summary>
                                                        	                                         
        public char _stuSex;
        /// <summary>
        /// 年龄
        /// </summary>
                                                        
        public int _stuAge;
       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
                                                       
        public string GetStuInfo()
        {
            string _info = "学号:" + _stuNum + "\t 姓名:" + _stuName + "\t 性别:" + _stuSex + "\t 年龄:" + _stuAge;
            return _info;
        }

    }
}
