using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    class Hospital
    {
        public Hospital() { }
        public void MRT(Patient patient)
        {
            patient.MRT = true;
        }
        public void KT(Patient patient)
        {
            patient.KT = true;
        }
        public void Xray(Patient patient)
        {
            patient.Xray = true;
        }
        public void LOR(Patient patient)
        {
            patient.LOR = true;
        }
        public void UZI(Patient patient)
        {
            patient.UZI = true;
        }
        public void Revmo(Patient patient)
        {
            patient.Revmo = true;
        }
    }
}