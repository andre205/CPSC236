using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace TopDown
{
    class Player : Sprite
    {
        const string PLAYER_ASSETNAME = "temporaryplayer";
        const int START_POSITION_X = 1920/2;
        const int START_POSITION_Y = 1080/2;
        const int PLAYER_SPEED = 200;
        const float MOVE_UP = -1.5f;
        const float MOVE_DOWN = 1.5f;
        const float MOVE_LEFT = -1.5f;
        const float MOVE_RIGHT = 1.5f;

        int kills = 0;

        //WEAPON INFORMATION (linked to player)
        //0 = REGEN PASSIVELY | 1 = LIFE ON HIT
        public int weapontype = 0;
        string weapontext;
        public int damage = 1;
        public int regen = 5;
        public float actualregen = .2f;
        //0 = NONE, 1 = BURN, 2 = CHAIN
        public int specialattribute = 0;
        string attributetext;

        

        public float health = 507f;
        Rectangle healthbar;
        Texture2D hpbartexture;
        public bool alive = true;

        SpriteFont text;

        float angle = 0.0f;

        public List<Bullet> mBullets = new List<Bullet>();

        ContentManager mContentManager;

        enum State
        {
            Walking
        }
        State mCurrentState = State.Walking;

        Vector2 mDirection = Vector2.Zero;
        Vector2 mSpeed = Vector2.Zero;
        Vector2 mouseCoordinates;

        KeyboardState mPreviousKeyboardState;
        MouseState mPreviousMouseState;
        

        public void LoadContent(ContentManager theContentManager)
        {
            mContentManager = theContentManager;

            foreach (Bullet aBullet in mBullets)
            {
                aBullet.LoadContent(theContentManager);
            }

            //1/20 scale for player image
            base.Scale = .05f;

            Position = new Vector2(START_POSITION_X, START_POSITION_Y);
            base.LoadContent(theContentManager, PLAYER_ASSETNAME);
            Source = new Rectangle(0, 0, Source.Width, Source.Height);

            healthbar.Width = (int)(3 * health);
            healthbar.Height = 10;
            healthbar.X = 200;
            healthbar.Y = 1062;
            hpbartexture = theContentManager.Load<Texture2D>("healthbar");



            text = theContentManager.Load<SpriteFont>("SpriteFont1");
        }

        public void Update(GameTime theGameTime)
        {
            KeyboardState aCurrentKeyboardState = Keyboard.GetState();
            MouseState aCurrentMouseState = Mouse.GetState();

            UpdateMovement(aCurrentKeyboardState);
            UpdateBullet(theGameTime, aCurrentKeyboardState, aCurrentMouseState);


            mPreviousKeyboardState = aCurrentKeyboardState;
            mPreviousMouseState = aCurrentMouseState;

            mouseCoordinates = new Vector2(aCurrentMouseState.X, aCurrentMouseState.Y);
            mouseCoordinates = mouseCoordinates - base.Position;
            mouseCoordinates.Normalize();
            angle = (float)Math.Atan2(mouseCoordinates.Y, mouseCoordinates.X);

            base.Update(theGameTime, mSpeed, mDirection, angle);

            healthbar.Width = (int)(3 * health);

            if (weapontype == 0)
            {
                if (health <= 507)
                    health += actualregen;
                weapontext = "LIFE REGEN PER SEC";
            }
            if(weapontype == 1)
                weapontext = "LIFE GAINED ON HIT";

            if (specialattribute == 0)
                attributetext = "PIERCE";
            if (specialattribute == 1)
                attributetext = "BURN";
            if (specialattribute == 2)
                attributetext = "ALL";


            if (health <= 0)
                alive = false;
              

         
            


        }

        private void UpdateMovement(KeyboardState aCurrentKeyboardState)
        {
            if (mCurrentState == State.Walking)
            {
                mSpeed = Vector2.Zero;
                mDirection = Vector2.Zero;

                //Bounds
                //Upper 50
                //Left 230
                //Right 1700
                //Bottom 1030
                if (aCurrentKeyboardState.IsKeyDown(Keys.A) == true && base.Position.X > 225)
                {
                    mSpeed.X = PLAYER_SPEED;
                    mDirection.X = MOVE_LEFT;
                }
                else if (aCurrentKeyboardState.IsKeyDown(Keys.D) == true && base.Position.X < 1695)
                {
                    mSpeed.X = PLAYER_SPEED;
                    mDirection.X = MOVE_RIGHT;
                }

                if (aCurrentKeyboardState.IsKeyDown(Keys.W) == true && base.Position.Y > 55) 
                {
                    mSpeed.Y = PLAYER_SPEED;
                    mDirection.Y = MOVE_UP;
                }
                else if (aCurrentKeyboardState.IsKeyDown(Keys.S) == true && base.Position.Y < 1025)
                {
                    mSpeed.Y = PLAYER_SPEED;
                    mDirection.Y = MOVE_DOWN;
                }
            }
        }

        public override void Draw(SpriteBatch theSpriteBatch)
        {
            foreach (Bullet aBullet in mBullets)
            {
                aBullet.Draw(theSpriteBatch);
            }
            base.Draw(theSpriteBatch);

            theSpriteBatch.Draw(hpbartexture, healthbar, Color.Red);

            theSpriteBatch.DrawString(text, "CURRENT WEAPON", new Vector2(30, 800), Color.Orange, 0, new Vector2(0,0), .75f, SpriteEffects.None, 0f);
            //picture of bullet

            theSpriteBatch.DrawString(text, "DAMAGE PER HIT", new Vector2(30, 850), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
            theSpriteBatch.DrawString(text, damage.ToString(), new Vector2(65, 875), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);

            theSpriteBatch.DrawString(text, weapontext, new Vector2(30, 900), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
            theSpriteBatch.DrawString(text, regen.ToString(), new Vector2(65, 925), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);

            theSpriteBatch.DrawString(text, "SPECIAL ATTRIBUTE", new Vector2(30, 950), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
            theSpriteBatch.DrawString(text, attributetext, new Vector2(65, 975), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);

            if (health <= 50)
                theSpriteBatch.DrawString(text, "HEALTH CRITICALLY LOW", new Vector2(350, 1058), Color.White, 0, new Vector2(0, 0), .55f, SpriteEffects.None, 0f);



        }

        

        private void UpdateBullet(GameTime theGameTime, KeyboardState aCurrentKeyboardState, MouseState aCurrentMouseState)
        {
            foreach (Bullet aFireball in mBullets)
            {
                aFireball.Update(theGameTime);
            }

            if (aCurrentMouseState.LeftButton == ButtonState.Pressed && mPreviousMouseState.LeftButton == ButtonState.Released)
            {
                ShootBullet();
            }

            if (aCurrentMouseState.RightButton == ButtonState.Pressed && mPreviousMouseState.RightButton == ButtonState.Pressed)
            {
                ShootBullet();
            }
        }

        private void ShootBullet()
        {
            if (mCurrentState == State.Walking)
            {
                bool aCreateNew = true;
                if (health >= 50)
                {
                    foreach (Bullet aBullet in mBullets)
                    {
                        if (aBullet.Visible == false)
                        {
                            aCreateNew = false;
                            aBullet.Fire(base.Position, new Vector2(800, 800), mouseCoordinates, angle);
                            health -= 10;
                            break;
                        }
                    }

                    if (aCreateNew == true)
                    {
                        Bullet aFireball = new Bullet();
                        aFireball.LoadContent(mContentManager);
                        aFireball.Fire(base.Position, new Vector2(800, 800), mouseCoordinates, angle);
                        health -= 10;
                        mBullets.Add(aFireball);
                    }
                }
            }
        }

        }

    }

