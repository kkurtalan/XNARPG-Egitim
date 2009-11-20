//XNA için namespace'lerimiz
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Net;
using Microsoft.Xna.Framework.Storage;
//
namespace merhabadunya
{
   
    public class Game1 : Microsoft.Xna.Framework.Game
    {
        GraphicsDeviceManager graphics; //grafik olaylarýný tutan deðiþkenimiz,sistem otomatik yaratýyor
        SpriteBatch spriteBatch; //sprite'larý yöneten deðiþkenimiz,sistem otomatik yaratýyor
        Texture2D kaplama; //sprite için gereken kaplamayý tutacak deðiþken
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content"; //materyal için klasör tanýmlýyoruz
        }

       
        protected override void Initialize()
        {
           
            
            base.Initialize();
        }

       
        protected override void LoadContent()
        {
          
            spriteBatch = new SpriteBatch(GraphicsDevice);
            kaplama = Content.Load<Texture2D>("top"); //AssetName'i top olan kaplamamýzý iliþkilendiriyoruz.
          
        }

      
        protected override void UnloadContent()
        {
            Content.Unload(); //Oyundan çýkýldýðýnda load ettiðimiz herþeyi serbest býrakýyoruz
            kaplama.Dispose(); //Halihazýrda bir kaplama tutan deðiþkenimizi serbest býrakýyoruz
        }

      
        protected override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); //Ekraný temizliyoruz
            spriteBatch.Begin(); //Çizime baþlýyoruz

            spriteBatch.Draw(kaplama, new Vector2(20, 20), Color.White); //20,20 koordinatlarýnda bir sprite çizdiriyoruz
            spriteBatch.End(); //Çizimi bitiriyoruz
            base.Draw(gameTime);
        }
    }
}
