using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp11
{
    class Patient
    {
        public Patient()
        {
            MRT = false;
            KT = false;
            Xray = false;
            LOR = false;
            UZI = false;
            Revmo = false;
        }
        public bool MRT { get; set; }
        public bool KT { get; set; }
        public bool Xray { get; set; }
        public bool LOR { get; set; }
        public bool UZI { get; set; }
        public bool Revmo { get; set; }
        public void DisplayStatus()
        {
            Console.WriteLine("Статус пациента:");
            Console.WriteLine($"MRT = { MRT}\nKT = {KT}\nXray = {Xray}\nLOR = {LOR}\nUZI = {UZI}\nRevmo = {Revmo}\n");
        }
    }
}