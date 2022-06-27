using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Platformer2D.Core.Interfaces
{
    internal interface IDrawable
    {
        void Draw(GameTime gameTime, SpriteBatch spriteBatch);
    }
}
