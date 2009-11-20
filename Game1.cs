//XNA icin namespace'lerimiz
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
        GraphicsDeviceManager graphics; //grafik olaylarini tutan degiskenimiz,sistem otomatik yaratiyor
        SpriteBatch spriteBatch; //sprite'lari yoneten degiskenimiz,sistem otomatik yaratiyor
        Texture2D kaplama; //sprite icin gereken kaplamayi tutacak degisken
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content"; //materyal icin klasor tanimliyoruz
        }

       
        protected override void Initialize()
        {
           
            
            base.Initialize();
        }

       
        protected override void LoadContent()
        {
          
            spriteBatch = new SpriteBatch(GraphicsDevice);
            kaplama = Content.Load<Texture2D>("top"); //AssetName'i top olan kaplamamizi iliskilendiriyoruz.
          
        }

      
        protected override void UnloadContent()
        {
            Content.Unload(); //Oyundan cikildiginde load ettigimiz herseyi serbest birakiyoruz
            kaplama.Dispose(); //Halihazirda kaplama tutan degiskenimizi serbest birakiyoruz
        }

      
        protected override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); //Ekrani temizliyoruz
            spriteBatch.Begin(); //Cizime basliyoruz
            spriteBatch.Draw(kaplama, new Vector2(20, 20), Color.White); //20,20 koordinatlarinda bir sprite cizdiriyoruz
            spriteBatch.End(); //Cizimi bitiriyoruz
            base.Draw(gameTime);
        }
    }
}
