using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    class Program
    {
        public delegate void Delegate(Patient patient);
        static void Main(string[] args)
        {
            Patient patient = new Patient();

            Hospital hospital = new Hospital();

            Delegate delegate1 = hospital.MRT;

            Delegate delegate2 = hospital.KT;

            Delegate delegate3 = hospital.Xray;

            Delegate delegate4 = hospital.LOR;

            Delegate delegate5 = hospital.UZI;

            Delegate delegate6 = hospital.Revmo;

            Delegate alldelegates = delegate1 + delegate5 + delegate3;

            delegate1(patient);

            alldelegates(patient);

            patient.DisplayStatus();

            Console.ReadKey();
        }
    }
}