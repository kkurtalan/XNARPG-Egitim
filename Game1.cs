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
       

        Texture2D[] tileResim = new Texture2D[2]; //Tile icin kullanacagimiz resimleri tutacak dizi degiskeni
        const int haritaGenislik = 5; //cizdirecegimiz haritanin eninin kac adet tile resminden olusacagi
        const int haritaYukseklik = 5; //cizdirecegimiz haritanin boyunun kac adet tile resminden olusacagi

        int[,] harita = new int[haritaGenislik, haritaYukseklik] { 
                             { 0, 1, 0, 1, 0 },
                             { 0, 1, 0, 1, 0 }, 
                             { 1, 1, 1, 0, 0 }, 
                             { 0, 1, 0, 1, 0 }, 
                             { 0, 0, 0, 1, 0 },                              
        };  //haritamizi tutan dizi

        int haritaX = 0; //cizdirecegimiz haritanin X koordinati
        int haritaY = 0; //cizdirecegimiz haritanin Y koordinati

       

      

        int tileGenislik = 50; //cizdirecegimiz tile resminin genisligi
        int tileYukseklik = 50; //cizdirecegimiz tile resminin yuksekligi

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
            tileResim[0] = Content.Load<Texture2D>("cimen"); //tileResim dizisinin 0. elemanina AssetName'i cimen olan resmi iliskilendiriyoruz
            tileResim[1] = Content.Load<Texture2D>("toprak");  //tileResim dizisinin 1. elemanina AssetName'i toprak olan resmi iliskilendiriyoruz
        }

      
        protected override void UnloadContent()
        {
            Content.Unload(); //Oyundan cikildiginde load ettigimiz herseyi serbest birakiyoruz
            tileResim[0].Dispose(); //Halihazirda cimen resmini tutan degiskenimizi serbest birakiyoruz
            tileResim[1].Dispose(); //Halihazirda toprak resmini tutan degiskenimizi serbest birakiyoruz
        }

      
        protected override void Update(GameTime gameTime)
        {

            base.Update(gameTime);
        }
           
       
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue); //Ekrani temizliyoruz
            spriteBatch.Begin(); //Cizime basliyoruz
              
            for (int y = 0; y < haritaYukseklik; y++)
                //haritanin satir sayisi kadar dongu baslatiyoruz
            {
                for (int x = 0; x < haritaGenislik; x++)
                {
                    //haritanin sutun sayisi kadar dongu baslatiyoruz
                    spriteBatch.Draw(tileResim[harita[y + haritaY, x + haritaX]], 
                        //cizdirecegimiz resimin ismini bulduruyoruz, harita dizisinin degeri dongu 
                        //elemanlarina gore 0 veya 1 dondurecek,0 dondururse tileResim dizisinin 0. degeri cimen
                        //oldugu icin isim olarak cimen, 1 dondururse tileResim dizisinin 1. degeri toprak donecek

                                    new Rectangle((x * tileGenislik),                                       
                                                  (y * tileYukseklik),
                                                   tileGenislik, tileYukseklik), Color.White);
                                //cizdirecegimiz tile icin bir dikdortgen tanimliyoruz, 4 adet parametre aliyor, 
                                //bunlar dikdortgenin baslangic X koordinati, baslangic Y koordinati,en ve boy
                                //baslangic koordinatlarini buldurmak icin dongu elemanlari ile tile boyunu carpiyoruz.

                }
            }            
            
            spriteBatch.End(); //Cizimi bitiriyoruz
            base.Draw(gameTime);
        }
    }
}
