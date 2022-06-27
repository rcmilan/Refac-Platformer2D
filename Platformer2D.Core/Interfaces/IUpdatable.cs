using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace Platformer2D.Core.Interfaces
{
    public interface IUpdatable
    {
        void Update(GameTime gameTime, KeyboardState? keyboardState = null, GamePadState? gamePadState = null, AccelerometerState? accelState = null, DisplayOrientation? orientation = null);
    }
}