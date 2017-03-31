using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TopDown
{
    class Bullet : Sprite
    {
        const int MAX_DISTANCE = 2000;

        public bool Visible = false;

        Vector2 mStartPosition;
        Vector2 mSpeed;
        Vector2 mDirection;
        float angle = 0.0f;


        public void LoadContent(ContentManager theContentManager)
        {
            base.LoadContent(theContentManager, "temporaryplayer_bullet");

            //Scale = 0.3f;
            //base.LoadContent(theContentManager, "laser3FX");

        }

        public void Update(GameTime theGameTime)
        {           

            if (Vector2.Distance(mStartPosition, Position) > MAX_DISTANCE)
            {
                Visible = false;
            }

            if (base.Position.X > 1705 || base.Position.X < 215 || base.Position.Y > 1035 || base.Position.Y < 40)
                Visible = false;

            if (Visible == true)
            {
                base.Update(theGameTime, mSpeed, mDirection, angle);
            }
        }

        public override void Draw(SpriteBatch theSpriteBatch)
        {
            if (Visible == true)
            {
                base.Draw(theSpriteBatch);
            }

            theSpriteBatch.Draw(base.mSpriteTexture, new Vector2(90, 825), base.Size, Color.White);
        }

        public void Fire(Vector2 theStartPosition, Vector2 theSpeed, Vector2 theDirection, float theRotation)
        {
            Position = theStartPosition;
            mStartPosition = theStartPosition;
            mSpeed = theSpeed;
            mDirection = theDirection;
            angle = theRotation;
            Visible = true;
            //base.PlaySound();
        }
    }
}
