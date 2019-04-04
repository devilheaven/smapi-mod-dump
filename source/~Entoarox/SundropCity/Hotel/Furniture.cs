using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace SundropCity.Hotel
{
    abstract class Furniture
    {
        public string Type;
        public int Subtype;
        public int Picture;
        public bool IsLit;
        public Furniture[] Slotted;

        public abstract void Draw(SpriteBatch b);
    }
}
