using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace TestService
{
    [ServiceContract]
    internal interface IMyService
    {
        [OperationContract]
        string getData();

        [OperationContract]
        string greet(string name);

        [OperationContract]
        int[] sortArray(int[] ar);

        [OperationContract]
        int totalMarks(Student s);
    }

    [DataContract]
    class Student
    {
        [DataMember]
        public int marks1;
        [DataMember]
        public int marks2;
    }
}
