using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssement1
{
    public class Commandclass
  
{
   int Shot = 0;
   int Survival = 2;
  public void LongDistanceShooting()
        //This is for open scope and then shoot on the target

        {

            if (Survival > 0)
            {
                     {
                    MessageBox.Show("Scope Opend");
                    Shot = Shot + 1;
                }
            }
            else
            {
                MessageBox.Show("Better Luck Next Time");
            }
            Survival = Survival - 1;
        }
        //This function is end here

        public void RetryBtn()
        //This Function is for when playerout and try again to play this

        {
            Shot = 0;
            Survival = 2;
            MessageBox.Show("Ready to play");
        }
        //This function is end here

        public void SwipegunBtn()
        //This function is for to chnage gun when shot empty in one gun

        {
            Random rand = new Random();
            Shot = rand.Next(0, 6);
            MessageBox.Show("Your Gun is change now");
        }
        //This function is end here

        public void ReloadMagButton()
        //This function is for when your shots are empty then reload the gun

        {
            Shot = 0;
            MessageBox.Show("Reloading is successful");
        }
        //This function is end here
        public void BulletShootingBtn()
        {
            if (Shot == 5)
            {
                MessageBox.Show("Better Luck Next Time");
            }
            else
            {
                MessageBox.Show("Shoot start");
                Shot = Shot + 1; }
        }
        //This function is end here
    }
}
