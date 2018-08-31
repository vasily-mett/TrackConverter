﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GMap.NET.MapProviders;

namespace TrackConverter.Lib.Classes
{

    /// <summary>
    /// структура поставщика карты для настроек и тега в кнопке выбора источника карты
    /// </summary>
    public class MapProviderRecord
    {

        /// <summary>
        /// поставщик
        /// </summary>
        public MapProviders Enum { get; set; }

        /// <summary>
        /// заголовок
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// идентификатор
        /// </summary>
        public int ID { get; set; }

        /// <summary>
        /// Изображение карты
        /// </summary>
        public string IconName { get; set; }

        /// <summary>
        /// класс поставщика карты
        /// </summary>
        public MapProviderClasses MapProviderClass { get; set; }

        /// <summary>
        /// поставщик карты по ID
        /// </summary>
        /// <param name="id">ID поставщика</param>
        /// <returns></returns>
        public static MapProviderRecord FromID(int id)
        {
            foreach (MapProviderRecord m in Vars.Options.Map.AllMapProviders)
                if (m.ID == id)
                    return m;
            throw new ArgumentOutOfRangeException("Поставщика карты с id " + id + " не обнаружено!");
        }

        /// <summary>
        /// возвращает текстовое имя класса карт (для вывода пользователю)
        /// </summary>
        /// <param name="cl"></param>
        /// <returns></returns>
        public static string GetMapProviderClassName(MapProviderClasses cl)
        {
            switch (cl)
            {
                case MapProviderClasses.Genshtab: return "Генштаб";
                case MapProviderClasses.Google: return "Google";
                case MapProviderClasses.OSM: return "OpenStreetMaps";
                case MapProviderClasses.Yandex: return "Яндекс";
                case MapProviderClasses.None: throw new Exception("У этого класса поставщика не имени!");
                default: throw new Exception("Этот класс поставщика не реализован!");
            }
        }
    }
}
