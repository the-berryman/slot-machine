using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project7
{
    public partial class slotMachineform : Form
    {
        public slotMachineform()
        {
            InitializeComponent();
            Timer slotmachinetimer = new Timer();
            

        }

        private void goButton_Click(object sender, EventArgs e)
        {
            slotmachinetimer.Start();












        }
        private void CalculateRoll()
        {
            

        }
        
        private void stopButton_Click(object sender, EventArgs e)
        {

           

        }


        double cycle = 0;
        double tick = 0;

        private void slotmachinetimer_Tick(object sender, EventArgs e)
        {
            cycle++;
            tick++;
        
            if (tick == 1)
            {
                slot1Roll1.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll10.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll1.Visible = false;

                slot3Roll5.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll1.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll10.Visible = false;
            }

            if (tick == 2)
            {
                slot1Roll2.Visible = true;
                slot1Roll1.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll9.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll1.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll6.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll1.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll10.Visible = false;
            }

            if (tick == 3)
            {
                slot1Roll3.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll1.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll8.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll1.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll7.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll1.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll10.Visible = false;
            }

            if (tick == 4)
            {
                slot1Roll4.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll1.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll7.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll1.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll8.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll1.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll10.Visible = false;
            }

            if (tick == 5)
            {
                slot1Roll5.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll1.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll6.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll1.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll9.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll1.Visible = false;
                slot3Roll10.Visible = false;
            }


            if (tick == 6)
            {
                slot1Roll6.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll1.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll5.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll1.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll10.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll1.Visible = false;
            }

            if (tick == 7)
            {
                slot1Roll7.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll1.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll4.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll1.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll2.Visible = true;
                slot3Roll1.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll10.Visible = false;


            }

            if (tick == 8)
            {
                slot1Roll8.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll1.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll3.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll1.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll1.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll10.Visible = false;
            }

            if (tick == 9)
            {
                slot1Roll9.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll1.Visible = false;
                slot1Roll10.Visible = false;

                slot2Roll2.Visible = true;
                slot2Roll1.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll3.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll1.Visible = false;
                slot3Roll4.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll10.Visible = false;
            }

            if (tick == 10)
            {
                slot1Roll10.Visible = true;
                slot1Roll2.Visible = false;
                slot1Roll3.Visible = false;
                slot1Roll4.Visible = false;
                slot1Roll5.Visible = false;
                slot1Roll6.Visible = false;
                slot1Roll7.Visible = false;
                slot1Roll8.Visible = false;
                slot1Roll9.Visible = false;
                slot1Roll1.Visible = false;

                slot2Roll1.Visible = true;
                slot2Roll2.Visible = false;
                slot2Roll3.Visible = false;
                slot2Roll4.Visible = false;
                slot2Roll5.Visible = false;
                slot2Roll6.Visible = false;
                slot2Roll7.Visible = false;
                slot2Roll8.Visible = false;
                slot2Roll9.Visible = false;
                slot2Roll10.Visible = false;

                slot3Roll4.Visible = true;
                slot3Roll2.Visible = false;
                slot3Roll3.Visible = false;
                slot3Roll1.Visible = false;
                slot3Roll5.Visible = false;
                slot3Roll6.Visible = false;
                slot3Roll7.Visible = false;
                slot3Roll8.Visible = false;
                slot3Roll9.Visible = false;
                slot3Roll10.Visible = false;
            }

            if (tick == 11)
            {
                tick = tick - 10;
            }

            if (cycle == 75)
            {
                slotmachinetimer.Stop();

                int totalmoney;
                int moneyround;
                int totalbet;
                int totalin = int.Parse(totalBet.Text);
                int totalearnings = int.Parse(winningsBox.Text);
                int money = int.Parse(moneyInput.Text);



                int slot1Rollhalf1;
                int slot1Rollhalf2;
                int slot1Roll;
                Random rand = new Random();

                slot1Rollhalf1 = rand.Next(4) + 0;
                slot1Rollhalf2 = rand.Next(6) + 1;
                slot1Roll = slot1Rollhalf1 + slot1Rollhalf2;

                if (slot1Roll == 1)
                {
                    slot1Roll1.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll10.Visible = false;

                }

                else if (slot1Roll == 2)
                {
                    slot1Roll2.Visible = true;
                    slot1Roll1.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll10.Visible = false;
                }



                else if (slot1Roll == 3)
                {
                    slot1Roll3.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll1.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll10.Visible = false;
                }


                else if (slot1Roll == 4)
                {
                    slot1Roll4.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll1.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll10.Visible = false;
                }

                else if (slot1Roll == 5)
                {
                    slot1Roll5.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll1.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll10.Visible = false;
                }

                else if (slot1Roll == 6)
                {
                    slot1Roll6.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll1.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll10.Visible = false;
                }

                else if (slot1Roll == 7)
                {
                    slot1Roll7.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll1.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll10.Visible = false;
                }

                else if (slot1Roll == 8)
                {
                    slot1Roll8.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll1.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll10.Visible = false;
                }

                else if (slot1Roll == 9)
                {
                    slot1Roll9.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll1.Visible = false;
                    slot1Roll10.Visible = false;
                }

                else if (slot1Roll == 10)
                {
                    slot1Roll10.Visible = true;
                    slot1Roll2.Visible = false;
                    slot1Roll3.Visible = false;
                    slot1Roll4.Visible = false;
                    slot1Roll5.Visible = false;
                    slot1Roll6.Visible = false;
                    slot1Roll7.Visible = false;
                    slot1Roll8.Visible = false;
                    slot1Roll9.Visible = false;
                    slot1Roll1.Visible = false;
                }

                int slot2Rollhalf1;
                int slot2Rollhalf2;
                int slot2Roll;
                Random rand2 = new Random();
                slot2Rollhalf1 = rand2.Next(7) + 0;
                slot2Rollhalf2 = rand2.Next(3) + 1;
                slot2Roll = slot2Rollhalf1 + slot2Rollhalf2;


                if (slot2Roll == 1)
                {
                    slot2Roll1.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll10.Visible = false;

                }

                else if (slot2Roll == 2)
                {
                    slot2Roll2.Visible = true;
                    slot2Roll1.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll10.Visible = false;
                }



                else if (slot2Roll == 3)
                {
                    slot2Roll3.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll1.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll10.Visible = false;
                }


                else if (slot2Roll == 4)
                {
                    slot2Roll4.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll1.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll10.Visible = false;
                }

                else if (slot2Roll == 5)
                {
                    slot2Roll5.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll1.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll10.Visible = false;
                }

                else if (slot2Roll == 6)
                {
                    slot2Roll6.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll1.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll10.Visible = false;
                }

                else if (slot2Roll == 7)
                {
                    slot2Roll7.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll1.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll10.Visible = false;
                }

                else if (slot2Roll == 8)
                {
                    slot2Roll8.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll1.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll10.Visible = false;
                }

                else if (slot2Roll == 9)
                {
                    slot2Roll9.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll1.Visible = false;
                    slot2Roll10.Visible = false;
                }

                else if (slot2Roll == 10)
                {
                    slot2Roll10.Visible = true;
                    slot2Roll2.Visible = false;
                    slot2Roll3.Visible = false;
                    slot2Roll4.Visible = false;
                    slot2Roll5.Visible = false;
                    slot2Roll6.Visible = false;
                    slot2Roll7.Visible = false;
                    slot2Roll8.Visible = false;
                    slot2Roll9.Visible = false;
                    slot2Roll1.Visible = false;
                }

                int slot3Roll;
                int slot3Rollhalf1;
                int slot3Rollhalf2;

                Random rand3 = new Random();
                slot3Rollhalf1 = rand3.Next(2) + 0;
                slot3Rollhalf2 = rand3.Next(8) + 1;
                slot3Roll = slot3Rollhalf1 + slot3Rollhalf2;


                if (slot3Roll == 1)
                {
                    slot3Roll1.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll10.Visible = false;

                }

                else if (slot3Roll == 2)
                {
                    slot3Roll2.Visible = true;
                    slot3Roll1.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll10.Visible = false;
                }



                else if (slot3Roll == 3)
                {
                    slot3Roll3.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll1.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll10.Visible = false;
                }


                else if (slot3Roll == 4)
                {
                    slot3Roll4.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll1.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll10.Visible = false;
                }

                else if (slot3Roll == 5)
                {
                    slot3Roll5.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll1.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll10.Visible = false;
                }

                else if (slot3Roll == 6)
                {
                    slot3Roll6.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll1.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll10.Visible = false;
                }

                else if (slot3Roll == 7)
                {
                    slot3Roll7.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll1.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll10.Visible = false;
                }

                else if (slot3Roll == 8)
                {
                    slot3Roll8.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll1.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll10.Visible = false;
                }

                else if (slot3Roll == 9)
                {
                    slot3Roll9.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll1.Visible = false;
                    slot3Roll10.Visible = false;
                }

                else if (slot3Roll == 10)
                {
                    slot3Roll10.Visible = true;
                    slot3Roll2.Visible = false;
                    slot3Roll3.Visible = false;
                    slot3Roll4.Visible = false;
                    slot3Roll5.Visible = false;
                    slot3Roll6.Visible = false;
                    slot3Roll7.Visible = false;
                    slot3Roll8.Visible = false;
                    slot3Roll9.Visible = false;
                    slot3Roll1.Visible = false;
                }


                int value1;
                int value2;
                int value3;

                value1 = slot1Roll;
                value2 = slot2Roll;
                value3 = slot3Roll;


                if (value1 == value2 && value2 == value3)
                {
                    totalmoney = money * 3 + totalearnings;
                    moneyround = money * 3;
                    winningsBox.Text = totalmoney.ToString();
                    totalbet = money + totalin;
                    totalBet.Text = totalbet.ToString();
                    statusLabel.Text = "Wow! you won " + moneyround + " dollars! Try again if you're feeling lucky!";
                    cycle = 0;
                }

                else if (value1 == value2 || value2 == value3 || value3 == value1)
                {
                    totalmoney = money * 2 + totalearnings;
                    moneyround = money * 2;
                    totalbet = money + totalin;
                    totalBet.Text = totalbet.ToString();
                    winningsBox.Text = totalmoney.ToString();
                    statusLabel.Text = "Nice! you won " + moneyround + " dollars! Try again if you're feeling lucky!";
                    cycle = 0;
                }

                else
                {
                    statusLabel.Text = "Oops, you didn't win any money this round. Try again.";
                    totalbet = money + totalin;
                    totalBet.Text = totalbet.ToString();
                    cycle = 0;
                }

            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void slotMachineform_Load(object sender, EventArgs e)
        {

        }
    }
}
