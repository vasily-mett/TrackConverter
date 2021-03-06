﻿using System;
using System.Collections.Generic;
using System.Linq;
using TrackConverter.Lib.Data;
using TrackConverter.Lib.Tracking;

namespace TrackConverter.Lib.Mathematic.Routing
{
    /// <summary>
    /// базовый класс для прокладки маршрутов
    /// </summary>
    public abstract class BaseLogist
    {
        /// <summary>
        /// маршруты между всеми точками
        /// </summary>
        protected List<List<TrackFile>> routes;

        /// <summary>
        /// роутер для данного экземпляра
        /// </summary>
        private GeoRouter router;

        /// <summary>
        /// Дейтвие, выполняемое для обновление статусной строки в окне
        /// </summary>
        public Action<string> CallbackAction;

        /// <summary>
        /// Создает новый экземпляр класса с указанным действием вывода информации
        /// </summary>
        /// <param name="CallbackAction"></param>
        public BaseLogist(Action<string> CallbackAction)
        {
            this.CallbackAction = CallbackAction;
        }

        /// <summary>
        /// обработка результата. Построение пути по выбранным номерам вершин
        /// </summary>
        /// <param name="way">выбранные номера вершин</param>
        /// <param name="isCycled">если истина, то маршрут будет замкнутым</param>
        /// <returns></returns>
        protected TrackFile ProcessResult(int[] way, bool isCycled)
        {
            if (Vars.Options.Services.UseFSCacheForCreatingRoutes && router != null)
            {
                TrackFile res = new TrackFile();
                for (int i = 0; i < way.Length - 1; i++)
                {
                    TrackFile cur = router.GetRouteFromFSCache(way[i], way[i + 1]);
                    res.Add(cur.GetRange(0, cur.Count - 1)); //получаем маршрут без последней точки
                }

                //замыкание маршрута, если надо
                if (isCycled)
                    res.Add(router.GetRouteFromFSCache(way[way.Length - 1], way[0]));

                return res;
            }
            else
            {
                TrackFile res = new TrackFile();
                for (int i = 0; i < way.Length - 1; i++)
                {
                    TrackFile cur = routes[way[i]][way[i + 1]];
                    int count = -1;
                    if (i == way.Length - 2)
                        if (isCycled)
                            count = cur.Count - 1;
                        else
                            count = cur.Count;// если эта точка последняя, то нужно взять все точки маршрута
                    else
                        count = cur.Count - 1;

                    var range = cur.GetRange(0, count);
                    res.Add(range); //получаем маршрут без последней точки
                }

                //замыкание маршрута, если надо
                if (isCycled)
                    res.Add(routes[way[way.Length - 1]][way[0]]);

                return res;
            }
        }

        /// <summary>
        /// расчет матрицы расстояний между точками через сервис прокладки 
        /// маршрутов или напрямую в зависимости от выбранных настроек Vars.Options.Map.UseRouterInOptimal
        /// </summary>
        /// <param name="points">точки между которыми надо построить маршруты</param>
        /// <returns></returns>
        protected List<List<TrackFile>> GetRoutes(BaseTrack points)
        {
            if (points.Count > 158)
                throw new ArgumentOutOfRangeException("points.Count", "Количество точек должно быть меньше 158");
            if (Vars.Options.Map.UseRouterInOptimal) //если надо использовать маршрутизацию при построении 
            {
                router = new GeoRouter(Vars.Options.Services.PathRouteProvider);
                return router.CreateRoutes(points, CallbackAction);
            }

            //добавление прямых расстояний, если не требуется использование маршрутизатора
            List<List<TrackFile>> res = new List<List<TrackFile>>();
            double k = 0;
            double all = points.Count * points.Count;
            for (int i = 0; i < points.Count; i++)
            {
                List<TrackFile> row = new List<TrackFile>();
                for (int j = 0; j < points.Count; j++)
                {
                    k++;
                    if (j == i)
                        row.Add(null);
                    else
                    {
                        TrackFile route = new TrackFile
                        {
                            points[i],
                            points[j]
                        };
                        route.CalculateAll();
                        row.Add(route);
                    }
                    if (CallbackAction != null)
                        CallbackAction.Invoke("Построение маршрута: расчет расстояний между точками, завершено " + (k / all * 100d).ToString("0.0") + "%");
                }
                res.Add(row.ToList());
            }
            return res;
        }
    }
}
