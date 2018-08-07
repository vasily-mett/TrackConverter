﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrackConverter.Lib.Classes.Options
{
    /// <summary>
    /// настройки источников данных(геокодер, высоты)
    /// </summary>
    public class DataSources
    {
        /// <summary>
        /// создает новый экземпляр настроек источников данных
        /// </summary>
        public DataSources()
        {
            ETOPODBFolder = "";
            GeoCoderProvider = GeoCoderProvider.Yandex;
            GeoInfoProvider = GeoInfoProvider.Google;
            UseGeocoderCache = true;
            UseSystemTimeZones = false;
            UseMapLayerCache = true;
            MaxImageCacheAge = TimeSpan.FromDays(30);
        }

        /// <summary>
        /// поставщик геокодера
        /// </summary>
        public GeoCoderProvider GeoCoderProvider { get; set; }

        /// <summary>
        /// поставщик геоинформации
        /// </summary>
        public GeoInfoProvider GeoInfoProvider { get; set; }

        /// <summary>
        /// папка базы данных ETOPO
        /// </summary>
        public string ETOPODBFolder { get; set; }

        /// <summary>
        /// Использовать кэш геокодера и высот в интернет-сервисах
        /// </summary>
        public bool UseGeocoderCache { get; set; }

        /// <summary>
        /// Использовать системные часовые пояса. (в противном случае используются данные геокодера)
        /// </summary>
        public bool UseSystemTimeZones { get;  set; }

        /// <summary>
        /// если истина, то будет использоваться кэш объектов слоя карты
        /// </summary>
        public bool UseMapLayerCache { get;  set; }

        /// <summary>
        /// максимальное время хранения кэша картинок
        /// </summary>
        public TimeSpan MaxImageCacheAge { get;  set; }
    }
}
