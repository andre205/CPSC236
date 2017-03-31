using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna;

namespace TopDown
{

    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        Player mPlayer;
        Cursor mCursor;
        Menu menu = new Menu();
        Gameover gameover = new Gameover();

        Powerup bluePUtest;
        Level level;

        SpriteFont text;
        Vector2 mouseCoordinates;

        KeyboardState mPreviousKeyboardState;
        MouseState mPreviousMouseState;

        bool paused;

        ContentManager mContentManager;

        bool tut1 = false;
        bool tut2 = false;
        bool tut3 = false;
        bool tut4 = false;
        bool tut5 = false;
        bool tut6 = false;
        Texture2D arrow, ind, rightarrow, enemyexample;
        Rectangle rarrow = new Rectangle(30, 1000, 39, 53);
        Rectangle rind = new Rectangle(230, 800, 34, 198);
        Rectangle rrightarrow = new Rectangle(900, 215, 86, 57);
        Rectangle renemy = new Rectangle(1050, 225, 40, 40);

        bool EXIT = false; 

        Texture2D enemy;
        Rectangle enemy1, enemy2, enemy3, enemy4;
        bool enemy1vis = false;
        bool enemy2vis = false;
        bool enemy3vis = false;
        bool enemy4vis = false;

        int updates = 0;

        int enemy1hp = 1;
        int enemy2hp = 1;
        int enemy3hp = 1;
        int enemy4hp = 1;

        bool weaponupgrade1 = false;
        bool weaponupgrade2 = false;
        bool weaponupgrade3 = false;

        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";

            graphics.PreferredBackBufferWidth = 1920;
            graphics.PreferredBackBufferHeight = 1080;
            graphics.IsFullScreen = true;
            graphics.ApplyChanges();
        }


        protected override void Initialize()
        {
            menu.ShowDialog();

            if (menu.play)
            {
                mPlayer = new Player();
                mCursor = new Cursor();
                bluePUtest = new Powerup();
                level = new Level();
                level.levelname = "ONE";
                if (menu.tut)
                {
                    level.levelname = "TUTORIAL";
                    tut1 = true;
                }

                base.Initialize();
            }
            else
                base.Exit();
        }


        protected override void LoadContent()
        {

            spriteBatch = new SpriteBatch(GraphicsDevice);

            mPlayer.LoadContent(this.Content);
            mCursor.LoadContent(this.Content);
            bluePUtest.LoadContent(this.Content);
            level.LoadContent(this.Content);

            text = Content.Load<SpriteFont>("SpriteFont1");
            arrow = Content.Load<Texture2D>("arrow");
            ind = Content.Load<Texture2D>("weapon display");
            rightarrow = Content.Load<Texture2D>("rightarrow");
            enemyexample = Content.Load<Texture2D>("enemyexample");
            

            enemy = Content.Load<Texture2D>("enemyexample");
            enemy1.Width = 40;
            enemy1.Height = 40;
            enemy1.X = 265;
            enemy1.Y = 100;
            enemy2.Width = 40;
            enemy2.Height = 40;
            enemy2.X = 1600;
            enemy2.Y = 100;
            enemy3.Width = 40;
            enemy3.Height = 40;
            enemy3.X = 265;
            enemy3.Y = 975;
            enemy4.Width = 40;
            enemy4.Height = 40;
            enemy4.X = 1600;
            enemy4.Y = 975;
        }


        protected override void UnloadContent()
        {
 
        }


        protected override void Update(GameTime gameTime)
        {
            MouseState aCurrentMouseState = Mouse.GetState();
            mPreviousMouseState = aCurrentMouseState;
            mouseCoordinates = new Vector2(aCurrentMouseState.X, aCurrentMouseState.Y);

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape) || EXIT)
                 Exit();

            if (Keyboard.GetState().IsKeyDown(Keys.M))
                menu.ShowDialog();

            if (menu.play != true)
                Exit();

            //KEEP TOGETHER
            if (1750 <= mouseCoordinates.X && mouseCoordinates.X <= 1900 && 550 <= mouseCoordinates.Y && mouseCoordinates.Y <= 600)
            {
                paused = true;
            }
            else
                paused = false;
            //KEEP TOGETHER


            if (mPlayer.alive != true)
            {
                mPlayer.alive = true;
                gameover.ShowDialog();
                if (gameover.playagain != true)
                    Exit();
                updateForGameover();
            }

            if (!paused)
            {
                mPlayer.Update(gameTime);
                mCursor.Update(gameTime);
                bluePUtest.Update(gameTime);
                level.Update(gameTime);

                base.Update(gameTime);

                KeyboardState aCurrentKeyboardState = Keyboard.GetState();

                mPreviousKeyboardState = aCurrentKeyboardState;

                if (level.levelname == "TUTORIAL")
                {
                    if (aCurrentKeyboardState.IsKeyDown(Keys.Space) && gameTime.TotalGameTime.Seconds > 5)
                    {
                        tut1 = false;
                        tut2 = true;
                    }
                    if (tut2)
                        rarrow.X = (int)mPlayer.health * 3 + 180;
                    if (aCurrentKeyboardState.IsKeyDown(Keys.Space) && gameTime.TotalGameTime.Seconds > 12)
                    {
                        tut2 = false;
                        tut3 = true;
                    }
                    if (gameTime.TotalGameTime.Seconds > 20 && rind.Y > 75)
                        rind.Y -= 10;
                    if (aCurrentKeyboardState.IsKeyDown(Keys.Space) && gameTime.TotalGameTime.Seconds > 21)
                    {
                        tut3 = false;
                        tut4 = true;
                    }
                    if (aCurrentKeyboardState.IsKeyDown(Keys.Space) && gameTime.TotalGameTime.Seconds > 28)
                    {
                        tut4 = false;
                        tut5 = true;
                    }
                    if (aCurrentKeyboardState.IsKeyDown(Keys.Space) && gameTime.TotalGameTime.Seconds > 35)
                    {
                        tut5 = false;
                        tut6 = true;
                    }
                    if (aCurrentKeyboardState.IsKeyDown(Keys.Enter) == true && gameTime.TotalGameTime.Seconds > 40)
                    {
                        tut6 = false;
                        level.kills = 0;
                        level.levelname = "ONE";
                    }
                }



                if (enemy1vis)
                {
                    if (enemy1.X < mPlayer.Position.X && enemy1.X < 1650)
                        enemy1.X += 3;
                    if (enemy1.Y < mPlayer.Position.Y && enemy1.Y < 990)
                        enemy1.Y += 2;
                    if (enemy1.X > mPlayer.Position.X && enemy1.X > 220)
                        enemy1.X -= 3;
                    if (enemy1.Y > mPlayer.Position.Y && enemy1.Y > 50)
                        enemy1.Y -= 4;

                    if (enemy1.X <= mPlayer.Position.X + 10 && enemy1.Y <= mPlayer.Position.Y + 10 && enemy1.X > mPlayer.Position.X - 1 && enemy1.Y > mPlayer.Position.Y - 1)
                    {
                        enemy1vis = false;
                        mPlayer.health -= level.enemydamage;
                        level.kills += 1;
                    }
                }
                if (enemy2vis)
                {
                    if (enemy2.X < mPlayer.Position.X && enemy2.X < 1650)
                        enemy2.X += 4;
                    if (enemy2.Y < mPlayer.Position.Y && enemy2.Y < 990)
                        enemy2.Y += 2;
                    if (enemy2.X > mPlayer.Position.X && enemy2.X > 220)
                        enemy2.X -= 3;
                    if (enemy2.Y > mPlayer.Position.Y && enemy2.Y > 50)
                        enemy2.Y -= 4;

                    if (enemy2.X <= mPlayer.Position.X + 10 && enemy2.Y <= mPlayer.Position.Y + 10 && enemy2.X > mPlayer.Position.X - 1 && enemy2.Y > mPlayer.Position.Y - 1)
                    {
                        enemy2vis = false;
                        mPlayer.health -= level.enemydamage;
                        level.kills += 1;
                    }
                }
                if (enemy3vis)
                {
                    if (enemy3.X < mPlayer.Position.X && enemy3.X < 1650)
                        enemy3.X += 4;
                    if (enemy3.Y < mPlayer.Position.Y && enemy3.Y < 990)
                        enemy3.Y += 2;
                    if (enemy3.X > mPlayer.Position.X && enemy3.X > 220)
                        enemy3.X -= 3;
                    if (enemy3.Y > mPlayer.Position.Y && enemy3.Y > 50)
                        enemy3.Y -= 4;

                    if (enemy3.X <= mPlayer.Position.X + 10 && enemy3.Y <= mPlayer.Position.Y + 10 && enemy3.X > mPlayer.Position.X - 1 && enemy3.Y > mPlayer.Position.Y - 1)
                    {
                        enemy3vis = false;
                        mPlayer.health -= level.enemydamage;
                        level.kills += 1;
                    }
                }
                if (enemy4vis)
                {
                    if (enemy4.X < mPlayer.Position.X && enemy4.X < 1650)
                        enemy4.X += 4;
                    if (enemy4.Y < mPlayer.Position.Y && enemy4.Y < 990)
                        enemy4.Y += 3;
                    if (enemy4.X > mPlayer.Position.X && enemy4.X > 220)
                        enemy4.X -= 2;
                    if (enemy4.Y > mPlayer.Position.Y && enemy4.Y > 50)
                        enemy4.Y -= 3;

                    if (enemy4.X <= mPlayer.Position.X + 10 && enemy4.Y <= mPlayer.Position.Y + 10 && enemy4.X > mPlayer.Position.X - 1 && enemy4.Y > mPlayer.Position.Y - 1)
                    {
                        enemy4vis = false;
                        mPlayer.health -= level.enemydamage;
                        level.kills += 1;
                    }
                }

                foreach (Bullet b in mPlayer.mBullets)
                {

                    if (enemy1vis)
                        if (b.Position.X > (enemy1.X - 1) && b.Position.X < (enemy1.X + 50) && b.Position.Y > enemy1.Y && b.Position.Y < (enemy1.Y + 50))
                        {
                            enemy1hp -= mPlayer.damage;
                            if (enemy1hp <= 0)
                            {
                                enemy1vis = false;
                                b.Visible = false;
                                level.kills += 1;
                            }

                            break;
                        }

                    if (enemy2vis)
                        if (b.Position.X > (enemy2.X - 1) && b.Position.X < (enemy2.X + 50) && b.Position.Y > enemy2.Y && b.Position.Y < enemy2.Y + 50)
                        {
                            enemy2hp -= mPlayer.damage;
                            if (enemy2hp <= 0)
                            {
                                enemy2vis = false;
                                b.Visible = false;
                                level.kills += 1;
                            }
                            break;
                        }

                    if (enemy3vis)
                        if (b.Position.X > (enemy3.X - 1) && b.Position.X < (enemy3.X + 50) && b.Position.Y > enemy3.Y && b.Position.Y < enemy3.Y + 50)
                        {
                            enemy3hp -= mPlayer.damage;
                            if (enemy3hp <= 0)
                            {
                                enemy3vis = false;
                                b.Visible = false;
                                level.kills += 1;
                            }
                            break;
                        }

                    if (enemy4vis)
                        if (b.Position.X > (enemy4.X - 1) && b.Position.X < (enemy4.X + 50) && b.Position.Y > enemy4.Y && b.Position.Y < enemy4.Y + 50)
                        {
                            enemy4hp -= mPlayer.damage;
                            if (enemy4hp <= 0)
                            {
                                enemy4vis = false;
                                b.Visible = false;
                                level.kills += 1;
                            }
                            break;
                        }
                }

                if (level.kills == -1 && updates == 0 && menu.tut == false)
                {
                    updateEnemies();
                    updates += 1;
                }

                if (level.kills == 0 && updates == 0)
                {
                    updateEnemies();
                    updates += 1;
                }


                if (level.kills >= 4 && level.kills < 8 && updates == 1)
                {
                    level.levelname = "TWO";
                    level.enemyhealthlower = 2;
                    level.enemyhealthupper = 5;
                    level.enemydamage = 75;
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 8 && updates == 2)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 12 && updates == 3)
                {
                    level.levelname = "THREE";
                    level.enemyhealthupper = 7;
                    level.enemydamage = 100;
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 16 && updates == 4)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 20 && updates == 5)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 24 && updates == 6)
                {
                    level.levelname = "FOUR";
                    level.enemyhealthlower = 6;
                    level.enemyhealthupper = 10;
                    level.enemydamage = 120;
                    updates += 1;
                    updateEnemies();

                    mPlayer.regen = 15;
                    mPlayer.actualregen = .6f;
                    mPlayer.damage = 3;
                    mPlayer.specialattribute = 1;
                    weaponupgrade1 = true;
                }

                if (level.kills == 28 && updates == 7)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 32 && updates == 8)
                {
                    updates += 1;
                    updateEnemies();
                    weaponupgrade1 = false;
                }

                if (level.kills == 36 && updates == 9)
                {
                    level.levelname = "FIVE";
                    level.enemyhealthlower = 10;
                    level.enemyhealthupper = 16;
                    level.enemydamage = 150;
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 40 && updates == 10)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 44 && updates == 11)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 48 && updates == 12)
                {
                    level.levelname = "SIX";
                    level.enemyhealthlower = 16;
                    level.enemyhealthupper = 20;
                    level.enemydamage = 175;
                    updates += 1;
                    weaponupgrade2 = true;
                    mPlayer.regen = 30;
                    mPlayer.actualregen = 1.2f;
                    mPlayer.damage = 7;
                    mPlayer.specialattribute = 0;
                    updateEnemies();
                }

                if (level.kills == 52 && updates == 13)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 56 && updates == 14)
                {
                    updates += 1;
                    weaponupgrade2 = false;
                    updateEnemies();
                }

                if (level.kills == 60 && updates == 15)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 64 && updates == 16)
                {
                    level.levelname = "SEVEN";
                    level.enemyhealthlower = 20;
                    level.enemyhealthupper = 25;
                    level.enemydamage = 200;

                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 68 && updates == 17)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 72 && updates == 18)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 76 && updates == 19)
                {
                    level.levelname = "EIGHT";
                    level.enemyhealthlower = 1000;
                    level.enemyhealthupper = 2000;
                    level.enemydamage = 350;

                    weaponupgrade3 = true;
                    mPlayer.regen = 150;
                    mPlayer.actualregen = 5f;
                    mPlayer.damage = 50;
                    mPlayer.specialattribute = 2;

                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 80 && updates == 20)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 84 && updates == 21)
                {
                    weaponupgrade3 = false;
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 88 && updates == 22)
                {
                    level.enemydamage = 400;
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 92 && updates == 23)
                {
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 96 && updates == 24)
                {
                    level.enemyhealthlower = 100000;
                    level.enemyhealthupper = 200000;
                    level.levelname = "END OF GAME";
                    updates += 1;
                    updateEnemies();
                }

                if (level.kills == 100 && updates == 28)
                {
                    updates += 1;
                    updateEnemies();
                }




            }


        }


        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Black);

            spriteBatch.Begin();
            base.Draw(gameTime);

            level.Draw(spriteBatch);
            bluePUtest.Draw(spriteBatch);
            mPlayer.Draw(spriteBatch);
 

            spriteBatch.DrawString(text, gameTime.TotalGameTime.Seconds.ToString(), new Vector2(1850, 1040), Color.White, 0, new Vector2(0, 0), 1f, SpriteEffects.None, 0f);


            if (level.levelname == "TUTORIAL")
            {
                spriteBatch.DrawString(text, "PRESS SPACE TO PROCEED THROUGH THE TUTORIAL", new Vector2(1920/2 - 200, 60), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                if (tut1)
                {
                    spriteBatch.DrawString(text, "AIM WITH THE MOUSE \nPRESS LEFT CLICK TO SHOOT", mouseCoordinates - new Vector2(0, 50), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                    spriteBatch.DrawString(text, "USE WASD TO MOVE", mPlayer.Position + new Vector2(20, -5), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                }
                if (tut2)
                {
                    spriteBatch.DrawString(text, "SHOOTING DRAINS YOUR HEALTH", new Vector2(1400, 950), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(arrow, rarrow, Color.White);
                }
                if (tut3)
                {
                    spriteBatch.DrawString(text, "THIS IS YOUR WEAPON \n\nITS STATS ARE SHOWN HERE\n\nYOU WILL FIND MORE POWERFUL WEAPONS \nAS THE GAME PROGRESSES", new Vector2(320, 850), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(ind, rind, Color.White);
                }
                if (tut4)
                {
                    spriteBatch.DrawString(text, "THIS IS THE CURRENT LEVEL \n\nENEMY STATS ARE SHOWN HERE\n\nENEMIES WILL BECOMES STRONGER \nAS THE GAME PROGRESSES", new Vector2(320, 115), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(ind, rind, Color.White);
                }
                if (tut5)
                {
                    spriteBatch.DrawString(text, "ENEMIES LOOK LIKE THIS\n\nTHEY DEAL DAMAGE WHEN HIT", new Vector2(520, 215), Color.White, 0, new Vector2(0, 0), 1f, SpriteEffects.None, 0f);
                    spriteBatch.Draw(rightarrow, rrightarrow, Color.White);
                    spriteBatch.Draw(enemyexample, renemy, Color.White);
                }
                if (tut6)
                {
                    spriteBatch.DrawString(text, "YOU HAVE COMPLETED THIS TUTORIAL -- GOOD LUCK\n\n---------- PRESS ENTER TO BEGIN LEVEL ONE ----------", new Vector2(1920 / 2 - 275, 200), Color.White, 0, new Vector2(0, 0), 1f, SpriteEffects.None, 0f);
                }
            }

            if (weaponupgrade1)
            {
                spriteBatch.DrawString(text, "NEW WEAPON \nFOUND", new Vector2(1750, 250), Color.MonoGameOrange, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "DAMAGE", new Vector2(1750, 300), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "+2", new Vector2(1750, 320), Color.Red, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "HEALTH REGEN", new Vector2(1750, 340), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "+10", new Vector2(1750, 360), Color.Red, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "NEW ATTRIBUTE:", new Vector2(1750, 380), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "BURN", new Vector2(1750, 400), Color.Red, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
            }

            if (weaponupgrade2)
            {
                spriteBatch.DrawString(text, "NEW WEAPON \nFOUND", new Vector2(1750, 250), Color.MonoGameOrange, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "DAMAGE", new Vector2(1750, 300), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "+4", new Vector2(1750, 320), Color.Red, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "HEALTH REGEN", new Vector2(1750, 340), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "+15", new Vector2(1750, 360), Color.Red, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "ATTRIBUTE:", new Vector2(1750, 380), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "PIERCE", new Vector2(1750, 400), Color.GreenYellow, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
            }

            if (weaponupgrade3)
            {
                spriteBatch.DrawString(text, "NEW WEAPON \nFOUND", new Vector2(1750, 250), Color.MonoGameOrange, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "DAMAGE", new Vector2(1750, 300), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "MAX", new Vector2(1750, 320), Color.Pink, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "HEALTH REGEN", new Vector2(1750, 340), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "MAX", new Vector2(1750, 360), Color.Pink, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "ATTRIBUTE:", new Vector2(1750, 380), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "ALL", new Vector2(1750, 400), Color.GreenYellow, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "UNLOCKED:", new Vector2(1750, 420), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "RAPID FIRE", new Vector2(1750, 440), Color.Purple, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
                spriteBatch.DrawString(text, "HOLD RIGHT CLICK TO ACTIVATE RAPID FIRE MODE", new Vector2(750, 60), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);

            }


            if (enemy1vis)
                spriteBatch.Draw(enemy, enemy1, Color.White);
            if (enemy2vis)
                spriteBatch.Draw(enemy, enemy2, Color.White);
            if (enemy3vis)
                spriteBatch.Draw(enemy, enemy3, Color.White);
            if (enemy4vis)
                spriteBatch.Draw(enemy, enemy4, Color.White);

            mCursor.Draw(spriteBatch);
            spriteBatch.End();
        }

        public void updateEnemies()
        {
            if (level.kills == -1)
                level.kills = 0;
             
            enemy1.Width = 40;
            enemy1.Height = 40;
            enemy1.X = 265;
            enemy1.Y = 100;

            enemy2.Width = 40;
            enemy2.Height = 40;
            enemy2.X = 1600;
            enemy2.Y = 100;

            enemy3.Width = 40;
            enemy3.Height = 40;
            enemy3.X = 265;
            enemy3.Y = 975;

            enemy4.Width = 40;
            enemy4.Height = 40;
            enemy4.X = 1600;
            enemy4.Y = 975;

            enemy1hp = level.enemyhealthupper;
            enemy2hp = level.enemyhealthupper;
            enemy3hp = level.enemyhealthupper;
            enemy4hp = level.enemyhealthupper;

            enemy1vis = true;
            enemy2vis = true;
            enemy3vis = true;
            enemy4vis = true;
        }

        public void updateForGameover()
        {
            level.kills = -1;
            level.levelname = "ONE";            
            updates = 0;
            menu.tut = false;
            mPlayer.health = 507f;
            mPlayer.damage = 1;
            mPlayer.weapontype = 0;
            level.enemyhealthlower = 1;
            level.enemyhealthupper = 3;
            level.enemydamage = 50;
            weaponupgrade1 = false;
            weaponupgrade2 = false;
            weaponupgrade3 = false;
            mPlayer.regen = 1;
            mPlayer.actualregen = .2f;

        }
        
    }
}
