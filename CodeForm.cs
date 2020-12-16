using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompleteAssement1
{
    public partial class CodeForm : Form
    {
        Commandclass Logic = new Commandclass();
        
        public CodeForm()
        //This is CodeForm

        {
            InitializeComponent();
        }
        //This function is end here

        private void RetryBtn_Click(object sender, EventArgs e)
            //This is Retry Button
        {
            Logic.RetryBtn();
        }
        //This function is end here

        private void LongDistanceShooting_Click(object sender, EventArgs e)
        //This is Long Shoot Button

        {
            Logic.LongDistanceShooting();
        }
        //This function is end here
        private void GunShootBt_Click(object sender, EventArgs e)
        //This is GunShoot Button

        {
            SoundPlayer sound = new SoundPlayer(CompleteAssement1.Properties.Resources.GunSound);
            sound.Play();
            Logic.BulletShootingBtn();
        }
        //This function is end here
        private void SoundPlayer()
        //This is Sound Player

        {
            throw new NotImplementedException();
        }
        //This function is end here

        private void ReloadMagButton_Click(object sender, EventArgs e)
        //This is ReloadMag Button

        {
            Logic.ReloadMagButton();
        }
        //This function is end here
        private void SwipegunBtn_Click(object sender, EventArgs e)
        //This is Swipe Gun Button

        {
            Logic.SwipegunBtn();
        }
        //This function is end here


        private void GameView_Click(object sender, EventArgs e)
        //This is Game View Button

        {

        }
        //This function is end here
    }
}
