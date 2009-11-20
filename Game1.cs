//XNA i�in namespace'lerimiz
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
        GraphicsDeviceManager graphics; //grafik olaylar�n� tutan de�i�kenimiz,sistem otomatik yarat�yor
        SpriteBatch spriteBatch; //sprite'lar� y�neten de�i�kenimiz,sistem otomatik yarat�yor
        Texture2D kaplama; //sprite i�in gereken kaplamay� tutacak de�i�ken
        public Game1()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content"; //materyal i�in klas�r tan�ml�yoruz
        }

       
        protected override void Initialize()
        {
           
            
            base.Initialize();
        }

       
        protected override void LoadContent()
        {
          
            spriteBatch = new SpriteBatch(GraphicsDevice);
            kaplama = Content.Load<Texture2D>("top"); //AssetName'i top olan kaplamam�z� ili�kilendiriyoruz.
          
        }

      
        protected override void UnloadContent()
        {
            Content.Unload(); //Oyundan ��k�ld���nda load etti�imiz her�eyi serbest b�rak�yoruz
            kaplama.Dispose(); //Halihaz�rda bir kaplama tutan de�i�kenimizi serbest b�rak�yoruz
        }

      
        protected override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }

       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); //Ekran� temizliyoruz
            spriteBatch.Begin(); //�izime ba�l�yoruz

            spriteBatch.Draw(kaplama, new Vector2(20, 20), Color.White); //20,20 koordinatlar�nda bir sprite �izdiriyoruz
            spriteBatch.End(); //�izimi bitiriyoruz
            base.Draw(gameTime);
        }
    }
}
