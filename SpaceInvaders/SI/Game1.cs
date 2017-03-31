using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna;
using Microsoft.Win32;
using System;

namespace SI
{
    public class Game1 : Game
    {
        //I had a tough time getting classes to cooperate properly, so I decided to do everything in game1
        //I followed David Hays' tutorial for some of the basics (https://www.youtube.com/watch?v=wIW4S75iZBI)
        //He covered creating the player, invader, and player bullet
        //I added everything else. (SpriteFont text, Enemy bullet / shooting mechanic, background, form1, high score tracker, etc)
        //My normal invader is a standard 1-hit kill. invader2 has 2 health to make it a bit tougher.

        //FORM FOR INSTRUCTIONS/PLAY AGAIN
        Form1 form1 = new Form1();

        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D invader, invader2, player, bullet, enemybullet, scrollback1, scrollback2;
        Rectangle rectPlayer, rectBullet, rectEnemyBullet, rectscrollback1, rectscrollback2;

        //Formation of invaders (rows/cols can be modified, as well as speed)
        Rectangle[,] invaderFormation;     
        int rows = 3;
        int cols = 8;
        int invaderspeed = 3;
        string direction = "R";
        int[,] visinvader;

        bool visbullet = false;
        bool visenemybullet = false;

        //Score displayed on screen
        int score = 0;
        float timepassed = 0.0f;
        SpriteFont scoreText;
        Vector2 textlocation = new Vector2 (690, 20);
        Vector2 exitlocation = new Vector2(10, 6);
        Vector2 timelocation = new Vector2(350, 6);

        public bool gameover = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";        
        }

        protected override void Initialize()
        {
            form1.ShowDialog();
            if (form1.play)
                base.Initialize();
        }
      
        protected override void LoadContent()
        {            
            spriteBatch = new SpriteBatch(GraphicsDevice);

            invader = Content.Load<Texture2D>("invader");
            invader2 = Content.Load<Texture2D>("invader2");
            invaderFormation = new Rectangle[rows, cols];
            //INVADER HEALTH | 0 = DEAD, 1HP, OR 2HP
            visinvader = new int[rows, cols];

            resetInvaders();

            scrollback1 = Content.Load<Texture2D>("scrollback1");
            rectscrollback1.Width = scrollback1.Width;
            rectscrollback1.Height = scrollback1.Height;
            rectscrollback1.X = 0;
            rectscrollback1.Y = -3000;

            scrollback2 = Content.Load<Texture2D>("scrollback1");
            rectscrollback2.Width = scrollback2.Width;
            rectscrollback2.Height = scrollback2.Height;
            rectscrollback2.X = 0;
            rectscrollback2.Y = -6000;

            player = Content.Load<Texture2D>("player");
            rectPlayer.Width = player.Width;
            rectPlayer.Height = player.Height;
            rectPlayer.X = 350;
            rectPlayer.Y = 415;

            bullet = Content.Load<Texture2D>("bullet");
            rectBullet.Width = bullet.Width;
            rectBullet.Height = bullet.Height;
            rectBullet.X = 0;
            rectBullet.Y = 0;

            enemybullet = Content.Load<Texture2D>("enemybullet");
            rectEnemyBullet.Width = enemybullet.Width;
            rectEnemyBullet.Height = enemybullet.Height;
            rectEnemyBullet.X = 0;
            rectEnemyBullet.Y = 0;

            scoreText = Content.Load<SpriteFont>("SpriteFont1");            
        }

        protected override void UnloadContent()
        {            
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            if (form1.play == false)
                Exit();

            //Scroll background
            //bg1 starts right above the screen, bg2 starts above bg1
            // both scroll downward, added to top of stack when they reach the bottom (image is >3 times the screen height)
            if (rectscrollback1.Y < 3000)            
                rectscrollback1.Y += 2;
            if (rectscrollback2.Y < 3000)
                rectscrollback2.Y += 2;            
            if (rectscrollback1.Y == 3000)
                rectscrollback1.Y = -3000;
            if (rectscrollback2.Y == 3000)
                rectscrollback2.Y = -3000;

            //Invader movement
            //Moves each invader based on its direction and speed

            //Side boundaries
            //Leftside = 0
            int rightside = graphics.GraphicsDevice.Viewport.Width;

            for (int r = 0; r < rows; ++r)
                for (int c = 0; c < cols; ++c)
                {
                    if (direction.Equals("R"))
                        invaderFormation[r, c].X = invaderFormation[r, c].X + invaderspeed;
                    if (direction.Equals("L"))
                        invaderFormation[r, c].X = invaderFormation[r, c].X - invaderspeed;
                }

            //When half invaders die, speed up invaders and add 50 to score
            if (score == rows * cols / 2)
            {
                invaderspeed = invaderspeed * 2;
                score += 2;
            }
            
            //Side boundaries
            bool changedir = false;

            //(width of invader is 50)
            for (int r = 0; r < rows; ++r)
                for (int c = 0; c < cols; ++c)
                {
                    if (visinvader[r, c] == 2 || visinvader[r, c] == 1)
                    {
                        if (invaderFormation[r, c].X + 50 > rightside)
                        {
                            direction = "L";
                            changedir = true;
                        }

                        if (invaderFormation[r, c].X < 0)
                        {
                            direction = "R";
                            changedir = true;
                        }
                    }
                }

            //Lower invaders on direction change
            if (changedir)
            {
                for (int r = 0; r < rows; ++r)
                    for (int c = 0; c < cols; ++c)
                        invaderFormation[r, c].Y = invaderFormation[r, c].Y + 3;
            }

            //Player movement
            //Player ship cannot exit screen boundaries (-20 <-> 770)
            KeyboardState kb = Keyboard.GetState();
            if (kb.IsKeyDown(Keys.Left))
                if(rectPlayer.X > -20)
                    rectPlayer.X = rectPlayer.X - 3;

            if (kb.IsKeyDown(Keys.Right))
                if (rectPlayer.X < 770)
                    rectPlayer.X = rectPlayer.X + 3;

            //Only able to shoot 1 bullet at a time.
            if (kb.IsKeyDown(Keys.Space) && visbullet == false)
            {
                visbullet = true;
                rectBullet.X = rectPlayer.X + rectPlayer.Width/2;
                rectBullet.Y = rectPlayer.Y;
            }

            //Bullet movement/collision
            if (visbullet)
            {
                //Bullet movement
                rectBullet.Y = rectBullet.Y - 5;
                //Iterate through invaders
                for (int r = 0; r < rows; ++r)
                {
                    for (int c = 0; c < cols; ++c)
                    {
                        if (visinvader[r, c] == 2 || visinvader[r, c] == 1)
                        {
                            //If hit, destroy bullet, damage invader, add 1 to score if kill, give invader a chance to shoot back
                            if (rectBullet.Intersects(invaderFormation[r, c]))
                            {
                                //invader2 has 2 health, so one hit decreases its health by 1
                                if (r%2 != 0 && visinvader[r, c] == 2)
                                {
                                    visbullet = false;
                                    visinvader[r, c] = 1;

                                }
                                //invader2 has 1 health, so this hit kills it
                                else if (r%2 != 0 && visinvader[r, c] == 1)
                                {
                                    visbullet = false;
                                    visinvader[r, c] = 0;
                                    //only shoot if enemy bullet is not yet in play
                                    if (visenemybullet == false)
                                        pickInvaderAndShoot();
                                    score++;
                                }
                                //invader1 only has 1 health, all hits are kills
                                else if (r%2 == 0)
                                {
                                    visbullet = false;
                                    visinvader[r, c] = 0;
                                    if (visenemybullet == false)
                                        pickInvaderAndShoot();
                                    score++;
                                }
                            }
                        }
                    }
                }
            }

            //Enemy bullet movement/collision
            if (visenemybullet)
            {
                rectEnemyBullet.Y = rectEnemyBullet.Y + 7;
                //Lower boundary
                if (rectEnemyBullet.Y > 500)
                    visenemybullet = false;
                //Player collision = gameover
                if (rectEnemyBullet.Intersects(rectPlayer))
                {
                    gameover = true;
                    //destroy lingering enemy bullets
                    visenemybullet = false;
                    visbullet = false;
                }
            }
           
            if (rectBullet.Y < -10)
                visbullet = false;

            //TIMER
            timepassed += (float)gameTime.ElapsedGameTime.TotalSeconds;

            //GAME OVER (Invader crosses player line) (hit by bullet shown above)
            for (int r = 0; r < rows; ++r)
                for (int c = 0; c < cols; ++c)
                {
                    if (visinvader[r,c] == 2 || visinvader[r, c] == 1)
                    {
                        if (invaderFormation[r, c].Y + invaderFormation[r,c].Height > rectPlayer.Y)
                            gameover = true;
                    }
                }

            if (gameover)
            {
                form1.updateForGameOver();
                gameover = false;
                score = 0;
                timepassed = 0;
                ResetElapsedTime();
                resetInvaders();
                             
                form1.ShowDialog();
            }

            //PLAYER VICTORY
            //send time to form1
            if (score >= rows*cols + 2)
            {
                form1.updateForWin(timepassed);
                score = 0;
                timepassed = 0;
                resetInvaders();
                
                form1.ShowDialog();
            }

            base.Update(gameTime);
        }


        protected override void Draw(GameTime gameTime)
        {         
            GraphicsDevice.Clear(Color.Black);
            spriteBatch.Begin();


            //DRAW BACKGROUND
            spriteBatch.Draw(scrollback1, rectscrollback1, Color.White);
            spriteBatch.Draw(scrollback2, rectscrollback2, Color.White);

            //DRAW INVADER FORMATION
            drawInvaders();

            //DRAW PLAYER
            spriteBatch.Draw(player, rectPlayer, Color.White);

            //DRAW PLAYER BULLET
            if (visbullet)
                spriteBatch.Draw(bullet, rectBullet, Color.Orange);

            //DRAW ENEMY BULLET
            if (visenemybullet)
                spriteBatch.Draw(enemybullet, rectEnemyBullet, Color.Red);   
                    
            //DRAW SCORE
            Vector2 FontOrigin = scoreText.MeasureString(score.ToString()) / 2;
            spriteBatch.DrawString(scoreText, "Score: " + (25 *score).ToString(), textlocation, Color.White, 0, FontOrigin, 1.0f, SpriteEffects.None, 0.5f);
            spriteBatch.DrawString(scoreText, "Press escape to exit.", exitlocation, Color.White);
            spriteBatch.DrawString(scoreText, timepassed.ToString("0.000"), timelocation, Color.White);

            spriteBatch.End();
            base.Draw(gameTime);
        }

        //Resets all invader objects for restarting the game
        //this can be modified to change the positioning of invader1/2, i have 2s in the middle for now
        private void resetInvaders()
        {
            invaderspeed = 3;
            for (int r = 1; r < rows; r=r+2)
                for (int c = 0; c < cols; ++c)
                {
                    invaderFormation[r, c].Width = invader2.Width;
                    invaderFormation[r, c].Height = invader2.Height;
                    invaderFormation[r, c].X = 80 * c;
                    invaderFormation[r, c].Y = 50 + (60 * r);
                    visinvader[r, c] = 2;
                }
            for (int r = 0; r < rows; r = r + 2)
                for (int c = 0; c < cols; ++c)
                {
                    invaderFormation[r, c].Width = invader.Width;
                    invaderFormation[r, c].Height = invader.Height;
                    invaderFormation[r, c].X = 80 * c;
                    invaderFormation[r, c].Y = 50 + (60 * r);
                    visinvader[r, c] = 2;
                }
        }

        private void drawInvaders()
        {
            for (int r = 1; r < rows; r = r + 2)
                for (int c = 0; c < cols; ++c)
                {
                    if (visinvader[r, c] == 2 || visinvader[r, c] == 1)
                    {
                        spriteBatch.Draw(invader2, invaderFormation[r, c], Color.Red);
                    }
                }
            for (int r = 0; r < rows; r = r + 2)
                for (int c = 0; c < cols; ++c)
                {
                    if (visinvader[r, c] == 2)
                    {
                        spriteBatch.Draw(invader, invaderFormation[r, c], Color.Red);
                    }
                    //not working
                    //Show if invader2 has been damaged
                    else if (visinvader[r, c] == 1)
                    {
                        spriteBatch.Draw(invader, invaderFormation[r, c], Color.DarkOrange);
                    }
                }
        }

        //Random generator used in choosing which invader fires a bullet
        private Random generator;
        private Random Generator
        {
            get
            {
                if (this.generator == null)
                {
                    this.generator = new Random();
                }
                return this.generator;
            }
        }

        //Generates a random row and column (location of an invader)
        //If that invader is still in play (visible), it generates an enemy bullet at that location
        //Disabled for the final invader so as not to cause an overflow error
        private void pickInvaderAndShoot()
        {
            int x = this.Generator.Next(0, rows);
            int y = this.Generator.Next(0, cols);

            //only shoots back if there is not a bullet already in play
            if (visinvader[x, y] == 2 || visinvader[x, y] == 1)
            {
                visenemybullet = true;
                rectEnemyBullet.X = invaderFormation[x, y].X + invaderFormation[x, y].Width / 2;
                rectEnemyBullet.Y = invaderFormation[x, y].Y;
            }
            
            else
                if (score < rows * cols + 1) //+2 from killing half, so 1 point off victory or less
                    pickInvaderAndShoot();                
            }
        }   
}