using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shot_Game
{
    public partial class Form1 : Form
    {
        //object of the random class to get  the random shot of fire 
        Random rd = new Random();
        Shoot objct = new Shoot();

        //global  variable for generate the fire 
        int y = 0,cnt=0,triger=0;
        int shootaway = 0;
        public Form1()
        {
            InitializeComponent();
            if (objct.reset()==1) {
                reset();
            }
            y= rd.Next(1,3);
        }

        public void reset() {

            btnBullets.Enabled = false;
            btnSpin.Enabled = false;
            btnFire.Enabled = false;
        }
        private void btnLoading_Click(object sender, EventArgs e)
        {
            /* this mmethod is used to start the game and load the bullets in the gun to fire for this is have 
            change the image for the picture box now the  next Image will be display */
            Photo.ImageLocation = "pistol.jpg";

            btnLoading.Enabled = false;
            btnBullets.Enabled = true;
        }

        private void btnBullets_Click(object sender, EventArgs e)
        {
            /*
             this is the second step of the Fire Game with this in the game the gun is load with  bullets for firing 
             */
            Photo.ImageLocation = "Bullets.jpg";
            btnBullets.Enabled = false;
            btnSpin.Enabled = true;
            btnFire.Enabled = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            shootaway = 0;
            if (objct.reset() == 1)
            {
                reset();
            }
            y = rd.Next(1, 3);
            cnt = 0;
            triger = 0;
            btnLoading.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shootaway++;
            if (shootaway==y) {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("sund.wav");

                player.Play();
                MessageBox.Show("chances are over ");
                button1.Enabled = false;
                button2.Enabled = true;
                
            }

        }

        private void btnSpin_Click(object sender, EventArgs e)
        {
            /*
                this code is used to ready the bullet for fire so thus the user can fire to his aim 
             */
            Photo.ImageLocation = "ready.jpg";
            btnBullets.Enabled = false;
            btnSpin.Enabled =false;
            btnFire.Enabled =true;
        }

        private void btnFire_Click(object sender, EventArgs e)
        {
            /*
             this method is used to fire the bullet if the bullet is shot the aim then the game will be over one player can use 2 bullets only in one time
             */
             //this counter is used to count the click of the fire button
            cnt++;
            if (cnt == y)
            {
                /// generating the method that is used to play the sound of the Fire 
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("sund.wav");

                player.Play();
                //also generate the another method to trigger the gain Fire 
                //calling the method of the another class which Has the Triiger method
                objct.trigger();
                //passing the range of the trigger 
                y = rd.Next(3,5);
                triger++;
                if (triger == 1)
                {
                    MessageBox.Show("Your last chance to shoot again");
                }
                cnt = 0;
            }
            else {
                //this else block is used to generate the sound of empty triger of pistol
                System.Media.SoundPlayer player = new System.Media.SoundPlayer("Empty.wav");
                player.Play();
            }

          


            //this is used to count the shot when it's 2 then the message will be display of the game over
            if (triger==2) {
                
                if (triger == y)
                {
                    MessageBox.Show("Congraluation you are the winner and got 100 marks");
                }
                else {
                    MessageBox.Show("Opps! you loss the Game");
                }

                btnFire.Enabled = false;
                button1.Enabled = true;
                
                cnt = 0;
                triger = 0;
            }

        }
    }
}
