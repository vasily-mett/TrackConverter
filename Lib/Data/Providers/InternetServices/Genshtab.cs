﻿using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.Projections;
using System;
using System.IO;
using System.Net;

namespace TrackConverter.Lib.Data.Providers.InternetServices
{
    /// <summary>
    /// карты генштаба и ГГЦ
    /// </summary>
    public static class GenshtabGGC
    {
        /// <summary>
        /// основные методы для получения карт ГГЦ
        /// </summary>
        public abstract class BaseGenshtab : BaseMapProvider
        {
            /// <summary>
            /// проекция карты
            /// </summary>
            public override PureProjection Projection
            {
                get
                {
                    return MercatorProjection.Instance;
                }
            }

            /// <summary>
            /// зеркала сервиса карт (для распределения нагрузки)
            /// </summary>
            public abstract string[] Mirrors { get; }

            /// <summary>
            /// расширение файла тайла
            /// </summary>
            public abstract string Extension { get; }

            private int buf_ok = int.MinValue;
            private int buf_no = int.MinValue;

            /// <summary>
            /// проверить существование масштаба на сервере
            /// </summary>
            /// <param name="url"></param>
            /// <returns></returns>
            private int getCode(string url)
            {
                WebClient wc = new WebClient();
                try
                {
                    string ans = wc.DownloadString(url);
                    return int.Parse(ans);
                }
                catch (WebException e)
                {
                    Stream resp = e.Response.GetResponseStream();
                    StreamReader sr = new StreamReader(resp);
                    string ans = sr.ReadToEnd();
                    if (ans.Contains("403"))
                        return 200;
                    else
                        return 404;
                }
            }

            /// <summary>
            /// создать URL для запроса тайла
            /// </summary>
            /// <param name="pos"></param>
            /// <param name="zoom"></param>
            /// <returns></returns>
            protected string CombineURL(GPoint pos, int zoom)
            {
                //выбор масштаба, которые есть в карте
                int z_ok, z_no;
                if (buf_ok == int.MinValue)
                    buf_ok = 1;
                if (buf_no == int.MinValue)
                    buf_no = 25;
                z_ok = buf_ok;
                z_no = buf_no;

                if (zoom > z_no)
                    return "";

                int r = new Random().Next(Mirrors.Length);
                string url = Mirrors[r];


                if (zoom > z_ok)
                {
                    int code = getCode(url + "z" + (zoom + 1) + "/");
                    // Внимание! Если сервер вернёт 403 - code почему-то будет 0. Так что выбор "404 или что-то иное"
                    // Если дело дошло до проверки наличия масштаба - значит какая-то граница (z_ok / z_no) точно подвинется.

                    if (code == 404)
                        z_no = zoom;
                    else
                        z_ok = zoom;

                    // Сохраняем актуализированные границы для последующих вызовов
                    buf_no = z_no;
                    buf_ok = z_ok;

                    if (zoom >= z_no)
                        return "";
                }

                int divx = (int)(pos.X / 1024);
                int divy = (int)(pos.Y / 1024);

                string res = url + string.Format("z{0}/{1}/x{2}/{3}/y{4}{5}", zoom + 1, divx, pos.X, divy, pos.Y, Extension);
                return res;
            }
        }

        /// <summary>
        /// километровка 
        /// </summary>
        public class KM1 : BaseGenshtab
        {
            public static KM1 Instance;

            static KM1()
            {
                Instance = new KM1();
            }

            /// <summary>
            /// зеркала сервиса карт (для распределения нагрузки)
            /// </summary>
            public override string[] Mirrors
            {
                get
                {
                    return new string[] {
                        "http://91.237.82.95:8088/pub/genshtab/1km/",
                        "http://maps.melda.ru/pub/genshtab/1km/"
                    };
                }
            }

            /// <summary>
            /// GUID карты (придуман рандомно, но постоянный)
            /// </summary>
            public override Guid Id
            {
                get
                {
                    return new Guid("BF6C9C19-AD78-4F1F-96CE-6EF1F5B52EF7");
                }
            }

            /// <summary>
            /// название карты
            /// </summary>
            public override string Name
            {
                get
                {
                    return "Генштаб 1км";
                }
            }

            /// <summary>
            /// слои карты (если она состоит из нескольких слоёв, как гибриды)
            /// </summary>
            public override GMapProvider[] Overlays
            {
                get
                {
                    return new GMapProvider[1] { Instance };
                }
            }

            /// <summary>
            /// расширение файла тайла
            /// </summary>
            public override string Extension
            {
                get
                {
                    return ".jpg";
                }
            }

            /// <summary>
            /// получить тайл карты по координатам
            /// </summary>
            /// <param name="pos">координаты тайла карты</param>
            /// <param name="zoom">масштаб</param>
            /// <returns></returns>
            public override PureImage GetTileImage(GPoint pos, int zoom)
            {
                string url = CombineURL(pos, zoom);
                if (string.IsNullOrEmpty(url))
                    return null;
                return GetGMapImage(url);
            }
        }

        /// <summary>
        /// 250 метров 
        /// </summary>
        public class M250 : BaseGenshtab
        {
            public static M250 Instance;

            static M250()
            {
                Instance = new M250();
            }

            /// <summary>
            /// зеркала сервиса карт (для распределения нагрузки)
            /// </summary>
            public override string[] Mirrors
            {
                get
                {
                    return new string[] {
                        "http://91.237.82.95:8088/pub/ggc/250m.png/",
                        "http://maps.melda.ru/pub/ggc/250m.png/"
                    };
                }
            }

            /// <summary>
            /// GUID карты (придуман рандомно, но постоянный)
            /// </summary>
            public override Guid Id
            {
                get
                {
                    return new Guid("BF6C9C79-AD78-4F1F-96CE-6EF1F5B52EF7");
                }
            }

            /// <summary>
            /// название карты
            /// </summary>
            public override string Name
            {
                get
                {
                    return "Генштаб 250м";
                }
            }

            /// <summary>
            /// слои карты (если она состоит из нескольких слоёв, как гибриды)
            /// </summary>
            public override GMapProvider[] Overlays
            {
                get
                {
                    return new GMapProvider[1] { Instance };
                }
            }

            /// <summary>
            /// расширение файла тайла
            /// </summary>
            public override string Extension
            {
                get
                {
                    return ".png";
                }
            }

            /// <summary>
            /// получить тайл карты по координатам
            /// </summary>
            /// <param name="pos">координаты тайла карты</param>
            /// <param name="zoom">масштаб</param>
            /// <returns></returns>
            public override PureImage GetTileImage(GPoint pos, int zoom)
            {
                string url = CombineURL(pos, zoom);
                if (string.IsNullOrEmpty(url))
                    return null;
                return GetGMapImage(url);
            }
        }


        /// <summary>
        /// 250 метров 
        /// </summary>
        public class M500 : BaseGenshtab
        {
            public static M500 Instance;

            static M500()
            {
                Instance = new M500();
            }

            /// <summary>
            /// зеркала сервиса карт (для распределения нагрузки)
            /// </summary>
            public override string[] Mirrors
            {
                get
                {
                    return new string[] {
                        "http://91.237.82.95:8088/pub/genshtab/500m/",
                        "http://maps.melda.ru/pub/genshtab/500m/"
                    };
                }
            }

            /// <summary>
            /// GUID карты (придуман рандомно, но постоянный)
            /// </summary>
            public override Guid Id
            {
                get
                {
                    return new Guid("BF6C9C79-AB78-4F1F-96CE-6E11F5B52EF7");
                }
            }

            /// <summary>
            /// название карты
            /// </summary>
            public override string Name
            {
                get
                {
                    return "Генштаб 500м";
                }
            }

            /// <summary>
            /// слои карты (если она состоит из нескольких слоёв, как гибриды)
            /// </summary>
            public override GMapProvider[] Overlays
            {
                get
                {
                    return new GMapProvider[1] { Instance };
                }
            }

            /// <summary>
            /// расширение файла тайла
            /// </summary>
            public override string Extension
            {
                get
                {
                    return ".jpg";
                }
            }

            /// <summary>
            /// получить тайл карты по координатам
            /// </summary>
            /// <param name="pos">координаты тайла карты</param>
            /// <param name="zoom">масштаб</param>
            /// <returns></returns>
            public override PureImage GetTileImage(GPoint pos, int zoom)
            {
                string url = CombineURL(pos, zoom);
                if (string.IsNullOrEmpty(url))
                    return null;
                return GetGMapImage(url);
            }
        }


        /// <summary>
        /// 250 метров 
        /// </summary>
        public class KM5 : BaseGenshtab
        {
            public static KM5 Instance;

            static KM5()
            {
                Instance = new KM5();
            }

            /// <summary>
            /// зеркала сервиса карт (для распределения нагрузки)
            /// </summary>
            public override string[] Mirrors
            {
                get
                {
                    return new string[] {
                        "http://91.237.82.95:8088/pub/genshtab/5km/",
                        "http://maps.melda.ru/pub/genshtab/5km/"
                    };
                }
            }

            /// <summary>
            /// GUID карты (придуман рандомно, но постоянный)
            /// </summary>
            public override Guid Id
            {
                get
                {
                    return new Guid("BF6C9C79-AD78-4F1F-97CE-6EF1F5B53EF7");
                }
            }

            /// <summary>
            /// название карты
            /// </summary>
            public override string Name
            {
                get
                {
                    return "Генштаб 5км";
                }
            }

            /// <summary>
            /// слои карты (если она состоит из нескольких слоёв, как гибриды)
            /// </summary>
            public override GMapProvider[] Overlays
            {
                get
                {
                    return new GMapProvider[1] { Instance };
                }
            }

            /// <summary>
            /// расширение файла тайла
            /// </summary>
            public override string Extension
            {
                get
                {
                    return ".jpg";
                }
            }

            /// <summary>
            /// получить тайл карты по координатам
            /// </summary>
            /// <param name="pos">координаты тайла карты</param>
            /// <param name="zoom">масштаб</param>
            /// <returns></returns>
            public override PureImage GetTileImage(GPoint pos, int zoom)
            {
                string url = CombineURL(pos, zoom);
                if (string.IsNullOrEmpty(url))
                    return null;
                return GetGMapImage(url);
            }
        }


        /// <summary>
        /// 250 метров 
        /// </summary>
        public class KM10 : BaseGenshtab
        {
            public static KM10 Instance;

            static KM10()
            {
                Instance = new KM10();
            }

            /// <summary>
            /// зеркала сервиса карт (для распределения нагрузки)
            /// </summary>
            public override string[] Mirrors
            {
                get
                {
                    return new string[] {
                        "http://91.237.82.95:8088/pub/genshtab/10km/",
                        "http://maps.melda.ru/pub/genshtab/10km/"
                    };
                }
            }

            /// <summary>
            /// GUID карты (придуман рандомно, но постоянный)
            /// </summary>
            public override Guid Id
            {
                get
                {
                    return new Guid("BF6C9C79-CD78-4F1F-96CE-6EF1E5B52EF7");
                }
            }

            /// <summary>
            /// название карты
            /// </summary>
            public override string Name
            {
                get
                {
                    return "Генштаб 10 км";
                }
            }

            /// <summary>
            /// слои карты (если она состоит из нескольких слоёв, как гибриды)
            /// </summary>
            public override GMapProvider[] Overlays
            {
                get
                {
                    return new GMapProvider[1] { Instance };
                }
            }

            /// <summary>
            /// расширение файла тайла
            /// </summary>
            public override string Extension
            {
                get
                {
                    return ".jpg";
                }
            }

            /// <summary>
            /// получить тайл карты по координатам
            /// </summary>
            /// <param name="pos">координаты тайла карты</param>
            /// <param name="zoom">масштаб</param>
            /// <returns></returns>
            public override PureImage GetTileImage(GPoint pos, int zoom)
            {
                string url = CombineURL(pos, zoom);
                if (string.IsNullOrEmpty(url))
                    return null;
                return GetGMapImage(url);
            }
        }
    }
}
