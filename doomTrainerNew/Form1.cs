using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Globalization;
using System.Threading;
using Gma.System.MouseKeyHook;


namespace doomTrainerNew
{
    public partial class Form1 : Form
    {

        Gma.System.MouseKeyHook.Hook

        #region Global variables
        Memory myMemory = new Memory();
        Process[] myProcess;
        bool isGameAvailable = false;

        bool unlimitedAmmo = false;
        string AmmoPointer = "004CF1F0";
        int[] AmmoOffset = {0x28};
        int AmmoToFill = 6;

        bool unlimitedHealth = false;
        string HealthPointer = "004CF1E6"; //address is static may need to use just memory read not ptrRead/Write
        int[] HealthOffset = { 0x0 };
        int HealthToSet = 10;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timerUpdate.Start();
        }

        private void btnAmmo_Click(object sender, EventArgs e)
        {
            if (isGameAvailable)
            {
                if (!unlimitedAmmo)
                {
                    unlimitedAmmo = true;
                    lblAmmoStatus.Text = "Ammo: On";
                }
                else if (unlimitedAmmo)
                {
                    unlimitedAmmo = false;
                    lblAmmoStatus.Text = "Ammo: Off";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            myProcess = Process.GetProcessesByName("VirtualCop2");
            if(myProcess.Length == 1)
            {
                isGameAvailable = true;
                if(lblGameStatus.Text != "Process found!")
                {
                    lblGameStatus.Text = "Process found!";
                }
                if (unlimitedAmmo)
                {
                    myMemory.ReadProcess = myProcess[0];
                    myMemory.Open();
                    int pointerAddy = HexToDec(AmmoPointer);
                    int[] pointerOffset = AmmoOffset;
                    int bytesWritten;
                    byte[] valueToWrite = BitConverter.GetBytes(AmmoToFill);
                    string writtenAddress = myMemory.PointerWrite((IntPtr)pointerAddy, valueToWrite, pointerOffset, out bytesWritten);
                    myMemory.CloseHandle();
                }
                if (unlimitedHealth)
                {
                    
                    myMemory.ReadProcess = myProcess[0];
                    myMemory.Open();
                    int pointerAddy = HexToDec(HealthPointer);
                    //change for straight memory read/write since address is static base
                    byte[] valueToWrite = BitConverter.GetBytes(HealthToSet);
                    int bytesWritten;

                    myMemory.Write((IntPtr)pointerAddy,valueToWrite, out bytesWritten);
                    

                    myMemory.CloseHandle();
                }
            }
            else
            {
                isGameAvailable = false;
                lblGameStatus.Text = "Process not found!";
            }
        }

        public static int HexToDec(string Hex)
        {
            return (int.Parse(Hex, NumberStyles.HexNumber));
        }
        public static string DecToHex(int Dec)
        {
            return (Dec.ToString("X"));
        }

        private void btnHealth_Click(object sender, EventArgs e)
        {

            if (isGameAvailable)
            {
                if (!unlimitedHealth)
                {
                    unlimitedHealth = true;
                    lblHealthStatus.Text = "Health: On";
                }
                else if (unlimitedHealth)
                {
                    unlimitedHealth = false;
                    lblHealthStatus.Text = "Health: Off";
                }
            }


        }
    }
}
