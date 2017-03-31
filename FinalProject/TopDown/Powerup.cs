using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using System.Collections.Generic;

namespace TopDown
{
    class Powerup : Sprite
    {
        List<Powerup> mPowerups = new List<Powerup>();



        public void LoadContent(ContentManager theContentManager)
        {
            //base.LoadContent(theContentManager, "redorb");
            //base.LoadContent(theContentManager, "greenorb");
            base.LoadContent(theContentManager, "blueorb");
        }

        public void Update(GameTime theGameTime)
        {
            base.Scale = .1f;
            base.Position = new Vector2(800,100);
        }

        public override void Draw(SpriteBatch theSpriteBatch)
        {
            //base.Draw(theSpriteBatch);
        }

       

    }
}
