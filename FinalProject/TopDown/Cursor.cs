using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;



namespace TopDown
{
    class Cursor
    {
        Texture2D cursortexture;
        public Vector2 mouseCoordinates;

        public bool cursorvisible = true;

        public void LoadContent(ContentManager theContentManager)
        {
            this.cursortexture = theContentManager.Load<Texture2D>("cursor");
        }

        public void Update(GameTime theGameTime)
        {
            var mouseState = Mouse.GetState();
            this.mouseCoordinates = new Vector2(mouseState.X, mouseState.Y);
        }

        public void Draw(SpriteBatch theSpriteBatch)
        {
            if (cursorvisible == true)
            {
                theSpriteBatch.Draw(this.cursortexture, this.mouseCoordinates, Color.Red);
            }
        }


      
    }
}
