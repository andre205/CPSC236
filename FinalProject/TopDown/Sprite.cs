using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;

namespace TopDown
{
    class Sprite
    {
        //The current position of the Sprite
        public Vector2 Position = new Vector2(0, 0);

        //The asset name for the Sprite's Texture
        public string AssetName;

        //The texture object used when drawing the sprite
        public Texture2D mSpriteTexture;

        //The size of the Sprite
        public Rectangle Size;

        //Sound effect associated with the object
        //private SoundEffect mSpriteSoundEffect;

        //The Rectangular area from the original image that 
        //defines the Sprite. 
        Rectangle mSource;

        float rotation = 0.0f;

        public Rectangle Source
        {
            get { return mSource; }
            set
            {
                mSource = value;
                Size = new Rectangle(0, 0, (int)(mSource.Width * Scale), (int)(mSource.Height * Scale));
            }
        }

        //When the scale is modified through he property, the Size of the 
        //sprite is recalculated with the new scale applied.
        //The amount to increase/decrease the size of the original sprite. 
        private float mScale = 1.0f;
        public float Scale
        {
            get { return mScale; }
            set
            {
                mScale = value;
                //Recalculate the Size of the Sprite with the new scale
                Size = new Rectangle(0, 0, (int)(Source.Width * Scale), (int)(Source.Height * Scale));
            }
        }

        //Load the texture for the sprite using the Content Pipeline
        public void LoadContent(ContentManager theContentManager, string theAssetName)
        {
            //if (theAssetName.Contains("FX"))
            //    mSpriteSoundEffect = theContentManager.Load<SoundEffect>(theAssetName);
            //else
                mSpriteTexture = theContentManager.Load<Texture2D>(theAssetName);
            AssetName = theAssetName;
            Source = new Rectangle(0, 0, mSpriteTexture.Width, mSpriteTexture.Height);
            Size = new Rectangle(0, 0, (int)(mSpriteTexture.Width * Scale), (int)(mSpriteTexture.Height * Scale));
        }

        //Draw the sprite to the screen
        public virtual void Draw(SpriteBatch theSpriteBatch)
        {
            theSpriteBatch.Draw(mSpriteTexture, Position, new Rectangle(0, 0, mSpriteTexture.Width, mSpriteTexture.Height), Color.White, rotation, new Vector2(mSpriteTexture.Width/2, mSpriteTexture.Height/2), Scale, SpriteEffects.None, 0);
        }

        //Update the Sprite and change it's position based on the passed in speed, direction and elapsed time.
        public void Update(GameTime theGameTime, Vector2 theSpeed, Vector2 theDirection, float angle)
        {
            Position += theDirection * theSpeed * (float)theGameTime.ElapsedGameTime.TotalSeconds;
            rotation = angle;
        }

        public void PlaySound()
        {
            //mSpriteSoundEffect.Play();
        }
    }
}
