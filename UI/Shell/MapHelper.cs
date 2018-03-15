﻿using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using TrackConverter.Lib.Classes;
using TrackConverter.Lib.Classes.StackEdits;
using TrackConverter.Lib.Data;
using TrackConverter.Lib.Maping.GMap;
using TrackConverter.Lib.Tracking;
using TrackConverter.Res;
using TrackConverter.Res.Properties;
using TrackConverter.UI.Common.Dialogs;
using TrackConverter.UI.Map;
using static TrackConverter.Lib.Classes.StackEdits.Actions;
using System.ComponentModel;

namespace TrackConverter.UI.Shell
{
    internal partial class MapHelper
    {
        private FormMain formMain;



        public MapHelper(FormMain formMain)
        {
            this.formMain = formMain;
            ConfigureGMapControl();
        }

        /// <summary>
        /// настройки браузера карты
        /// </summary>
        private void ConfigureGMapControl()
        {

            #region системные настройки

            formMain.gmapControlMap.DragButton = MouseButtons.Left;

            //порядок получения данных 
            GMaps.Instance.Mode = Vars.Options.Map.AccessMode;
            GMaps.Instance.CacheOnIdleRead = true;
            GMaps.Instance.BoostCacheEngine = true;
            GMaps.Instance.MemoryCache.Capacity = 100; //максимальный размер кэша в МБ

            //zoom
            formMain.gmapControlMap.MaxZoom = 20;
            formMain.gmapControlMap.Zoom = Vars.Options.Map.Zoom;
            OnMapZoomChanged();

            //информация о масштабе карты
            formMain.gmapControlMap.MapScaleInfoEnabled = true;

            //включение кэша карт, маршрутов итд
            formMain.gmapControlMap.Manager.UseDirectionsCache = true;
            formMain.gmapControlMap.Manager.UseGeocoderCache = true;
            formMain.gmapControlMap.Manager.UseMemoryCache = true;
            formMain.gmapControlMap.Manager.UsePlacemarkCache = true;
            formMain.gmapControlMap.Manager.UseRouteCache = true;
            formMain.gmapControlMap.Manager.UseUrlCache = true;

            //отключение черно-белого режима
            formMain.gmapControlMap.GrayScaleMode = false;

            //заполнение отсутствующих тайлов из меньшего масштаба
            formMain.gmapControlMap.FillEmptyTiles = true;

            //язык карты
            GMapProvider.Language = Vars.Options.Map.MapLanguange;

            //поставщик карты
            switch (Vars.Options.Map.MapProvider.Enum)
            {
                case MapProviders.GoogleHybridMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.GoogleHybridMap;
                    break;
                case MapProviders.GoogleMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.GoogleMap;
                    break;
                case MapProviders.GoogleSatelliteMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.GoogleSatelliteMap;
                    break;
                case MapProviders.OpenCycleMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.OpenCycleMap;
                    break;
                case MapProviders.YandexHybridMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.YandexHybridMap;
                    break;
                case MapProviders.YandexMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.YandexMap;
                    break;
                case MapProviders.YandexSatelliteMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.YandexSatelliteMap;
                    break;
                case MapProviders.WikimapiaMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.WikiMapiaMap;
                    break;
                default:
                    throw new NotSupportedException("Этот поставщик карты не поддерживается " + Vars.Options.Map.MapProvider.Enum);
            }


            //Если вы используете интернет через прокси сервер,
            //указываем свои учетные данные.
            GMapProvider.WebProxy = WebRequest.GetSystemWebProxy();
            GMapProvider.WebProxy.Credentials = CredentialCache.DefaultCredentials;

            //центральная точка
            if (Vars.Options.Map.LastCenterPoint != null)
                formMain.gmapControlMap.Position = Vars.Options.Map.LastCenterPoint;
            else
            {
                formMain.gmapControlMap.Position = new PointLatLng(37, 55);
                Vars.Options.Map.LastCenterPoint = formMain.gmapControlMap.Position;
            }

            //вид пустых тайлов
            formMain.gmapControlMap.EmptyMapBackground = Color.White;
            formMain.gmapControlMap.EmptyTileColor = Color.White;
            formMain.gmapControlMap.EmptyTileText = "Не удалось загрузить изображение \r\n Возможно, проблема с интернет-соединением или попробуйте уменьшить масштаб.";
            formMain.gmapControlMap.MapScaleInfoEnabled = true;

            //папка с кэшем
            Directory.CreateDirectory(Application.StartupPath + Resources.cache_directory);
            formMain.gmapControlMap.CacheLocation = Application.StartupPath + Resources.cache_directory;

            #endregion


            //обновление галочек в меню способа загрузки тайлов
            formMain.tmCacheToolStripMenuItem.Checked = Vars.Options.Map.AccessMode == AccessMode.CacheOnly;
            formMain.tmInternetCacheToolStripMenuItem.Checked = Vars.Options.Map.AccessMode == AccessMode.ServerAndCache;
            formMain.tmInternetToolStripMenuItem.Checked = Vars.Options.Map.AccessMode == AccessMode.ServerOnly;

            #region создание объектов

            //создание слоев на карте
            formMain.selectedPointsOverlay = new GMapOverlay(formMain.selectedPointsOverlayID);
            formMain.selectedRouteOverlay = new GMapOverlay(formMain.selectedRouteOverlayID);
            formMain.creatingRouteOverlay = new GMapOverlay(formMain.creatingRouteOverlayID);
            formMain.rulerRouteOverlay = new GMapOverlay(formMain.rulerRouteOverlayID);
            formMain.baseOverlay = new GMapOverlay(formMain.baseOverlayID);
            formMain.fromToOverlay = new GMapOverlay(formMain.fromToOverlayID);
            formMain.whatThereOverlay = new GMapOverlay(formMain.whatThereOverlayID);
            formMain.creatingTripOverlay = new GMapOverlay(formMain.creatingTripOverlayID);

            //добавление слоев на карту
            formMain.gmapControlMap.Overlays.Add(formMain.selectedPointsOverlay);
            formMain.gmapControlMap.Overlays.Add(formMain.selectedRouteOverlay);
            formMain.gmapControlMap.Overlays.Add(formMain.creatingRouteOverlay);
            formMain.gmapControlMap.Overlays.Add(formMain.rulerRouteOverlay);
            formMain.gmapControlMap.Overlays.Add(formMain.baseOverlay);
            formMain.gmapControlMap.Overlays.Add(formMain.fromToOverlay);
            formMain.gmapControlMap.Overlays.Add(formMain.creatingTripOverlay);
            formMain.gmapControlMap.Overlays.Add(formMain.whatThereOverlay);

            #endregion
        }

        #region События карты


        internal void OnMapZoomChanged()
        {
            if (!Program.winNavigatorNullOrDisposed && Program.winNavigator.Visible)
                Program.winNavigator.labelZoom.Text = "Zoom: " + formMain.gmapControlMap.Zoom;
            formMain.toolStripLabelZoom.Text = formMain.gmapControlMap.Zoom.ToString();
            Vars.Options.Map.Zoom = formMain.gmapControlMap.Zoom;
        }

        internal void MouseClick(MouseEventArgs e)
        {
            #region добавление точки к новому маршруту если 

            //происходит создание маршрута, 
            //не происходит перемещение маркера,
            //указатель не находится на другом маркере
            if (e.Button == MouseButtons.Left && //если левая кнопка
                (formMain.isCreatingRoute || formMain.isRuling) && //создание маршрута или линейка
                !formMain.isMarkerMoving && //не происходит движение маркера
                !formMain.isMarkerClicked)
            {
                //обновление информации в списке точек после перемещения
                RefreshWaypoints();

                if (formMain.isCreatingRoute)
                {
                    PointLatLng pt = formMain.gmapControlMap.FromLocalToLatLng(e.X, e.Y);

                    //если выделена последняя точка, то добавляем
                    if (formMain.selectedPointIndex == formMain.creatingRoute.Count)
                    {
                        formMain.creatingRoute.Add(new TrackPoint(pt));
                        formMain.selectedPointIndex = formMain.creatingRoute.Count - 1;
                    }
                    //если выделена точка в середине маршрута, то вставляем после нее
                    else
                    {
                        formMain.creatingRoute.Insert(formMain.selectedPointIndex + 1, new TrackPoint(pt));
                        formMain.selectedPointIndex++;
                    }

                    //вывод нового маршрута на экран
                    ShowCreatingRoute(formMain.creatingRouteOverlay, formMain.creatingRoute);
                }
                if (formMain.isRuling)
                {
                    PointLatLng pt = formMain.gmapControlMap.FromLocalToLatLng(e.X, e.Y);

                    //если выделена последняя точка, то добавляем
                    if (formMain.selectedPointIndex == formMain.rulerRoute.Count)
                    {
                        formMain.rulerRoute.Add(new TrackPoint(pt));
                        formMain.selectedPointIndex = formMain.rulerRoute.Count - 1;
                    }
                    //если выделена точка в середине маршрута, то вставляем после нее
                    else
                    {
                        formMain.rulerRoute.Insert(formMain.selectedPointIndex + 1, new TrackPoint(pt));
                        formMain.selectedPointIndex++;
                    }

                    //вывод нового маршрута на экран
                    ShowCreatingRoute(formMain.rulerRouteOverlay, formMain.rulerRoute);
                }
                return;
            }
            #endregion

            #region выбор точки при редактировании путешествия
            //если идёт выбор точки, не идёт создание маршрута и не линейка и клик не на маркере
            if (formMain.isSelectingPoint && !(formMain.isCreatingRoute || formMain.isRuling) && !formMain.isMarkerClicked && !formMain.gmapControlMap.IsDragging)
            {
                PointLatLng pt = formMain.gmapControlMap.FromLocalToLatLng(e.X, e.Y);
                TrackPoint newpt = new TrackPoint(pt);
                FormEditPoint fep = new FormEditPoint(newpt);
                DialogResult res = fep.ShowDialog();
                if (res == DialogResult.OK)
                {
                    TrackPoint newPoint = fep.Result;
                    formMain.AfterSelectPointAction.Invoke(newPoint);
                }
                if (res == DialogResult.Cancel)
                    if (formMain.CancelSelectPointAction != null)
                        formMain.CancelSelectPointAction.Invoke();
            }

            #endregion

            formMain.isMarkerClicked = false;
        }

        internal void OnPositionChanged(PointLatLng point)
        {
            Vars.Options.Map.LastCenterPoint = point;
        }

        internal void OnMarkerClick(GMapMarker itm, MouseEventArgs e)
        {
            MapMarker item = itm as MapMarker;

            //изменение инормаци по лкм
            //если не происходило перемещение маркера и не "что здесь"  и не происходит создание маршрута и не линейка
            if (!formMain.isMarkerMoving && !formMain.isCreatingRoute && !formMain.isRuling && item.Tag.Type != MarkerTypes.WhatThere && e.Button == MouseButtons.Left)
            {
                formMain.markerClicked = item;
                formMain.isMarkerClicked = true;
                toolStripEditMarker(e);
                return;
            }

            //открытие соответствующего окна Что Здесь по маркеру
            //если не происходило перемещение маркера и не происходит создание маршрута и не линейка и "что здесь"
            if (!formMain.isMarkerMoving && !formMain.isCreatingRoute && !formMain.isRuling && item.Tag.Type == MarkerTypes.WhatThere && e.Button == MouseButtons.Left)
            {
                //если в словаре уже есть такая точка, то открываем окно
                if (formMain.ActiveWhatThereForms.ContainsKey(item.Tag.Info))
                {
                    FormWhatsthere fw = formMain.ActiveWhatThereForms[item.Tag.Info];
                    if (!fw.Visible)
                        fw.Show(Program.winMain);
                    else
                        fw.Activate();
                }

                //если точки нет, то создаем новое окно и заносим в словарь
                else
                {
                    FormWhatsthere fw = new FormWhatsthere(item.Tag.Info);
                    fw.Show(Program.winMain);
                    formMain.ActiveWhatThereForms.Add(item.Tag.Info, fw);
                }
            }

            //открытие контекстного меню по пкм
            //если не передвижение маркера и не создание маршрута и правая кнопка мыши то вывод меню маркера
            if (!formMain.isMarkerMoving && item.Tag.Type != MarkerTypes.CreatingRoute && e.Button == MouseButtons.Right)
            {
                formMain.markerClicked = item;
                formMain.contextMenuStripMarker.Show(new Point(e.X, e.Y));
                return;
            }

            //выделение нажатого маркера при создании маршрута
            if (e.Button == MouseButtons.Left && (formMain.isCreatingRoute || formMain.isRuling) && !formMain.isMarkerMoving && formMain.gmapControlMap.IsMouseOverMarker)
            {
                if (formMain.isCreatingRoute)
                {
                    if (formMain.creatingRoute.Contains(item.Tag.Info))
                    {
                        formMain.selectedPointIndex = formMain.creatingRoute.IndexOf(item.Tag.Info);
                        formMain.isMarkerClicked = true;
                        ShowCreatingRoute(formMain.creatingRouteOverlay, formMain.creatingRoute);
                    }
                }
                if (formMain.isRuling)
                {
                    if (formMain.rulerRoute.Contains(item.Tag.Info))
                    {
                        formMain.selectedPointIndex = formMain.rulerRoute.IndexOf(item.Tag.Info);
                        formMain.isMarkerClicked = true;
                        ShowCreatingRoute(formMain.rulerRouteOverlay, formMain.rulerRoute);
                    }
                }
            }
        }

        internal void OnMarkerEnter(GMapMarker itm)
        {
            MapMarker item = itm as MapMarker;
            if (!formMain.isMarkerMoving)
                formMain.currentMarker = item as MapMarker;

            //если маркер нового маршрута, то вывод расстояия от начала пути
            if (formMain.isCreatingRoute && item.Tag.Type == MarkerTypes.CreatingRoute)
            {
                TrackFile tf = new TrackFile(formMain.creatingRoute.Take(formMain.creatingRoute.IndexOf(item.Tag.Info) + 1));
                tf.CalculateAll();
                double lg = tf.Distance;
                formMain.toolStripStatusLabelFromStart.Text = "От начала пути: " + lg;
            }
            //вывод подсказки (долгота широта имя)
            if (!formMain.isCreatingRoute && (item.Tag.Type != MarkerTypes.WhatThere))
            {
                item.ToolTipText = item.Tag.Info.Name;
                //string.Format(
                //    "{2}\r\n{0},{1}",
                //    item.Position.Lat.ToString("00.000"),
                //    item.Position.Lng.ToString("00.000"),
                //    item.Tag.Info.Name
                //);
            }
            else
            {

            }
        }

        internal void OnMarkerLeave(GMapMarker item)
        {
            formMain.toolStripStatusLabelFromStart.Text = "";
        }

        internal void MapTypeChanged(GMapProvider type)
        {
            //очистка кэша
            GMaps.Instance.MemoryCache.Clear();

            if (type.MaxZoom == null)
                formMain.gmapControlMap.MaxZoom = 21;
            else
                formMain.gmapControlMap.MaxZoom = (int)type.MaxZoom;
            formMain.gmapControlMap.MinZoom = type.MinZoom;
        }

        internal void OnMapDrag()
        {
            formMain.currentMarker = null;
        }

        internal void MouseUp(MouseEventArgs e)
        {
            //Выполняем проверку, какая клавиша мыши была отпущена,
            //если левая то устанавливаем переменной значение false.
            if (e.Button == MouseButtons.Left)
            {
                formMain.isLeftButtonDown = false;

                if (formMain.isMarkerMoving)
                {
                    //если это маркер построения маршрута, то перестраиваем маршрут
                    if (formMain.currentMarker.Tag.Type == MarkerTypes.PathingRoute)
                    {
                        TryPathRoute(formMain.currentMarker.Tag.Info.Name, false);
                    }

                    //добавление информации для отмены действия
                    formMain.LastEditsStack.Push(
                            new StackItem(
                                new MarkerMoveInfo(
                                    formMain.currentMarker.Tag.Info,
                                    formMain.oldMarker, new Action<TrackPoint, TrackPoint>(
                                        (newPt, oldPt) =>
                                        {
                                            if (formMain.creatingRoute != null && formMain.creatingRoute.Contains(newPt))
                                            {
                                                formMain.creatingRoute[formMain.creatingRoute.IndexOf(newPt)] = oldPt;
                                                ShowCreatingRoute(formMain.creatingRouteOverlay, formMain.creatingRoute);
                                            }
                                            if (formMain.rulerRoute != null && formMain.rulerRoute.Contains(newPt))
                                            {
                                                formMain.rulerRoute[formMain.rulerRoute.IndexOf(newPt)] = oldPt;
                                                ShowCreatingRoute(formMain.rulerRouteOverlay, formMain.rulerRoute);
                                            }
                                            if (formMain.waypoints != null && formMain.waypoints.Contains(newPt))
                                            {
                                                formMain.waypoints[formMain.waypoints.IndexOf(newPt)] = oldPt;
                                                ShowWaypoints(formMain.waypoints, formMain.baseOverlay, true);
                                            }
                                        }
                                    )
                                )
                            )
                        );
                    UpdateUndoButton();
                    formMain.isMarkerMoving = false;
                }

                //обновление информации в списке точек после перемещения
                RefreshWaypoints();
                return;
            }

            //вывод контекстного меню если не перемещается карта и мышь не на маршруте
            if (e.Button == MouseButtons.Right && !formMain.gmapControlMap.IsDragging && !formMain.gmapControlMap.IsMouseOverRoute)
            {
                if (!formMain.gmapControlMap.IsMouseOverMarker)
                {
                    formMain.contextMenuStripMap.Show(formMain.gmapControlMap, new Point(e.X, e.Y));
                    formMain.pointClicked = formMain.gmapControlMap.FromLocalToLatLng(e.X, e.Y);
                }
                return;
            }
        }

        internal void MouseMove(MouseEventArgs e)
        {
            //если курсор за пределами карты, то выход.
            PointLatLng ll = formMain.gmapControlMap.FromLocalToLatLng(e.X, e.Y);
            if (Math.Abs(ll.Lat) > 90 || Math.Abs(ll.Lng) > 180)
                return;

            //вывод информации о координатах мыши
            Coordinate cr = new Coordinate(formMain.gmapControlMap.FromLocalToLatLng(e.X, e.Y));
            formMain.toolStripStatusLabelLat.Text = cr.Latitude.ToString("ddºmm'ss.s\"H");
            formMain.toolStripStatusLabelLon.Text = cr.Longitude.ToString("ddºmm'ss.s\"H");

            //передвижение маркера
            //Проверка, что нажата левая клавиша мыши и не происходит перемещение карты
            if (formMain.currentMarker != null &&
                e.Button == MouseButtons.Left &&
                formMain.isLeftButtonDown &&
                (formMain.currentMarker.Tag.Type != MarkerTypes.WhatThere))
            {

                if (!formMain.isMarkerMoving) //если движение маркера только начинается, то запоминаемего положение для отмены
                    formMain.oldMarker = formMain.currentMarker.Tag.Info.Clone();
                formMain.isMarkerMoving = true;

                PointLatLng point = formMain.gmapControlMap.FromLocalToLatLng(e.X, e.Y);

                //Получение координат маркера.
                formMain.currentMarker.Position = point;
                formMain.currentMarker.Tag.Info.Coordinates = new Coordinate(point);

                //Вывод координат маркера в подсказке.
                formMain.currentMarker.ToolTipText = string.Format("{0},{1}", point.Lat.ToString("00.000"), point.Lng.ToString("00.000"));


                //если создается маршрут, то обновляем длину маршрута
                if (formMain.isCreatingRoute)
                    ShowCreatingRoute(formMain.creatingRouteOverlay, formMain.creatingRoute);
                if (formMain.isRuling)
                    ShowCreatingRoute(formMain.rulerRouteOverlay, formMain.rulerRoute);
            }

        }

        internal void MouseDown(MouseEventArgs e)
        {
            //Выполняем проверку, какая клавиша мыши была нажата,
            //если левая, то устанавливаем переменной значение true.
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                formMain.isLeftButtonDown = true;
            }

            //сброс текущего маркера
            if (!formMain.gmapControlMap.IsMouseOverMarker)
                formMain.currentMarker = null;
        }

        internal void MouseDoubleClick(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
                formMain.gmapControlMap.Zoom++;
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
                formMain.gmapControlMap.Zoom--;
        }

        internal void OnRouteClick(GMapRoute item, MouseEventArgs e)
        {
            //выделение по лкм если не линейка и не создание маршрута
            if (e.Button == MouseButtons.Left && !formMain.isCreatingRoute && !formMain.isRuling)
            {
                if (item.Tag != null)
                {
                    TrackFile tf = item.Tag as TrackFile;
                    Vars.currentSelectedTrack = tf;
                    formMain.converterHelper.RefreshData();
                    formMain.pointsHelper.RefreshData();
                    formMain.graphHelper.RefreshData();
                }
                return;
            }

            //контекстное меню по правой кнопке если не линейка и не создание маршрута
            if (e.Button == MouseButtons.Right && !formMain.isCreatingRoute && !formMain.isRuling)
            {
                formMain.routeClicked = item;
                formMain.contextMenuStripRoute.Show(new Point(e.X, e.Y));
                return;
            }

        }

        #endregion

        #region Кнопки

        internal void UndoClick(EventArgs e)
        {
            if (formMain.LastEditsStack.Count > 0)
                formMain.LastEditsStack.Pop().Data.Undo();
            UpdateUndoButton();
        }

        internal void ZoomIn_Click(EventArgs e)
        {
            formMain.gmapControlMap.Zoom++;
        }

        internal void RulerClick(EventArgs e)
        {
            if (formMain.isCreatingRoute)
            {
                MessageBox.Show("Идет создание маршрута. Завершите Создание перед тем, как использовать этот инструмент");
                return;
            }
            formMain.gmapControlMap.DragButton = System.Windows.Forms.MouseButtons.Right;
            formMain.isRuling = true;
            formMain.rulerRouteOverlay.Clear();
            formMain.rulerRoute = new TrackFile();
            Program.winRouteEditor = new FormEditRoute(
                "Измерениe расстояния",
                formMain.rulerRoute,
                formMain.rulerRouteOverlay,
                null,
                null
                );
            Program.winRouteEditor.Show(Program.winMain); ;
        }

        internal void ZoomOutClick(EventArgs e)
        {
            formMain.gmapControlMap.Zoom--;
        }


        internal void mpProvider_Click(object sender, EventArgs e)
        {
            MapProviderRecord mpr = (MapProviderRecord)((ToolStripMenuItem)sender).Tag;
            switch (mpr.Enum)
            {
                case MapProviders.GoogleHybridMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.GoogleHybridMap;
                    break;
                case MapProviders.GoogleMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.GoogleMap;
                    break;
                case MapProviders.GoogleSatelliteMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.GoogleSatelliteMap;
                    break;
                case MapProviders.OpenCycleMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.OpenCycleMap;
                    break;
                case MapProviders.YandexHybridMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.YandexHybridMap;
                    break;
                case MapProviders.YandexMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.YandexMap;
                    break;
                case MapProviders.YandexSatelliteMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.YandexSatelliteMap;
                    break;
                case MapProviders.WikimapiaMap:
                    formMain.gmapControlMap.MapProvider = GMapProviders.WikiMapiaMap;
                    break;
                default:
                    throw new NotSupportedException("Этот поставщик карты не поддерживается " + mpr.Enum);
            }


            Vars.Options.Map.MapProvider = mpr;

            foreach (ToolStripMenuItem ti in formMain.toolStripDropDownButtonMapProvider.DropDownItems)
                if (((MapProviderRecord)(ti.Tag)).ID == mpr.ID)
                    ti.Checked = true;
                else
                    ti.Checked = false;

            foreach (ToolStripMenuItem ti in formMain.mapProviderToolStripMenuItem.DropDownItems)
                if (((MapProviderRecord)(ti.Tag)).ID == mpr.ID)
                    ti.Checked = true;
                else
                    ti.Checked = false;
        }

        #endregion

        #region Контекстные меню

        internal void ContextMenuMapOpening(object sender, CancelEventArgs e)
        {
           formMain.clearFromtoMarkersToolStripMenuItem.Visible = formMain.fromToOverlay.Markers.Count != 0;
        }
        
        internal void ContextMenuMarkerOpening(object sender, CancelEventArgs e)
        {
            bool canEdit = formMain.markerClicked.Tag.Type != MarkerTypes.WhatThere & formMain.markerClicked.Tag.Type != MarkerTypes.PathingRoute;
            formMain.editMarkerToolStripMenuItem.Visible = canEdit;
        }

        internal void toolStripDeleteRoute(EventArgs e)
        {
            formMain.converterHelper.DeleteRoute(formMain.routeClicked.Tag as TrackFile);
        }

        internal void toolStripDeleteMarker(EventArgs e)
        {
            if (MessageBox.Show(formMain, "Вы действительно хотите удалить этот маркер?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                formMain.baseOverlay.Markers.Remove(formMain.markerClicked);
                if (formMain.waypoints != null)
                    formMain.waypoints.Remove(formMain.markerClicked.Tag.Info);

                //если маркер прокладки маршрута, то удаляем его из соответствующей точки
                if (formMain.markerClicked.Tag.Type == MarkerTypes.PathingRoute)
                {
                    formMain.fromToOverlay.Markers.Remove(formMain.markerClicked);
                    switch (formMain.markerClicked.Tag.PathingType)
                    {
                        case PathingType.Start:
                            formMain.fromPoint = null;
                            break;
                        case PathingType.Finish:
                            formMain.toPoint = null;
                            break;
                        case PathingType.Intermed:
                            formMain.IntermediatePoints.Remove(formMain.markerClicked.Tag.Info);
                            break;
                    }
                }
                else
                {
                    UpdateUndoButton();
                    formMain.LastEditsStack.Push(
                        new StackItem(
                            new MarkerDeleteInfo(formMain.markerClicked.Tag.Info, new Action<TrackPoint>(
                                (oldP) =>
                                {
                                    formMain.waypoints.Add(oldP);
                                    ShowWaypoints(formMain.waypoints, formMain.baseOverlay, false);
                                }
                                )
                                )
                            )
                        );
                    UpdateUndoButton();
                }
            }
        }

        internal void toolStripEditRoute(EventArgs e)
        {

            if (formMain.routeClicked.Tag != null)
            {
                TrackFile tf = formMain.routeClicked.Tag as TrackFile;
                if (formMain.Tracks.Contains(tf))
                    formMain.converterHelper.BeginEditRoute(tf);
            }
        }

        internal void toolStripEditMarker(EventArgs e)
        {
            //запоминание предыдущего тега
            MarkerTag tag = formMain.markerClicked.Tag;


            FormEditPoint fe = new FormEditPoint(tag.Info);
            fe.ShowDialog(formMain);

            //если информация изменилась, то записываем новую
            if (fe.DialogResult == DialogResult.OK)
            {
                formMain.markerClicked.Tag.Info = fe.Result; //запись нофой информации в тег
                DeleteWaypoint(formMain.markerClicked.Tag.Info, formMain.baseOverlay); //удаление маркера со слоя
                ShowWaypoint(formMain.markerClicked.Tag.Info, formMain.baseOverlay, false); //добавление маркера в слой
                UpdateUndoButton();
                formMain.LastEditsStack.Push(
                    new StackItem(
                        new MarkerEditInfo(fe.Result, tag.Info, new Action<TrackPoint, TrackPoint>(
                            (newP, oldP) =>
                            {
                                if (formMain.waypoints.Contains(newP))
                                {
                                    formMain.waypoints[formMain.waypoints.IndexOf(newP)] = oldP;
                                    ShowWaypoints(formMain.waypoints, formMain.baseOverlay, true);
                                }
                            }
                            )
                    )
                    )

               );
                UpdateUndoButton();

            }
            //если нет - старую
            else
                formMain.markerClicked.Tag = tag;
        }

        internal void toolStripCopyCoordinates(EventArgs e)
        {
            Coordinate cr = new Coordinate(formMain.pointClicked);
            Clipboard.SetText(cr.ToString("{lat} {lon}", "ddºmm'ss.s\"H"));
        }

        internal void toolStripWhatThere(EventArgs e)
        {
            TrackPoint point = new TrackPoint(formMain.pointClicked);
            point.Icon = IconOffsets.what_there;
            try
            {
                FormWhatsthere wt = new FormWhatsthere(point);
                wt.Show(Program.winMain);

                //добавление в словарь окон
                if (formMain.ActiveWhatThereForms == null)
                    formMain.ActiveWhatThereForms = new Dictionary<TrackPoint, FormWhatsthere>();
                formMain.ActiveWhatThereForms.Add(point, wt);

                //вывод значка на экран
                ShowWaypoint(point, formMain.whatThereOverlay, Resources.what_there, MarkerTypes.WhatThere, MarkerTooltipMode.OnMouseOver);
            }
            catch (Exception we)
            {
                MessageBox.Show(formMain, "Не удалось получить информацию.\r\n" + we.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void toolStripClearFromToMarkers(EventArgs e)
        {
            formMain.fromToOverlay.Clear();
            formMain.fromPoint = null;
            formMain.toPoint = null;
            formMain.IntermediatePoints = null;
        }

        internal void toolStripCreateRoute(object sender,EventArgs e)
        {
            TryPathRoute((string)((ToolStripMenuItem)sender).Tag, true);
        }

        internal void toolStripAddWaypoint(EventArgs e)
        {
            if (formMain.waypoints == null)
                formMain.waypoints = new TrackFile();
            TrackPoint tt = new TrackPoint(formMain.pointClicked);
            FormEditPoint fe = new FormEditPoint(tt);
            if (fe.ShowDialog(formMain) == DialogResult.OK)
            {
                ShowWaypoint(fe.Result, formMain.baseOverlay, true);
                formMain.LastEditsStack.Push(
                    new StackItem(
                        new MarkerAddInfo(fe.Result, new Action<TrackPoint>(
                            (newP) =>
                            {
                                if (formMain.waypoints.Contains(newP))
                                {
                                    formMain.waypoints.Remove(newP);
                                    ShowWaypoints(formMain.waypoints, formMain.baseOverlay, true);
                                }
                            }
                            )
                        )
                    )
                    );
                UpdateUndoButton();

            }
        }

        #endregion

        #region вспомогательные методы

        /// <summary>
        /// обновление списка точек после перемещения точки
        /// </summary>
        private void RefreshWaypoints()
        {
            if (formMain.waypoints == null)
                formMain.waypoints = new TrackFile();
            formMain.waypoints.Clear();
            foreach (MapMarker mm in formMain.baseOverlay.Markers)
            {
                TrackPoint tt = mm.Tag.Info;
                formMain.waypoints.Add(tt);
            }
        }

        /// <summary>
        /// вывод создаваемого маршрута и его маркеров 
        /// <param name="overlay">слой для вывода (ruler,creating)</param>
        /// <param name="track">маршрут для вывода</param>
        /// </summary>
        public void ShowCreatingRoute(GMapOverlay overlay, BaseTrack track)
        {
            if (overlay.Id != formMain.rulerRouteOverlayID && overlay.Id != formMain.creatingRouteOverlayID)
                throw new ArgumentException("Попытка вывода создаваемого маршрута на чужой слой: " + overlay.Id, "overlay");

            track.CalculateAll();
            overlay.Clear();
            int i = 0;
            foreach (TrackPoint tt in track)
            {
                Icon ic;
                if (i == formMain.selectedPointIndex)
                    ic = Resources.route_point_selected;
                else
                    ic = Resources.route_point;
                ShowWaypoint(tt, overlay, ic, MarkerTypes.CreatingRoute, MarkerTooltipMode.OnMouseOver);
                i++;
            }
            track.Color = Color.DarkBlue;
            ShowRoute(track, overlay, false);
            RefreshToolTipsCreatingRoute(overlay);
            formMain.toolStripStatusLabelInfo.Text = "Расстояние: " + track.Distance + " км, количество точек: " + track.Count;
        }


        /// <summary>
        /// обновление состояния кнопки отмены действия
        /// </summary>
        private void UpdateUndoButton()
        {
            formMain.toolStripButtonUndo.Enabled = formMain.LastEditsStack.Count > 0;
            if (formMain.LastEditsStack.Count > 0)
                formMain.toolStripButtonUndo.ToolTipText = "Отменить " + formMain.LastEditsStack.Peek().Text;
            else
                formMain.toolStripButtonUndo.ToolTipText = "Нет доступных действий для отмены";
        }

        /// <summary>
        /// попытка построить маршрут. На вход передается тег нажатой кнопки контекстного меню 
        /// (конец, начало, промежуточная точка) 
        /// если достаточно данных для построения, строится маршрут. Перед этим очищается слой fromToOverlay
        /// </summary>
        /// <param name="tag"></param>
        /// <param name="isAddedNewPoint">если истина, то была добавлена новая точка и надо определить ее тип, 
        /// если ложь, то значит были только передвижения точек  добавлять их не надо
        /// </param>
        private void TryPathRoute(string tag, bool isAddedNewPoint)
        {
            //если была добавлена новая точка, то проверяем, что за точка, добавляем, и пробуем строить
            if (isAddedNewPoint)
            {
                TrackPoint tt = new TrackPoint(formMain.pointClicked);

                if (tag == "from")
                {
                    tt.Icon = IconOffsets.marker_start;
                    DeleteWaypoint(formMain.fromPoint, formMain.fromToOverlay);
                    ShowWaypoint(tt, formMain.fromToOverlay, Resources.marker_start, MarkerTypes.PathingRoute, PathingType.Start, MarkerTooltipMode.Never);
                    tt.Name = "from";
                    formMain.fromPoint = tt;
                }
                if (tag == "to")
                {
                    tt.Icon = IconOffsets.marker_finish;
                    DeleteWaypoint(formMain.toPoint, formMain.fromToOverlay);
                    ShowWaypoint(tt, formMain.fromToOverlay, Resources.marker_finish, MarkerTypes.PathingRoute, PathingType.Finish, MarkerTooltipMode.Never);
                    tt.Name = "to";
                    formMain.toPoint = tt;
                }
                if (tag == "intermediate")
                {
                    tt.Icon = IconOffsets.ZeroOffset;
                    ShowWaypoint(tt, formMain.fromToOverlay, Resources.intermed_point, MarkerTypes.PathingRoute, PathingType.Intermed, MarkerTooltipMode.Never);
                    if (formMain.IntermediatePoints == null)
                        formMain.IntermediatePoints = new TrackFile();
                    tt.Name = "intermediate";
                    formMain.IntermediatePoints.Add(tt);
                }
            }

            if (formMain.toPoint != null && formMain.fromPoint != null) //если достаточно точек для построения маршрута, то строим
            {
                if (!isAddedNewPoint) //если новых точек нет, а только передвигали старые, то очищаем старые маршруты
                    formMain.fromToOverlay.Routes.Clear();

                //построение маршрута
                GeoRouter gr = new GeoRouter(Vars.Options.Services.PathRouteProvider);
                TrackFile rt = null;
                try { rt = gr.CreateRoute(formMain.fromPoint.Coordinates, formMain.toPoint.Coordinates, formMain.IntermediatePoints); }
                catch (Exception e)
                {
                    MessageBox.Show(formMain, e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    formMain.fromToOverlay.Clear();
                    formMain.fromPoint = null;
                    formMain.toPoint = null;
                    formMain.IntermediatePoints = null;
                    return;
                }
                rt.Color = Vars.Options.Converter.GetColor();
                rt.CalculateAll();
                rt.Name = "Новый маршрут";
                if (Vars.Options.Services.ChangePathedRoute)
                {
                    //если надо открыть маршрут для редактирования
                    BeginEditRoute(rt, (tf) => { formMain.converterHelper.EndEditRouteOrTrip(tf); }, () =>
                    {
                        for (int i = 0; i < formMain.fromToOverlay.Markers.Count;)
                        {
                            object o = formMain.fromToOverlay.Markers[i];
                            MapMarker m = o as MapMarker;
                            if (m.Tag.Type == MarkerTypes.PathingRoute)
                                formMain.fromToOverlay.Markers.Remove(o as GMapMarker);
                            else i++;
                        }
                    });
                }
                else
                {
                    //если не надо открывать маршрут
                    formMain.converterHelper.AddRouteToList(rt);
                    Vars.currentSelectedTrack = rt;
                    formMain.converterHelper.RefreshData();
                    formMain.mapHelper.RefreshData();
                    formMain.pointsHelper.RefreshData();
                    formMain.graphHelper.RefreshData();
                }
                // fromToOverlay.Clear();
                // fromPoint = null;
                // toPoint = null;
                // IntermediatePoints = null;
            }
        }

        /// <summary>
        /// обновление списка маршрутов и выделенного трека и показываемы маршрутов
        /// </summary>
        public void RefreshData()
        {
            DeselectPoints();
            formMain.selectedRouteOverlay.Clear();
            formMain.baseOverlay.Routes.Clear();

            foreach (BaseTrack tf in formMain.showingRoutesList)
                ShowRoute(tf, formMain.baseOverlay, false);

            if (Vars.currentSelectedTrack != null)
                ShowRoute(Vars.currentSelectedTrack, formMain.selectedRouteOverlay, true);

        }

        /// <summary>
        /// отменить выделение всех точек
        /// </summary>
        public void DeselectPoints()
        {
            if (formMain.selectedPointsOverlay != null)
                formMain.selectedPointsOverlay.Markers.Clear();
        }


        /// <summary>
        /// обновление подсказок над маркерами создаваемого маршрута
        /// </summary>
        private void RefreshToolTipsCreatingRoute(GMapOverlay overlay)
        {
            foreach (MapMarker item in overlay.Markers)
            {
                item.ToolTip = new GMapToolTip(item);
                item.ToolTipMode = MarkerTooltipMode.Always;
                item.ToolTip.Fill = new SolidBrush(Color.Transparent);
                item.ToolTip.Foreground = new SolidBrush(Color.Black);
                item.ToolTip.Stroke = new Pen(Color.Black, 1);
                item.ToolTip.Font = new Font("Times New Roman", 10, FontStyle.Bold);
                item.ToolTipText = item.Tag.Info.Distance.ToString("00.000") + " км";
                item.ToolTipText += !double.IsNaN(item.Tag.Info.TrueAzimuth) ? "\r\nАзимут: " + item.Tag.Info.TrueAzimuth + "º" : "";
            }
        }


        /// <summary>
        /// очистка карты
        /// </summary>
        public void Clear()
        {
            formMain.mainHelper.toolStripClearAll(null, null);
        }

        /// <summary>
        /// редактирование маршрута
        /// </summary>
        /// <param name="trackFile">редактируемый маршрут</param>
        /// <param name="afterAction">Действие, выполняемое после нажатия кнопки сохранить</param>
        /// <param name="cancelAction">Действие, выполняемое после нажатия кнопки отменить или закрытии окна</param>
        public void BeginEditRoute(TrackFile trackFile, Action<TrackFile> afterAction, Action cancelAction = null)
        {
            if (trackFile == null)
                throw new ArgumentNullException("trackFile не может быть null в FormMap.BeginEditRoute()");

            formMain.gmapControlMap.DragButton = System.Windows.Forms.MouseButtons.Right;


            //если идет сздание маршрута, то прерываем
            if (formMain.isCreatingRoute)
                if (MessageBox.Show(formMain, "Уже идет создание или редактирование маршрута, прервать?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    Program.winRouteEditor.Close();
                else
                {
                    if (cancelAction != null)
                        cancelAction.Invoke();
                    return;
                }

            //открываем маршрут для редактирования
            formMain.creatingRoute = trackFile;
            formMain.creatingRouteOverlay.Clear();
            formMain.selectedRouteOverlay.Clear();
            formMain.isCreatingRoute = true;
            Program.winRouteEditor = new FormEditRoute(
                "Редактирование маршрута",
                formMain.creatingRoute,
                formMain.creatingRouteOverlay,
                afterAction,
                cancelAction
                );
            Program.winRouteEditor.Show(formMain);
            ShowCreatingRoute(formMain.creatingRouteOverlay, formMain.creatingRoute);
            RefreshToolTipsCreatingRoute(formMain.creatingRouteOverlay);
            formMain.gmapControlMap.ZoomAndCenterRoute(formMain.creatingRouteOverlay.Routes[0]);
        }

        /// <summary>
        /// редактирование маршрута
        /// </summary>
        /// <param name="trackFile">редактируемый маршрут</param>
        /// <param name="afterAction">Действие, выполняемое после нажатия кнопки сохранить</param>
        /// <param name="cancelAction">Действие, выполняемое после нажатия кнопки отменить или закрытии окна</param>
        public void BeginEditTrip(TripRouteFile trackFile, Action<TripRouteFile> afterAction, Action cancelAction = null)
        {
            if (trackFile == null)
                throw new ArgumentNullException("trackFile не может быть null в FormMap.BeginEditTrip()");

            //если идет сздание маршрута, то прерываем
            if (formMain.isCreatingRoute)
                if (MessageBox.Show(formMain, "Уже идет создание или редактирование маршрута, прервать?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    Program.winRouteEditor.Close();
                else
                {
                    if (cancelAction != null)
                        cancelAction.Invoke();
                    return;
                }

            //открываем маршрут для редактирования
            Program.winTripEditor = new FormEditTrip(
                "Редактирование путешествия",
                trackFile,
                afterAction,
                cancelAction
                );
            Program.winTripEditor.Show(Program.winMain);
        }

        /// <summary>
        /// начало выбора точки на карте
        /// </summary>
        /// <param name="after"></param>
        /// <param name="cancelAct">действие при отмене выделения точки</param>
        internal void BeginSelectPoint(Action<TrackPoint> after, Action cancelAct)
        {
            formMain.isSelectingPoint = true;
            formMain.gmapControlMap.DragButton = MouseButtons.Right;
            formMain.gmapControlMap.Cursor = Cursors.Cross;
            if (formMain.isCreatingRoute)
                Program.winRouteEditor.Close();
            formMain.AfterSelectPointAction = after;
            formMain.CancelSelectPointAction = cancelAct;
        }

        /// <summary>
        /// завершение редактирования путевых точек
        /// </summary>
        /// <param name="wpts"></param>
        public void EndEditWaypoints(BaseTrack wpts)
        {
            formMain.waypoints = wpts as TrackFile;
            this.DeselectPoints();
            this.ShowWaypoints(formMain.waypoints, true, false);
        }

        /// <summary>
        /// выделить определенную точку на карте. 
        /// Перед выделением новой точки предыдущая выделенная точка будет удалена
        /// </summary>
        /// <param name="point">точка, которую надо выделить</param>
        public void SelectPoint(TrackPoint point)
        {
            if (point == null)
                throw new ArgumentNullException("point");
            if (formMain.selectedPointsOverlay == null)
            {
                formMain.selectedPointsOverlay = new GMapOverlay();
            }

            formMain.selectedPointsOverlay.Markers.Clear();
            TrackPoint cop = point.Clone();
            cop.Icon = 75;
            ShowWaypoint(cop, formMain.selectedPointsOverlay, Resources.selected_point, MarkerTypes.SelectedPoint);

            //центр на точку
            formMain.gmapControlMap.Position = cop.Coordinates.GMap;
        }

        #endregion
    }
}
