using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Input;
using System.Collections.Generic;

namespace TopDown
{
    class Level : Sprite
    {
        public string levelname = "TUTORIAL";
        public int enemyhealthlower = 1;
        public int enemyhealthupper = 3;
        public int enemydamage = 50;

        float angle = 0.0f;

        public int kills = -1;

        SpriteFont text;

        KeyboardState mPreviousKeyboardState;
        MouseState mPreviousMouseState;

        ContentManager mContentManager;

        Vector2 mouseCoordinates;

        public void LoadContent(ContentManager theContentManager)
        {
            base.LoadContent(theContentManager, "level_outline");
            text = theContentManager.Load<SpriteFont>("SpriteFont1");

            mContentManager = theContentManager;
        }

        public void Update(GameTime theGameTime)
        {
            base.Scale = 1f;
            base.Position = new Vector2(1920/2,1080/2);

            KeyboardState aCurrentKeyboardState = Keyboard.GetState();
            MouseState aCurrentMouseState = Mouse.GetState();

            mPreviousKeyboardState = aCurrentKeyboardState;
            mPreviousMouseState = aCurrentMouseState;

            mouseCoordinates = new Vector2(aCurrentMouseState.X, aCurrentMouseState.Y);
        }
        
        public override void Draw(SpriteBatch theSpriteBatch)
        {
            base.Draw(theSpriteBatch);

            theSpriteBatch.DrawString(text, "CURRENT LEVEL", new Vector2(30, 100), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
            theSpriteBatch.DrawString(text, levelname, new Vector2(65, 125), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);

            theSpriteBatch.DrawString(text, "ENEMY HEALTH", new Vector2(30, 150), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
            theSpriteBatch.DrawString(text, enemyhealthlower.ToString() + "  -  " + enemyhealthupper.ToString(), new Vector2(65, 175), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);

            theSpriteBatch.DrawString(text, "ENEMY DAMAGE", new Vector2(30, 200), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);
            theSpriteBatch.DrawString(text, enemydamage.ToString(), new Vector2(65, 225), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);

            theSpriteBatch.DrawString(text, "KILLS: " + kills.ToString(), new Vector2(1800, 100), Color.White, 0, new Vector2(0, 0), .75f, SpriteEffects.None, 0f);


            theSpriteBatch.DrawString(text, "PAUSE", new Vector2(1750, 550), Color.White, 0, new Vector2(0, 0), 1f, SpriteEffects.None, 0f);

            theSpriteBatch.DrawString(text, "PRESS ESC\nTO EXIT", new Vector2(1750, 950), Color.White, 0, new Vector2(0, 0), 1f, SpriteEffects.None, 0f);
            theSpriteBatch.DrawString(text, "PRESS M\nFOR MENU", new Vector2(40, 550), Color.White, 0, new Vector2(0, 0), 1f, SpriteEffects.None, 0f);

        }



        public void setLevelName(string s)
        {
            levelname = s;
        }



    }
}
