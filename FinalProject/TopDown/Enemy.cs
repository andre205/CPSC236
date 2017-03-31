using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;

namespace TopDown
{
    class Enemy
    {
        public bool Visible = false;

        public Vector2 Position;

        public void LoadContent(ContentManager theContentManager)
        {
            theContentManager.Load<Texture2D>("enemyexample");
        }

        public void Update(GameTime theGameTime)
        {
            KeyboardState aCurrentKeyboardState = Keyboard.GetState();

            if (Position.X > 1705 || Position.X < 215 || Position.Y > 1035 || Position.Y < 40)
                Visible = false;

            if (Visible == true)
            {
               // base.Update(theGameTime);
            }

            

        }


        public void Draw(SpriteBatch theSpriteBatch)
        {
            if (Visible == true)
            {
                Draw(theSpriteBatch);
            }


        }

        public void Spawn(Vector2 theStartPosition)
        {
            Position = theStartPosition;
            Visible = true;
        }
    }
}
